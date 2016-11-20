namespace TicTacToeNoXAML
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.whosTurnLabel = new System.Windows.Forms.Label();
            this.field0x0 = new System.Windows.Forms.PictureBox();
            this.field0x1 = new System.Windows.Forms.PictureBox();
            this.field0x2 = new System.Windows.Forms.PictureBox();
            this.field1x0 = new System.Windows.Forms.PictureBox();
            this.field1x1 = new System.Windows.Forms.PictureBox();
            this.field1x2 = new System.Windows.Forms.PictureBox();
            this.field2x0 = new System.Windows.Forms.PictureBox();
            this.field2x1 = new System.Windows.Forms.PictureBox();
            this.field2x2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.settingsBox = new System.Windows.Forms.GroupBox();
            this.playerOneName = new System.Windows.Forms.TextBox();
            this.playerTwoName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.playButton = new System.Windows.Forms.Button();
            this.vsGroupBox = new System.Windows.Forms.GroupBox();
            this.chooseVsPlayer = new System.Windows.Forms.RadioButton();
            this.chooseVsComputer = new System.Windows.Forms.RadioButton();
            this.hardModeOption = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.field0x0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field0x1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field0x2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field1x0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field1x1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field1x2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field2x0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field2x1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field2x2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.settingsBox.SuspendLayout();
            this.vsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // whosTurnLabel
            // 
            this.whosTurnLabel.AutoSize = true;
            this.whosTurnLabel.Location = new System.Drawing.Point(105, 31);
            this.whosTurnLabel.Name = "whosTurnLabel";
            this.whosTurnLabel.Size = new System.Drawing.Size(82, 13);
            this.whosTurnLabel.TabIndex = 0;
            this.whosTurnLabel.Text = "Player 1 turn - X";
            // 
            // field0x0
            // 
            this.field0x0.Enabled = false;
            this.field0x0.Image = ((System.Drawing.Image)(resources.GetObject("field0x0.Image")));
            this.field0x0.Location = new System.Drawing.Point(12, 67);
            this.field0x0.Name = "field0x0";
            this.field0x0.Size = new System.Drawing.Size(90, 90);
            this.field0x0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.field0x0.TabIndex = 1;
            this.field0x0.TabStop = false;
            this.field0x0.Click += new System.EventHandler(this.field0x0_Click);
            // 
            // field0x1
            // 
            this.field0x1.Enabled = false;
            this.field0x1.Image = ((System.Drawing.Image)(resources.GetObject("field0x1.Image")));
            this.field0x1.Location = new System.Drawing.Point(108, 67);
            this.field0x1.Name = "field0x1";
            this.field0x1.Size = new System.Drawing.Size(90, 90);
            this.field0x1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.field0x1.TabIndex = 2;
            this.field0x1.TabStop = false;
            this.field0x1.Click += new System.EventHandler(this.field0x1_Click);
            // 
            // field0x2
            // 
            this.field0x2.Enabled = false;
            this.field0x2.Image = ((System.Drawing.Image)(resources.GetObject("field0x2.Image")));
            this.field0x2.Location = new System.Drawing.Point(204, 67);
            this.field0x2.Name = "field0x2";
            this.field0x2.Size = new System.Drawing.Size(90, 90);
            this.field0x2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.field0x2.TabIndex = 3;
            this.field0x2.TabStop = false;
            this.field0x2.Click += new System.EventHandler(this.field0x2_Click);
            // 
            // field1x0
            // 
            this.field1x0.Enabled = false;
            this.field1x0.Image = ((System.Drawing.Image)(resources.GetObject("field1x0.Image")));
            this.field1x0.Location = new System.Drawing.Point(12, 163);
            this.field1x0.Name = "field1x0";
            this.field1x0.Size = new System.Drawing.Size(90, 90);
            this.field1x0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.field1x0.TabIndex = 4;
            this.field1x0.TabStop = false;
            this.field1x0.Click += new System.EventHandler(this.field1x0_Click);
            // 
            // field1x1
            // 
            this.field1x1.Enabled = false;
            this.field1x1.Image = ((System.Drawing.Image)(resources.GetObject("field1x1.Image")));
            this.field1x1.Location = new System.Drawing.Point(108, 163);
            this.field1x1.Name = "field1x1";
            this.field1x1.Size = new System.Drawing.Size(90, 90);
            this.field1x1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.field1x1.TabIndex = 5;
            this.field1x1.TabStop = false;
            this.field1x1.Click += new System.EventHandler(this.field1x1_Click);
            // 
            // field1x2
            // 
            this.field1x2.Enabled = false;
            this.field1x2.Image = ((System.Drawing.Image)(resources.GetObject("field1x2.Image")));
            this.field1x2.Location = new System.Drawing.Point(204, 163);
            this.field1x2.Name = "field1x2";
            this.field1x2.Size = new System.Drawing.Size(90, 90);
            this.field1x2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.field1x2.TabIndex = 6;
            this.field1x2.TabStop = false;
            this.field1x2.Click += new System.EventHandler(this.field1x2_Click);
            // 
            // field2x0
            // 
            this.field2x0.Enabled = false;
            this.field2x0.Image = ((System.Drawing.Image)(resources.GetObject("field2x0.Image")));
            this.field2x0.Location = new System.Drawing.Point(12, 259);
            this.field2x0.Name = "field2x0";
            this.field2x0.Size = new System.Drawing.Size(90, 90);
            this.field2x0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.field2x0.TabIndex = 7;
            this.field2x0.TabStop = false;
            this.field2x0.Click += new System.EventHandler(this.field2x0_Click);
            // 
            // field2x1
            // 
            this.field2x1.Enabled = false;
            this.field2x1.Image = ((System.Drawing.Image)(resources.GetObject("field2x1.Image")));
            this.field2x1.Location = new System.Drawing.Point(108, 259);
            this.field2x1.Name = "field2x1";
            this.field2x1.Size = new System.Drawing.Size(90, 90);
            this.field2x1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.field2x1.TabIndex = 8;
            this.field2x1.TabStop = false;
            this.field2x1.Click += new System.EventHandler(this.field2x1_Click);
            // 
            // field2x2
            // 
            this.field2x2.Enabled = false;
            this.field2x2.Image = ((System.Drawing.Image)(resources.GetObject("field2x2.Image")));
            this.field2x2.Location = new System.Drawing.Point(204, 259);
            this.field2x2.Name = "field2x2";
            this.field2x2.Size = new System.Drawing.Size(90, 90);
            this.field2x2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.field2x2.TabIndex = 9;
            this.field2x2.TabStop = false;
            this.field2x2.Click += new System.EventHandler(this.field2x2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 282);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // settingsBox
            // 
            this.settingsBox.Controls.Add(this.vsGroupBox);
            this.settingsBox.Controls.Add(this.playButton);
            this.settingsBox.Controls.Add(this.label2);
            this.settingsBox.Controls.Add(this.label1);
            this.settingsBox.Controls.Add(this.playerTwoName);
            this.settingsBox.Controls.Add(this.playerOneName);
            this.settingsBox.Location = new System.Drawing.Point(300, 67);
            this.settingsBox.Name = "settingsBox";
            this.settingsBox.Size = new System.Drawing.Size(153, 282);
            this.settingsBox.TabIndex = 11;
            this.settingsBox.TabStop = false;
            this.settingsBox.Text = "Settings";
            // 
            // playerOneName
            // 
            this.playerOneName.Location = new System.Drawing.Point(9, 32);
            this.playerOneName.Name = "playerOneName";
            this.playerOneName.Size = new System.Drawing.Size(138, 20);
            this.playerOneName.TabIndex = 0;
            this.playerOneName.Text = "Player1";
            // 
            // playerTwoName
            // 
            this.playerTwoName.Location = new System.Drawing.Point(9, 79);
            this.playerTwoName.Name = "playerTwoName";
            this.playerTwoName.Size = new System.Drawing.Size(138, 20);
            this.playerTwoName.TabIndex = 1;
            this.playerTwoName.Text = "Player2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "1st player\'s name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "2nd player\'s name: ";
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(9, 105);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(138, 23);
            this.playButton.TabIndex = 4;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // vsGroupBox
            // 
            this.vsGroupBox.Controls.Add(this.hardModeOption);
            this.vsGroupBox.Controls.Add(this.chooseVsComputer);
            this.vsGroupBox.Controls.Add(this.chooseVsPlayer);
            this.vsGroupBox.Location = new System.Drawing.Point(9, 150);
            this.vsGroupBox.Name = "vsGroupBox";
            this.vsGroupBox.Size = new System.Drawing.Size(138, 95);
            this.vsGroupBox.TabIndex = 5;
            this.vsGroupBox.TabStop = false;
            this.vsGroupBox.Text = "Play Versus";
            // 
            // chooseVsPlayer
            // 
            this.chooseVsPlayer.AutoSize = true;
            this.chooseVsPlayer.Checked = true;
            this.chooseVsPlayer.Location = new System.Drawing.Point(10, 19);
            this.chooseVsPlayer.Name = "chooseVsPlayer";
            this.chooseVsPlayer.Size = new System.Drawing.Size(54, 17);
            this.chooseVsPlayer.TabIndex = 0;
            this.chooseVsPlayer.TabStop = true;
            this.chooseVsPlayer.Text = "Player";
            this.chooseVsPlayer.UseVisualStyleBackColor = true;
            // 
            // chooseVsComputer
            // 
            this.chooseVsComputer.AutoSize = true;
            this.chooseVsComputer.Location = new System.Drawing.Point(10, 42);
            this.chooseVsComputer.Name = "chooseVsComputer";
            this.chooseVsComputer.Size = new System.Drawing.Size(70, 17);
            this.chooseVsComputer.TabIndex = 1;
            this.chooseVsComputer.Text = "Computer";
            this.chooseVsComputer.UseVisualStyleBackColor = true;
            this.chooseVsComputer.CheckedChanged += new System.EventHandler(this.chooseVsComputer_CheckedChanged);
            this.chooseVsComputer.EnabledChanged += new System.EventHandler(this.chooseVsComputer_CheckedChanged);
            // 
            // hardModeOption
            // 
            this.hardModeOption.AutoSize = true;
            this.hardModeOption.Enabled = false;
            this.hardModeOption.Location = new System.Drawing.Point(10, 65);
            this.hardModeOption.Name = "hardModeOption";
            this.hardModeOption.Size = new System.Drawing.Size(79, 17);
            this.hardModeOption.TabIndex = 2;
            this.hardModeOption.Text = "Hard Mode";
            this.hardModeOption.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 371);
            this.Controls.Add(this.settingsBox);
            this.Controls.Add(this.field2x2);
            this.Controls.Add(this.field2x1);
            this.Controls.Add(this.field2x0);
            this.Controls.Add(this.field1x2);
            this.Controls.Add(this.field1x1);
            this.Controls.Add(this.field1x0);
            this.Controls.Add(this.field0x2);
            this.Controls.Add(this.field0x1);
            this.Controls.Add(this.field0x0);
            this.Controls.Add(this.whosTurnLabel);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "TicTacToe";
            ((System.ComponentModel.ISupportInitialize)(this.field0x0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field0x1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field0x2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field1x0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field1x1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field1x2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field2x0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field2x1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field2x2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.settingsBox.ResumeLayout(false);
            this.settingsBox.PerformLayout();
            this.vsGroupBox.ResumeLayout(false);
            this.vsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label whosTurnLabel;
        private System.Windows.Forms.PictureBox field0x0;
        private System.Windows.Forms.PictureBox field0x1;
        private System.Windows.Forms.PictureBox field0x2;
        private System.Windows.Forms.PictureBox field1x0;
        private System.Windows.Forms.PictureBox field1x1;
        private System.Windows.Forms.PictureBox field1x2;
        private System.Windows.Forms.PictureBox field2x0;
        private System.Windows.Forms.PictureBox field2x1;
        private System.Windows.Forms.PictureBox field2x2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox settingsBox;
        private System.Windows.Forms.GroupBox vsGroupBox;
        private System.Windows.Forms.RadioButton chooseVsComputer;
        private System.Windows.Forms.RadioButton chooseVsPlayer;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox playerTwoName;
        private System.Windows.Forms.TextBox playerOneName;
        private System.Windows.Forms.CheckBox hardModeOption;
    }
}