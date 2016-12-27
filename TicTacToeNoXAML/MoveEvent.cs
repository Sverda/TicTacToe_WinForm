using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeNoXAML
{

    class MoveEventArgs : EventArgs
    {
        private int x;  //column
        private int y;  //row
        private bool who;   //which player did move
        public int X { get { return x; } }
        public int Y { get { return y; } }
        public bool Who { get { return who; } }
        public MoveEventArgs(int x, int y, bool who)
        {
            this.x = x;
            this.y = y;
            this.who = who;
        }
    }
}
