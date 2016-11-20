using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Game
    {
        private bool whosturn;//false-first player, true-second player
        public bool Whosturn { get; }
        private bool?[,] fields;
        public bool?[,] Fields { get { return fields; } }

        public Game()
        {
            whosturn = false;
            fields = new bool?[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    fields[i, j] = null;
                }
            }
        }

        public bool PlayerDidTurn(int x, int y)
        {
            fields[x, y] = whosturn;
            bool win = checkWinsConditions();
            whosturn = !whosturn;
            return win;
        }

        private bool checkWinsConditions()
        {
            bool condition = true;//if conditions are fullfiled is equal true
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (fields[i, j] != whosturn)
                        condition = false;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (fields[j, i] != whosturn)
                        condition = false;
                }
            }
            if (((fields[0, 0] != whosturn) &&
                    (fields[1, 1] != whosturn) &&
                        (fields[2, 2] != whosturn)) ||
                ((fields[0, 2] != whosturn) &&
                    (fields[1, 1] != whosturn) &&
                        (fields[2, 0] != whosturn)))
                condition = false;
            return condition;
        }
    }
}
