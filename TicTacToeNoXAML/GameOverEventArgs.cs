using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeNoXAML
{
    public class GameOverEventArgs :EventArgs
    {
        public GameOverEventArgs(bool? winner)
        {
            this.winner = winner;
        }
        public bool? winner;
    }
}
