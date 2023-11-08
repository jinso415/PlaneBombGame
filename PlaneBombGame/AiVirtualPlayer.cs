using System;
using System.Collections;
using System.Collections.Generic;
using System.Deployment.Application;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace PlaneBombGame
{
    internal class AiVirtualPlayer : Player
    {

        Plane[] planes;

        ArrayList attackHistory = new ArrayList();

        Random r = new Random(); // 以当前时间为随机数种子

        internal ArrayList vectorStore{ get; set; }

        int[,] nowMap = new int[11, 11];
        int[,] nowCnt = new int[11, 11];
        int[,] nowHeadCnt = new int[11, 11];

        public int level;

        public AiVirtualPlayer(int level=2)
        {
            this.level = level;
        }

        public void SetLevel(int level=2)
        {
            this.level = level;
        }

        public void Init()
        {
            vectorStore = Utils.GetAllLegalPlacement();            
        }

        public void UpdateInfo()
        {
            int cnt = attackHistory.Count;
            ArrayList ResVector = new ArrayList();
            // 剩余的飞机方案

            Utils.ClearInts(nowCnt, 10, 10);
            Utils.ClearInts(nowHeadCnt, 10, 10);
            foreach (Plane[] vectorPlanes in vectorStore)
            {
                if (Judger.JudgeLegalPlanePlacement(nowMap, vectorPlanes)) // 如果当前方案符合
                {
                    ResVector.Add(vectorPlanes);
                    Utils.AddPlanesOnMap(nowCnt, vectorPlanes);
                    Utils.AddPlanesHeadsOnMap(nowHeadCnt, vectorPlanes);
                }
            }
            vectorStore = ResVector;
        }
        public AttackPoint NextAttack()
        {
            AttackPoint aiAtk;
            AttackPoint randomAtk = NextRandomAttack();
            UpdateInfo();
            int count = vectorStore.Count;
            if(count == 1)
            {
                AttackPoint[] atks = Utils.GetPlanesHeads((Plane[])vectorStore[0]);
                foreach(AttackPoint atk in atks)
                {
                    if (nowMap[atk.x, atk.y] == 0)
                    {
                        aiAtk = atk;
                        break;
                    }
                }
                throw new Exception("");
            }
            else
            {
                int[] res = Utils.FindBest(nowCnt, nowHeadCnt, vectorStore.Count);
                aiAtk = new AttackPoint(res[0], res[1]);
            }

            // choose ai according to level
            double probabilityOfChoosingFirst = 1;
            if (this.level == 0)
            {
                probabilityOfChoosingFirst = 0.1;
            } else if (this.level == 1)
            {
                probabilityOfChoosingFirst = 0.5;
            } else
            {
                probabilityOfChoosingFirst = 1;
            }
            Random random = new Random();
            double randomValue = random.NextDouble();
            if (randomValue <= probabilityOfChoosingFirst)
            {
                return aiAtk;
            }
            else
            {
                return randomAtk;
            }

        }

        public AttackPoint NextRandomAttack()
        {
            List<int> lists = new List<int>();
            for (int i = 1; i < 11; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    if (this.nowMap[i, j] == 0)
                    {
                        lists.Add(i * 1000 + j);
                    }
                }
            }

            int idx = lists[new Random().Next(0, lists.Count)];
            return new AttackPoint(idx / 1000, idx % 1000);
        }

        public Plane[] GetPlanes()
        {
            return planes;
        }

        public ArrayList GetAttackHistory()
        {
            return attackHistory;
        }

        public void SetPlanes(Plane[] planes)
        {    
            this.planes = GeneratePlanes();
        }

        public void AddAttackPoint(AttackPoint attackPoint, string res = "")
        {
            attackHistory.Add(attackPoint);
            int resNum = 0;
            switch (res)
            {
                case "MISS":
                    resNum = 1;
                    break;
                case "HIT":
                    resNum = 2;
                    break;
                case "KILL":
                    resNum = 3;
                    break;
                default:
                    break;
            }
            nowMap[attackPoint.x, attackPoint.y] = resNum;
        }

        //TO DO 放置飞机策略(?) 随机是不是也可以?
        public Plane[] GeneratePlanes()
        {
            Plane[] res = new Plane[3];
            for (int i = 0; i < 3; i++)
            {
                Plane plane = new Plane(r.Next(2, 9), r.Next(2, 9), r.Next(0, 4));
                if (!Judger.JudgeLegalPlanePlacement(res, plane))
                {
                    i--;
                    continue;
                }
                res[i] = plane;
            }
            return res;
        }

        
        public AiVirtualPlayer GetAiAssistantPlayer()
        {
            return this;
        }

        public int GetCurrentLegalCount()
        {
            return vectorStore.Count;
        }
        public double GetCurrentWinRate(Player adversaryPlayer)
        {
            int currentNums = GetCurrentLegalCount();
            int adversaryNums = adversaryPlayer.GetAiAssistantPlayer().GetCurrentLegalCount();
            return 1.0 * adversaryNums / (adversaryNums + currentNums);
        }

    }
}
