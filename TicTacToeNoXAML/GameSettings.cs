using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeNoXAML
{
    class GameSettings//needless
    {
        public GameSettings(string firstName, string secondName, bool versus)
        {
            Name1 = firstName;
            Name2 = secondName;
            this.Versus = versus;
        }
        public readonly string Name1;//1st player's name
        public readonly string Name2;//2nd player's name
        public readonly bool Versus;//player vs player - true, player vs computer - false;
    }
}
