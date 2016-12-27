using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeNoXAML
{
    public partial class Form1 : Form
    {
        // TODO: Add menu bar
        public Form1()
        {
            InitializeComponent();
            string exePath = getCurrentProjectDirectory();
            formField = new PictureBox[3, 3];
            formField[0, 0] = field0x0;
            formField[0, 1] = field0x1;
            formField[0, 2] = field0x2;
            formField[1, 0] = field1x0;
            formField[1, 1] = field1x1;
            formField[1, 2] = field1x2;
            formField[2, 0] = field2x0;
            formField[2, 1] = field2x1;
            formField[2, 2] = field2x2;
            // TODO: Exception for wrong files' paths. And give users option to change pictures
            emptyFieldFile = exePath + "Fields\\emptyField.jpg";
            OFieldFile = exePath + "Fields\\OField.jpg";
            XFieldFile = exePath + "Fields\\XField.jpg";
            
        }

        private void Game_UpdateForm(object sender, EventArgs e)
        {
            MoveEventArgs e_move = e as MoveEventArgs;
            if (!e_move.Who)
                formField[e_move.X, e_move.Y].Image = Image.FromFile(XFieldFile);
            else
                formField[e_move.X, e_move.Y].Image = Image.FromFile(OFieldFile);
        }

        private void clearFormFields()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    formField[i, j].Image = Image.FromFile(emptyFieldFile);
                }
            }
        }

        //"C:\\Users\\Damian\\Dropbox\\Projects\\TicTacToe\\TicTacToeNoXAML\\bin\\Debug"
        private string getCurrentProjectDirectory()
        {
            string exePath = Environment.CurrentDirectory;
            const string removeString = "bin\\Debug";
            int index = exePath.IndexOf(removeString);
            return exePath.Substring(0, index);
        }

        private Game game;
        private PictureBox[,] formField;
        private string emptyFieldFile;
        private string OFieldFile;
        private string XFieldFile;

        private void Game_GameOver(object sender, EventArgs e)
        {
            GameOverEventArgs tempE = e as GameOverEventArgs;
            if (tempE.winner == false)
                MessageBox.Show("Winner is " + game.GetPlayer1Name);
            else if (tempE.winner == true)
                MessageBox.Show("Winner is " + game.GetPlayer2Name);
            else
                MessageBox.Show("Draw");
            updateControls(false);
        }

        private void updateControls(bool enabled)//switch on or off the controls
        {
            field0x0.Enabled = enabled;
            field0x1.Enabled = enabled;
            field0x2.Enabled = enabled;
            field1x0.Enabled = enabled;
            field1x1.Enabled = enabled;
            field1x2.Enabled = enabled;
            field2x0.Enabled = enabled;
            field2x1.Enabled = enabled;
            field2x2.Enabled = enabled;
            playerOneName.Enabled = !enabled;
            playerTwoName.Enabled = !enabled;
            playButton.Enabled = !enabled;
            chooseVsPlayer.Enabled = !enabled;
            chooseVsComputer.Enabled = !enabled;
        }

        private void updateStringLabel()
        {
            if (!game.Whosturn)
                whosTurnLabel.Text = game.GetPlayer1Name + " turn - X ";
            else
                whosTurnLabel.Text = game.GetPlayer2Name + " turn - O ";
        }

        private void field0x0_Click(object sender, EventArgs e) //pictureBoxs has to be 'binding' with fields in Game class
        {
            game.PlayerDidTurn(0, 0);
            updateStringLabel();
        }

        private void field0x1_Click(object sender, EventArgs e)
        {
            game.PlayerDidTurn(0, 1);
            updateStringLabel();
        }

        private void field0x2_Click(object sender, EventArgs e)
        {
            game.PlayerDidTurn(0, 2);
            updateStringLabel();
        }

        private void field1x0_Click(object sender, EventArgs e)
        {
            game.PlayerDidTurn(1, 0);
            updateStringLabel();
        }

        private void field1x1_Click(object sender, EventArgs e)
        {
            game.PlayerDidTurn(1, 1);
            updateStringLabel();
        }

        private void field1x2_Click(object sender, EventArgs e)
        {
            game.PlayerDidTurn(1, 2);
            updateStringLabel();
        }

        private void field2x0_Click(object sender, EventArgs e)
        {
            game.PlayerDidTurn(2, 0);
            updateStringLabel();
        }

        private void field2x1_Click(object sender, EventArgs e)
        {
            game.PlayerDidTurn(2, 1);
            updateStringLabel();
        }

        private void field2x2_Click(object sender, EventArgs e)
        {
            game.PlayerDidTurn(2, 2);
            updateStringLabel();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            game = new Game(playerOneName.Text, playerTwoName.Text, chooseVsComputer.Checked);
            game.GameOver -= Game_GameOver; //don't duplicate event handler
            game.GameOver += Game_GameOver;
            game.UpdateForm -= Game_UpdateForm;
            game.UpdateForm += Game_UpdateForm;
            updateControls(true);
            clearFormFields();
        }

        private void chooseVsComputer_CheckedChanged(object sender, EventArgs e)
        {
            if (chooseVsComputer.Checked)
                hardModeOption.Enabled = true;
            else
                hardModeOption.Enabled = false;
        }
    }
}
