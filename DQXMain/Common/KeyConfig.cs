using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DQXMain.Common
{
    public class KeyConfig
    {

        /**
         * 确认键
         */
        public Keys OK = Keys.Enter;

        /**
         * 菜单键
         */
        public Keys Menu = Keys.V;

        /**
         * 向前
         */
        public Keys Move = Keys.W;

        /**
         * 向后
         */
        public Keys Back = Keys.S;

        /**
         * 向左
         */
        public Keys Left = Keys.A;

        /**
         * 向右
         */
        public Keys Right = Keys.A;

        /**
         * 逆时针转
         */
        public Keys TurnLeft = Keys.Q;

        /**
         * 顺时针转
         */
        public Keys TurnRight = Keys.E;

        /**
         * 自动奔跑
         */
        public Keys AutoRun = Keys.R;
    }
}
