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
        private Player player1;
        private Player player2;
        private bool whosturn;
        public bool Whosturn { get { return whosturn; } }
        private bool?[,] fields;
        public bool?[,] Fields { get { return fields; } }
        //methods to create AI or player object

        public Game(string player1name, string player2name, bool vsPlayer)
        {
            if (player1name != player2name)//players' name have to be diffrent. 
            {
                player1 = new Player(player1name, true);
            }
            else
            {
                player1 = new Player(player1name + "2", true);
            }
            whosturn = player1.Mark;
            if (vsPlayer)
            {
                player2 = new Player(player2name, false);
            }
            else
            {
                player2 = new AI(player2name, false);
            }
            fields = new bool?[3, 3];
            SetBlanks();
        }
        public string GetPlayer1Name { get { return player1.Name; } }
        public string GetPlayer2Name { get { return player2.Name; } }

        private void SetBlanks()
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
                gameOver(this, new GameOverEventArgs(whosturn));//adapt to new Player event
        }
    }
}
