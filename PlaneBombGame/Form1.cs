using System;
using System.Drawing;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Net.Sockets;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Timers;
using PlaneBombGame;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PlaneBombGame
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        private static extern IntPtr GetActiveWindow();

        public static Form1 form1 = null;

        public bool isEnemySetAllPlanes = false;

        public int lastX = -1, lastY = -1;       

        public int nowDir;

        private bool whoseTurn = true;  // 初始值设置为false 代表为后手下棋

        private int chessDownCount = 0; // 后手方的chessDownCount应该始终比先手放的小一  在接收的时候应该用的上  ....  叭

        private int kind = 1;

        internal State state;

        private MovePlane movePlaneForm;

        internal BoomPlaneSocket socket;

        public bool isConnected = false;

        private Bitmap bitmap = new Bitmap(StandardSize.BoardWidth, StandardSize.BoardHeight);        

        private bool start;

        private string[] directions = { "→", "↓", "←", "↑" };

        //飞机方向显示
        private string label1Text = "放置你的飞机 按右键切换机头朝向 当前朝向：";

        private bool adverReadyForNewGame = false;

        public  Boolean aNewGameStart = false;

        public bool isEnemyReadyForGame = false;

        private bool clientOrServer;
        private Thread TransMessageThread;

        private bool hasBeenClicked = false;

        private string getNewIp; // IP for socket
        private string getNewPort; // Port for socket

        //private System.Timers.Timer showPredictTmr = new System.Timers.Timer();

        internal static Form1 getForm1()
        {
            if (form1 == null)
            {
                form1 = new Form1();
            }
            return form1;
        }

        public Form1()
        {
            InitializeComponent();
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            start = false;
            label1.Text = "WelCome To Plane Bombbbb!!!";
        }

        //玩家对战  采用随机生成飞机  随即落点的方式
        private void button1_Click(object sender, EventArgs e)
        {
            this.kind = 0;
            label5.Text = "玩家对决";
            TopPanel.Visible = false;
            AiPanel.Visible = false;
            this.SocketSubPanel.Visible = true;
            this.SocketPanel.Visible = true;
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            this.kind = 1;
            TopPanel.Visible = false;
            AiPanel.Visible = true;
            panel1.Visible = false;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.kind = 1;
            this.button7.Enabled = true;
            this.label5.Text = "人机对决（简单）";
            BeginNewVirtualModeGame(0);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.kind = 2;
            this.button7.Enabled = true;
            this.label5.Text = "人机对决（中等）";
            BeginNewVirtualModeGame(1);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.kind = 3;
            this.button7.Enabled = true;
            this.label5.Text = "人机对决（困难）";
            BeginNewVirtualModeGame(2);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            TopPanel.Visible = true;
            AiPanel.Visible = false;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (this.kind == 0)
            {
                this.state = null;
                this.movePlaneForm = null;
                this.TransMessageThread.Abort();
                reBeginNewHumanModeGame();
            }
            else if(this.kind == 1)
            {
                button3_Click(sender, e);
            }else if(this.kind == 2)
            {
                button4_Click(sender, e);
            }
            else
            {
                button5_Click(sender, e);
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            isConnected = false;
            this.movePlaneForm.Visible = false;
            if(this.kind == 0)
            {
                this.state = null;
                this.movePlaneForm = null;
                this.socket = null;
                this.TransMessageThread.Abort();
                GC.Collect();
                this.panel1.Visible = false;
                this.TopPanel.Visible = true;
            }
            else
            {
                this.state = null;
                this.movePlaneForm = null;
                GC.Collect();
                this.panel1.Visible = false;
                this.AiPanel.Visible = true;
            }
            
            this.Width = StandardSize.HomeWidth;
            this.Height = StandardSize.HomeHeight;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BeginNewVirtualModeGame(int level)
        {
            TopPanel.Visible = false;
            AiPanel.Visible = false;
            panel1.Visible = true;
            this.Width = StandardSize.FormWidth;
            this.Height = StandardSize.FormHeight;
            label4.Text = "正在进行人机对战...";
            state = new VirtualModeState();
            nowDir = 0;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            label1.Text = label1Text + directions[nowDir];
            panel1.Invalidate();
            panel2.Invalidate();
            panel3.Invalidate();
            lastX = lastY = -1;
            start = true;
            state.SetLeftCount(0);
            state.SetAdversaryPlayer(new AiVirtualPlayer(level));
            state.SetLocalPlayer(new LocalPlayer());
            paintLoaclPlane();
            
        }

        private void BeginNewHumanModeGame()
        {
            isEnemySetAllPlanes = false;

            aNewGameStart = false;            

            if (clientOrServer)
            {
                whoseTurn = false;
            }
            else
            {
                whoseTurn = true;
            }

            state = new HumanModeState();
            nowDir = 0;

            start = true;
            state.SetLeftCount(0);
            state.SetAdversaryPlayer(new HumanPlayer());
            state.SetLocalPlayer(new LocalPlayer());

            TransMessageThread = new Thread(transMessage);
            TransMessageThread.IsBackground = true;
            TransMessageThread.Start();

            lastX = lastY = -1;
            panel1.Invalidate();
            panel2.Invalidate();
            panel3.Invalidate();

            paintLoaclPlane();                                                         
        }

        private void reBeginNewHumanModeGame()
        {
            BeginNewHumanModeGame();
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            label1.Text = label1Text + directions[nowDir];
        }

        //绘制左侧棋盘
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = Graphics.FromImage(bitmap);
            PlayingBoard.DrawCB(g);
            if (state != null)
            {
                if(state is AIModeState)
                {
                    state.DrawPlane(g,true);
                    state.DrawPoint(state.getSecondAiPlayer(), state.getFirstAiPlayer(), g);
                }
                else
                {
                    state.DrawPlane(g);
                    state.DrawPoint(state.GetAdversaryPlayer(), state.GetLocalPlayer(), g);
                }
                
               /* if (lastX != -1)
                {
                    state.GetLocalPlayer().GetPreviewPlane().Draw(g, true);
                }*/
            }
            panel2.CreateGraphics().DrawImage(bitmap, 0, 0);
            if (!isForm1Active())
            {
                this.Activate();
            }
        }

        //绘制右侧棋盘
        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = Graphics.FromImage(bitmap);
            PlayingBoard.DrawCB(g);
            if (state != null)
            {
                if(state is AIModeState)
                {
                    state.DrawPoint(state.getFirstAiPlayer(), state.getSecondAiPlayer(), g);
                    state.DrawPlane(g,false);
                }
                else
                {
                    state.DrawPoint(state.GetLocalPlayer(), state.GetAdversaryPlayer(), g);
                }
               
            }
            panel3.CreateGraphics().DrawImage(bitmap, 0, 0);
        }

        //右侧棋盘 点击绘制落点并显示颜色
        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            if (start)
            {
                

                //不是我的回合
                if (state is HumanModeState)
                {
                    if(isConnected == false)
                    {
                        this.movePlaneForm.Width = 0;
                        MessageBox.Show("请耐心等待云端接入！", "提示");
                        this.movePlaneForm.Width = 540;
                        return;
                    }
                    if(isEnemySetAllPlanes == false)
                    {
                        this.movePlaneForm.Width = 0;
                        MessageBox.Show("请耐心等待对手放置完Ta的飞机！", "提示");
                        this.movePlaneForm.Width = 540;
                        return;
                    }
                    if (isEnemyReadyForGame == false)
                    {
                        this.movePlaneForm.Width = 0;
                        MessageBox.Show("请等待对手做好新游戏准备！", "提示");
                        this.movePlaneForm.Width = 540;
                        return;
                    }
                    if (whoseTurn == false)
                    {
                        this.movePlaneForm.Width = 0;
                        MessageBox.Show("请等待对手行棋！", "提示");
                        this.movePlaneForm.Width = 540;
                        label4.Text = "请等待对手行棋！";
                        return;
                    }
                }
                if (state.GetLeftCount() != 3)
                {
                    this.movePlaneForm.Width = 0;
                    MessageBox.Show("请先放置三个飞机！ 当前飞机数 ： " + state.GetLeftCount(), "提示");
                    this.movePlaneForm.Width = 540;
                    return;
                }
                //MessageBox.Show(e.X + " " + e.Y); 相对于当前panel
                if (!Judger.JudgeLegalMouseDown(e.X, e.Y))
                {
                    this.movePlaneForm.Width = 0;
                    MessageBox.Show("位置不合法, 请重新放置", "提示");
                    this.movePlaneForm.Width = 540;
                    return;
                }

                int PlacementX = (e.X - StandardSize.toLeft) / StandardSize.BlockWidth;      // 求鼠标点击的X方向的第几个点位
                int PlacementY = (e.Y - StandardSize.toTop) / StandardSize.BlockWidth;      // 求鼠标点击的Y方向的第几个点位

                try
                {
                    if (!Judger.JudgeLegalPlacement(state.GetLocalPlayer(), PlacementX, PlacementY))
                    {
                        this.movePlaneForm.Width = 0;
                        MessageBox.Show("位置不合法, 请重新放置", "提示");
                        this.movePlaneForm.Width = 540;
                        return;
                    }

                    AttackPoint attackPoint = new AttackPoint(PlacementX, PlacementY);

                    string localRes = state.DrawLastPoint(attackPoint, state.GetAdversaryPlayer(), panel3.CreateGraphics());
                    state.GetLocalPlayer().AddAttackPoint(attackPoint, localRes); // 新的攻击点加入历史记录
                    
                    if (state is HumanModeState)
                    {
                        string chessDownStr = "1" + " " + PlacementX + " " + PlacementY + " " + chessDownCount;
                        socket.sendStr = chessDownStr;
                        chessDownCount++;
                        label4.Text = "请等待对方落子...";
                        if (Judger.JudgePlayerWin(state.GetLocalPlayer(), state.GetAdversaryPlayer()))
                        {
                            state.DrawPlane(panel3.CreateGraphics(), false);
                            state.DrawPoint(state.GetLocalPlayer(), state.GetAdversaryPlayer(), panel3.CreateGraphics());
                            this.movePlaneForm.Width = 0;
                            MessageBox.Show("You Won The Game!!");
                            this.movePlaneForm.Width = 540;
                            aNewGameStart = true;
                            label4.Text = "点击此处重新开始游戏...";                            
                            
                            return;
                        }
                        whoseTurn = false;
                    }
                    else
                    {
                        if (Judger.JudgePlayerWin(state.GetLocalPlayer(), state.GetAdversaryPlayer()))
                        {
                            state.DrawPlane(panel3.CreateGraphics(), false);
                            state.DrawPoint(state.GetLocalPlayer(), state.GetAdversaryPlayer(), panel3.CreateGraphics());
                            MessageBox.Show("You Won The Game!!");
                            label4.Text = "请选择以下操作";
                            //BeginNewVirtualModeGame();
                            start = false;//重新开始游戏                        
                            return;
                        }

                        Player player = state.GetAdversaryPlayer();

                        AttackPoint a = player.NextAttack();

                        string showMsgStr = "对方落子 :   " + a.x + " " + a.y + "，请您行棋";
                        label4.Text = showMsgStr;
                        string adRes = state.DrawLastPoint(a, state.GetLocalPlayer(), panel2.CreateGraphics());
                        player.AddAttackPoint(a, adRes);

                        Console.WriteLine("您的落子:(" + PlacementX + " ," + PlacementY + ") , 您的胜率:" +
                                    state.GetLocalPlayer().
                                    GetAiAssistantPlayer().
                                    GetCurrentWinRate(state.GetAdversaryPlayer()));
                        Console.WriteLine("AI落子:(" + a.x + " ," +  a.y + ") , AI胜率:" +
                                    ((AiVirtualPlayer)player).GetCurrentWinRate(state.GetLocalPlayer()));
                        if (Judger.JudgePlayerWin(state.GetAdversaryPlayer(),state.GetLocalPlayer()))
                        {
                            state.DrawPlane(panel3.CreateGraphics(), false);
                            state.DrawPoint(state.GetLocalPlayer(), state.GetAdversaryPlayer(), panel3.CreateGraphics());
                            MessageBox.Show("AI Won The Game!");
                            label4.Text = "请选择以下操作";
                            //BeginNewVirtualModeGame();
                            start = false;//重新开始游戏
                            button3.Enabled = true;//允许进行AI自动对战
                            state = null;
                            return;
                        }
                        AttackPoint atk = state.GetLocalPlayer().GetAiAssistantPlayer().NextAttack();
                        Console.WriteLine("AI预测下一步攻击点为(" + atk.x + " ," + atk.y + ")");
                    }
                }
                catch (Exception) { }
            }
            else
            {
                MessageBox.Show("请先开始游戏！", "提示");
            }
        }

        private void transMessage()
        {
            bool keepSendingMsg = true;
            int connectVar = 2;
            while (true && !aNewGameStart)
            {
                if(socket.isConnected == false && isConnected == false)
                {
                    if (label4.InvokeRequired)
                    {
                        Action<string> actionDelegate = (x) => { this.label4.Text = x.ToString(); };
                        this.label4.Invoke(actionDelegate, "正在等待云端接入...");
                    }
                }

                if(socket.isConnected == true && isConnected == false)
                {
                    this.button7.Enabled = true;
                    isConnected = true;
                    adverReadyForNewGame = true;
                    start = true;

                    if (label1.InvokeRequired)
                    {
                        Action<string> actionDelegate = (x) => { this.label1.Text = x.ToString(); };
                        //label1.Text = label1Text + directions[nowDir];
                        this.label1.Invoke(actionDelegate,label1Text + directions[nowDir]);
                    }

                    if (label4.InvokeRequired)
                    {
                        Action<string> actionDelegate = (x) => { this.label4.Text = x.ToString(); };
                        this.label4.Invoke(actionDelegate, "云端已接入，可以开始游戏啦");
                    }
                }

                if(socket.isConnected == false && isConnected == true)
                {
                    isConnected = false;                    
                    if (label4.InvokeRequired)
                    {
                        Action<string> actionDelegate = (x) => { this.label4.Text = x.ToString(); };
                        this.label4.Invoke(actionDelegate, "云端已下线，请重新开始游戏");                       
                    }            
                    
                }
                if(socket.isConnected == true && isConnected == true)
                {
                    if(isEnemySetAllPlanes == false)
                    {
                        if (label4.InvokeRequired)
                        {
                            Action<string> actionDelegate = (x) => { this.label4.Text = x.ToString(); };
                            this.label4.Invoke(actionDelegate, "对手正在放置Ta的飞机");
                        }
                    }
                }
                if(socket.isConnected == true && keepSendingMsg)
                {
                    //我没有接收到，发2                   
                    socket.sendStr = connectVar.ToString();
                }
                //如果接收到的消息不为空
                if (socket.receiveStr != "")
                {
                    string str = socket.receiveStr;
                    
                    string[] words = str.Split(' ');//按空格进行拆解

                    switch (int.Parse(words[0].Substring(0,1)))
                    {
                        case 0:
                            //对手飞机设置完毕，传入进行赋值   
                            // "SetPlanes 1,2,3 4,5,6 7,8,9"
                            // "   0         1    2     3 "
                            //可能会放置很多次，我们只取第一次
                            if (isEnemySetAllPlanes == false)
                            {
                                Plane[] planes = new Plane[3]; int index = -1;
                                for (int i = 1; i <= 3; i++)
                                {
                                    string[] planePlace = words[i].Split(',');
                                    Plane plane = new Plane(int.Parse(planePlace[0]), int.Parse(planePlace[1]), int.Parse(planePlace[2]));
                                    planes[++index] = plane;
                                }
                                state.GetAdversaryPlayer().SetPlanes(planes);
                                if (label4.InvokeRequired)
                                {
                                    Action<string> actionDelegate = (x) => { this.label4.Text = x.ToString(); };
                                    this.label4.Invoke(actionDelegate, "对手已经放置完Ta的飞机，随时可以开始对战！");
                                }
                                if (label1.InvokeRequired)
                                {
                                    Action<string> actionDelegate = (x) => { this.label1.Text = x.ToString(); };
                                    this.label1.Invoke(actionDelegate, "点击右侧方格以进攻对手");
                                }

                                isEnemySetAllPlanes = true;
                            }
                            break;
                        case 1:
                            //"ChessDown 1 2 chessDownCount"
                            int chessDownX = int.Parse(words[1]);
                            int chessDownY = int.Parse(words[2]);
                            int enemyChessDownCount = int.Parse(words[3]);
                            AttackPoint attackPoint = new AttackPoint(chessDownX, chessDownY);
                            //绘制棋盘
                            string res = state.DrawLastPoint(attackPoint, state.GetLocalPlayer(), panel2.CreateGraphics());

                            //加入对手落子历史
                            state.GetAdversaryPlayer().AddAttackPoint(attackPoint,res);                           
                            //判断胜负
                            if (Judger.JudgePlayerWin(state.GetAdversaryPlayer(), state.GetLocalPlayer()))
                            {
                                state.DrawPlane(panel3.CreateGraphics(), false);
                                state.DrawPoint(state.GetLocalPlayer(), state.GetAdversaryPlayer(), panel3.CreateGraphics());
                                MessageBox.Show("AdversaryPlayer Won The Game!");
                                if (label4.InvokeRequired)
                                {
                                    Action<string> actionDelegate = (x) => { this.label4.Text = x.ToString(); };
                                    this.label4.Invoke(actionDelegate, "点击此处重新开始游戏 ...");
                                }
                                if (button3.InvokeRequired)
                                {
                                    Action<bool> actionDelegate = (x) => { this.button3.Enabled = x; };
                                    this.button3.Invoke(actionDelegate, true);
                                }
                                if (button1.InvokeRequired)
                                {
                                    Action<bool> actionDelegate = (x) => { this.button1.Enabled = x; };
                                    this.button1.Invoke(actionDelegate, true);
                                }
                                aNewGameStart = true;
                            }
                            else
                            {
                                //显示文字
                                if (label4.InvokeRequired)
                                {
                                    Action<string> actionDelegate = (x) => { this.label4.Text = x.ToString(); };
                                    string showMsgStr = "对方落子 : " + attackPoint.x + " " + attackPoint.y + "，请您行棋";
                                    this.label4.Invoke(actionDelegate, showMsgStr);
                                }
                                //允许下棋
                                whoseTurn = true;
                            }
                            break;
                        case 2:
                            //我接受到了发3
                            connectVar = 3;
                            break;
                        case 3:
                            //我接到3就不再发了
                            isEnemyReadyForGame = true;
                            //保证对面会收到一个3
                            if(keepSendingMsg == true)
                            {
                                for(int i = 0; i <= 100; i++)
                                {
                                    socket.sendStr = "3";
                                    Thread.Sleep(1);
                                }
                            }
                            keepSendingMsg = false;                            
                            break;
                    } 
                    //消息翻译完毕字符串清空
                    socket.receiveStr = "";
                }
            }
        }

        // for SocketPanel
        private void SocketPanelcheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SocketPanelcheckedListBox1.SelectedIndex == 0)
            {
                SocketPanelcheckedListBox1.SetItemChecked(1, false);
                this.clientOrServer = true;
            }
            else
            {
                SocketPanelcheckedListBox1.SetItemChecked(0, false);
                this.clientOrServer = false;
            }
        }

        private void SocketPanelbutton1_Click(object sender, EventArgs e)
        {
            this.getNewIp = SocketPaneltextBox1.Text;
            this.getNewPort = SocketPaneltextBox2.Text;
            this.SocketSubPanel.Visible = false;
            this.SocketPanel.Visible = false;
            this.panel1.Visible = true;
            this.Width = StandardSize.FormWidth;
            this.Height = StandardSize.FormHeight;

            try
            {
                IPAddress ip = IPAddress.Parse(this.getNewIp);

                int port = int.Parse(this.getNewPort);

                if (clientOrServer)
                {
                    socket = BoomPlaneSocket.getSocket(clientOrServer, ip, port);
                    socket.connectToServer();
                    whoseTurn = false;
                }
                else
                {
                    socket = BoomPlaneSocket.getSocket(clientOrServer, ip, port);
                    socket.ListenClientConnect();
                    whoseTurn = true;
                }

                this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                label1.Text = label1Text + directions[nowDir];

                BeginNewHumanModeGame();
            }
            catch (ArgumentNullException)
            {


            }
        }

        private void SocketPanelbutton2_Click(object sender, EventArgs e)
        {
            this.SocketPanel.Visible = false;
            this.SocketSubPanel.Visible = false;
            this.TopPanel.Visible = true;
        }

        private void paintLoaclPlane()
        {
            if (movePlaneForm != null) movePlaneForm.Close();
            movePlaneForm = new MovePlane();
            movePlaneForm.TransparencyKey = Color.Red;
            movePlaneForm.BackColor = Color.Red;            
            movePlaneForm.TopMost = true;
            movePlaneForm.Show();
            movePlaneForm.Invalidate();
        }

        public void changeLable1Msg(String str)
        {
            if(str == null)
            {
                label1.Text = label1Text + directions[nowDir];
            }
            else
            {
                label1.Text = str;  
            }
            if (!form1.isForm1Active())
            {
                form1.Activate();
            }
        }

        public void changeLable4Msg(String str)
        {
            label4.Text = str;
            if (!form1.isForm1Active())
            {
                form1.Activate();
            }
        }

        private void Form1_LocationChanged(object sender, EventArgs e)
        {                   
            if(movePlaneForm != null)
            {
                movePlaneForm.reSetLocation(this.Location.X + 8, this.Location.Y + 30); 
            }

        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (start)
            {
                if (state is AIModeState) return;
                if(movePlaneForm.WindowState == FormWindowState.Minimized)
                {
                    movePlaneForm.WindowState = FormWindowState.Normal;
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           // System.Environment.Exit(0);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if(state is HumanModeState && aNewGameStart)
            {
                isEnemyReadyForGame = false;
                reBeginNewHumanModeGame();
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if(state != null)
            {
                Graphics g = Graphics.FromImage(bitmap);
                Plane[] predictPlane = state.GetLocalPlayer().GetAiAssistant().GetPredictPlanes();
                foreach(Plane plane in predictPlane)
                {                    
                    plane.Draw(g);
                }
                state.DrawPoint(state.GetLocalPlayer(), state.GetAdversaryPlayer(), g);
                panel3.CreateGraphics().DrawImage(bitmap, 0, 0);
                
                AttackPoint atk = state.GetLocalPlayer().GetAiAssistantPlayer().NextAttack();
                label4.Text = "AI建议落子 (" + atk.x + " , " + atk.y+ ")";
            }
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            if(state != null)
            {
                panel3.Invalidate();
            }            
        }

        public void setLocalPlane()
        {
            state.DrawPlane(panel2.CreateGraphics());
            if (!isForm1Active())
            {
                this.Activate();
            }

        }

        internal bool isForm1Active()
        {
            return (GetActiveWindow() == this.Handle);
        }

    }
}
