using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeNoXAML
{
    class AI :Player
    {
        public AI(string name, bool mark) : base(name, mark)
        {
            random = new Random();
        }
        private Random random;

        public void DoMove(bool?[,] fields, out int x, out int y)
        {
            int count;  //check whether is space to do move by AI
            do
            {
                count = 0;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (fields[i, j] == null) 
                        {
                            count++;
                        }
                    }
                }
                if (count == 0)
                {
                    x = -1;
                    y = -1;
                    return;
                }
                x = random.Next(3);
                y = random.Next(3);
            } while (fields[x, y] != null);
        }
    }
}
