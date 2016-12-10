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
        //TODO: Add menu bar
        public Form1()
        {
            InitializeComponent();
            string exePath = getCurrentProjectDirectory();
            emptyFieldFile = exePath + "Fields\\emptyField.jpg";    // TODO: Exception for wrong files' paths. And give users option to change pictures
            OFieldFile = exePath + "Fields\\OField.jpg";
            XFieldFile = exePath + "Fields\\XField.jpg";
            
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
        private string emptyFieldFile;
        private string OFieldFile;
        private string XFieldFile;

        private void Game_GameOver(object sender, EventArgs e)
        {
            GameOverEventArgs tempE = e as GameOverEventArgs;
            if (tempE.winner == false)
                MessageBox.Show("Winner is " + game.GetPlayer1Name);
            else
                MessageBox.Show("Winner is " + game.GetPlayer2Name);
            updateControls(false);
        }

        private void updateControls(bool enabled)//switch on or off fields, buttons, textboxs, radioButtons, checkBox
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

        private void updateLabel()
        {
            if (!game.Whosturn)
                whosTurnLabel.Text = game.GetPlayer1Name + " turn - X ";
            else
                whosTurnLabel.Text = game.GetPlayer2Name + " turn - O ";
        }

        private void field0x0_Click(object sender, EventArgs e)//pictureBoxs has to be 'binding' with fields in Game class
        {
            if (!game.Whosturn)
                field0x0.Image = Image.FromFile(XFieldFile);
            else
                field0x0.Image = Image.FromFile(OFieldFile);
            game.PlayerDidTurn(0, 0);
            updateLabel();
        }

        private void field0x1_Click(object sender, EventArgs e)
        {
            if (!game.Whosturn)
                field0x1.Image = Image.FromFile(XFieldFile);
            else
                field0x1.Image = Image.FromFile(OFieldFile);
            game.PlayerDidTurn(0, 1);
            updateLabel();
        }

        private void field0x2_Click(object sender, EventArgs e)
        {
            if (!game.Whosturn)
                field0x2.Image = Image.FromFile(XFieldFile);
            else
                field0x2.Image = Image.FromFile(OFieldFile);
            game.PlayerDidTurn(0, 2);
            updateLabel();
        }

        private void field1x0_Click(object sender, EventArgs e)
        {
            if (!game.Whosturn)
                field1x0.Image = Image.FromFile(XFieldFile);
            else
                field1x0.Image = Image.FromFile(OFieldFile);
            game.PlayerDidTurn(1, 0);
            updateLabel();
        }

        private void field1x1_Click(object sender, EventArgs e)
        {
            if (!game.Whosturn)
                field1x1.Image = Image.FromFile(XFieldFile);
            else
                field1x1.Image = Image.FromFile(OFieldFile);
            game.PlayerDidTurn(1, 1);
            updateLabel();
        }

        private void field1x2_Click(object sender, EventArgs e)
        {
            if (!game.Whosturn)
                field1x2.Image = Image.FromFile(XFieldFile);
            else
                field1x2.Image = Image.FromFile(OFieldFile);
            game.PlayerDidTurn(1, 2);
            updateLabel();
        }

        private void field2x0_Click(object sender, EventArgs e)
        {
            if (!game.Whosturn)
                field2x0.Image = Image.FromFile(XFieldFile);
            else
                field2x0.Image = Image.FromFile(OFieldFile);
            game.PlayerDidTurn(2, 0);
            updateLabel();
        }

        private void field2x1_Click(object sender, EventArgs e)
        {
            if (!game.Whosturn)
                field2x1.Image = Image.FromFile(XFieldFile);
            else
                field2x1.Image = Image.FromFile(OFieldFile);
            game.PlayerDidTurn(2, 1);
            updateLabel();
        }

        private void field2x2_Click(object sender, EventArgs e)
        {
            if (!game.Whosturn)
                field2x2.Image = Image.FromFile(XFieldFile);
            else
                field2x2.Image = Image.FromFile(OFieldFile);
            game.PlayerDidTurn(2, 2);
            updateLabel();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            game = new Game(playerOneName.Text, playerTwoName.Text, chooseVsComputer.Checked);
            game.GameOver -= Game_GameOver;//don't duplicate event handler
            game.GameOver += Game_GameOver;
            updateControls(true);
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
