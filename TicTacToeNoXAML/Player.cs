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
        private bool mark;  //determinate whether player has "X"(false) mark or "O"(true)
        public bool Mark { get { return mark; } }
    }
}
