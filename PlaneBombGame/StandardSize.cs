using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneBombGame
{
    internal class StandardSize
    {
        public static int HomeWidth { get { return 751; } }
        public static int HomeHeight { get { return 556; } }
        public static int FormWidth { get { return 1200; } }
        public static int FormHeight { get { return 600; } }

        // 地图大小
        public static int BoardWidth { get { return 600; } }
        public static int BoardHeight { get { return 600; } }

        // 格子宽度
        public static int BlockNum { get { return 10; } }
        public static int BlockWidth { get { return 40; } }


        public static int toLeft { get { return 40; } }
        public static int toTop { get { return 25; } }

    }
}
