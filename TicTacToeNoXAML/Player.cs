using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeNoXAML
{
    class Player
    {
        public Player(string playerName, bool mark)
        {
            this.name = playerName;
            this.mark = mark;
        }

        private string name;
        public string Name { get { return name; } }
        private bool mark;//determinate whether player has "X"(false) mark or "O"(true)
        public bool Mark { get { return mark; } }

        public event EventHandler PlayerMove;//inform form about new move
        public void OnMove(int x, int y)//Should I add delegate only to Game class and make OnMove private?
        {
            EventHandler playerMove = PlayerMove;
            if (playerMove != null)
            {
                playerMove(this, new MoveEventArgs(x, y));
            }
        }
    }

    class MoveEventArgs : EventArgs
    {
        private int x;//column
        private int y;//row
        public int X { get { return x; } }
        public int Y { get { return y; } }
        public MoveEventArgs(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
