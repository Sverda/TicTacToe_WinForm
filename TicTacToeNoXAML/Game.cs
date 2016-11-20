using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeNoXAML
{
    class Game
    {
        private bool whosturn;//false-first player, true-second player
        public bool Whosturn { get { return whosturn; } }
        private bool?[,] fields;
        public bool?[,] Fields { get { return fields; } }

        public Game()
        {
            whosturn = false;
            fields = new bool?[3, 3];
            ResetGame();
        }

        public void ResetGame()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    fields[i, j] = null;
                }
            }
        }

        public void PlayerDidTurn(int x, int y)
        {
            fields[x, y] = whosturn;
            if (checkWinsConditions())
                OnGameOver();
            if (whosturn)
                whosturn = false;
            else
                whosturn = true;
        }

        private bool checkWinsConditions()
        {
            int countMatches = 0;//if player's mark has three matches than count is equal 3
            for (int column = 0; column < 3; column++)//vertical matches
            {
                for (int row = 0; row < 3; row++)
                {
                    if (fields[column, row] == whosturn)
                        countMatches++;
                }
            }
            if (countMatches == 3)
                return true;
            countMatches = 0;
            for (int row = 0; row < 3; row++)//horizontal matches
            {
                for (int column = 0; column < 3; column++)
                {
                    if (fields[column, row] == whosturn)
                        countMatches++;
                }
            }
            if (countMatches == 3)
                return true;
            countMatches = 0;
            if (((fields[0, 0] == whosturn) &&
                    (fields[1, 1] == whosturn) &&
                        (fields[2, 2] == whosturn)) ||
                ((fields[0, 2] == whosturn) &&
                    (fields[1, 1] == whosturn) &&
                        (fields[2, 0] == whosturn)))//cross matches
                return true;
            return false;
        }

        public event EventHandler GameOver;
        private void OnGameOver()
        {
            EventHandler gameOver = GameOver;
            if (gameOver != null)
                gameOver(this, new GameOverEventArgs(whosturn));
        }
    }
}
