namespace _2D_SpaceShooterGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            MoveBgTimer = new System.Windows.Forms.Timer(components);
            LeftMoveTimer = new System.Windows.Forms.Timer(components);
            RightMoveTimer = new System.Windows.Forms.Timer(components);
            UpMoveTimer = new System.Windows.Forms.Timer(components);
            DownMoveTimer = new System.Windows.Forms.Timer(components);
            MoveMunitionsTimer = new System.Windows.Forms.Timer(components);
            MoveEnemyTimer = new System.Windows.Forms.Timer(components);
            EnemyMunitionTimer = new System.Windows.Forms.Timer(components);
            ScoreLabel = new Label();
            pictureBox1 = new PictureBox();
            playerHealthLabel = new Label();
            GameTimeLabel = new Label();
            GameTime = new System.Windows.Forms.Timer(components);
            PauseLabel = new Label();
            ResumeLabel = new Label();
            QuitLabel = new Label();
            EndGamePanel = new Panel();
            ScoreInfoFinal = new Label();
            label3 = new Label();
            SubmitButton = new Label();
            timeFinal = new Label();
            label4 = new Label();
            scoreFinal = new Label();
            label2 = new Label();
            NameInput = new TextBox();
            label1 = new Label();
            scoreInfo = new Label();
            LevelLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            EndGamePanel.SuspendLayout();
            SuspendLayout();
            // 
            // MoveBgTimer
            // 
            MoveBgTimer.Enabled = true;
            MoveBgTimer.Interval = 10;
            MoveBgTimer.Tick += MoveBgTimer_Tick;
            // 
            // LeftMoveTimer
            // 
            LeftMoveTimer.Interval = 5;
            LeftMoveTimer.Tick += LeftMoveTimer_Tick;
            // 
            // RightMoveTimer
            // 
            RightMoveTimer.Interval = 5;
            RightMoveTimer.Tick += RightMoveTimer_Tick;
            // 
            // UpMoveTimer
            // 
            UpMoveTimer.Interval = 5;
            UpMoveTimer.Tick += UpMoveTimer_Tick;
            // 
            // DownMoveTimer
            // 
            DownMoveTimer.Interval = 5;
            DownMoveTimer.Tick += DownMoveTimer_Tick;
            // 
            // MoveMunitionsTimer
            // 
            MoveMunitionsTimer.Enabled = true;
            MoveMunitionsTimer.Interval = 20;
            MoveMunitionsTimer.Tick += MoveMunitionsTimer_Tick;
            // 
            // MoveEnemyTimer
            // 
            MoveEnemyTimer.Enabled = true;
            MoveEnemyTimer.Tick += MoveEnemyTimer_Tick;
            // 
            // EnemyMunitionTimer
            // 
            EnemyMunitionTimer.Enabled = true;
            EnemyMunitionTimer.Interval = 20;
            EnemyMunitionTimer.Tick += EnemyMunitionTimer_Tick;
            // 
            // ScoreLabel
            // 
            ScoreLabel.AutoSize = true;
            ScoreLabel.BackColor = Color.Transparent;
            ScoreLabel.Font = new Font("Silkscreen Expanded", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ScoreLabel.ForeColor = Color.Transparent;
            ScoreLabel.Location = new Point(12, 25);
            ScoreLabel.Name = "ScoreLabel";
            ScoreLabel.Size = new Size(76, 14);
            ScoreLabel.TabIndex = 0;
            ScoreLabel.Text = "Score:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources.Item_3_1_png;
            pictureBox1.Location = new Point(762, 392);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(21, 18);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // playerHealthLabel
            // 
            playerHealthLabel.AutoSize = true;
            playerHealthLabel.Font = new Font("Silkscreen Expanded", 12F, FontStyle.Italic, GraphicsUnit.Point);
            playerHealthLabel.ForeColor = Color.White;
            playerHealthLabel.Location = new Point(741, 393);
            playerHealthLabel.Name = "playerHealthLabel";
            playerHealthLabel.Size = new Size(20, 14);
            playerHealthLabel.TabIndex = 2;
            playerHealthLabel.Text = "0";
            // 
            // GameTimeLabel
            // 
            GameTimeLabel.AutoSize = true;
            GameTimeLabel.Font = new Font("Silkscreen Expanded", 12F, FontStyle.Bold, GraphicsUnit.Point);
            GameTimeLabel.ForeColor = Color.White;
            GameTimeLabel.Location = new Point(670, 25);
            GameTimeLabel.Name = "GameTimeLabel";
            GameTimeLabel.Size = new Size(113, 14);
            GameTimeLabel.TabIndex = 3;
            GameTimeLabel.Text = "00:00:00";
            // 
            // GameTime
            // 
            GameTime.Enabled = true;
            GameTime.Interval = 1000;
            GameTime.Tick += GameTime_Tick;
            // 
            // PauseLabel
            // 
            PauseLabel.AutoSize = true;
            PauseLabel.BackColor = Color.Transparent;
            PauseLabel.Font = new Font("Silkscreen Expanded", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            PauseLabel.ForeColor = Color.White;
            PauseLabel.Location = new Point(212, 154);
            PauseLabel.Name = "PauseLabel";
            PauseLabel.Size = new Size(383, 57);
            PauseLabel.TabIndex = 4;
            PauseLabel.Text = "Paused";
            PauseLabel.Visible = false;
            // 
            // ResumeLabel
            // 
            ResumeLabel.AutoSize = true;
            ResumeLabel.BackColor = Color.Transparent;
            ResumeLabel.Cursor = Cursors.Hand;
            ResumeLabel.Font = new Font("Silkscreen", 24F, FontStyle.Bold, GraphicsUnit.Point);
            ResumeLabel.ForeColor = Color.White;
            ResumeLabel.Location = new Point(121, 341);
            ResumeLabel.Name = "ResumeLabel";
            ResumeLabel.Size = new Size(169, 28);
            ResumeLabel.TabIndex = 5;
            ResumeLabel.Text = "Resume";
            ResumeLabel.Visible = false;
            ResumeLabel.Click += ResumeLabel_Click;
            ResumeLabel.MouseEnter += label1_MouseEnter;
            ResumeLabel.MouseLeave += ResumeLabel_MouseLeave;
            // 
            // QuitLabel
            // 
            QuitLabel.AutoSize = true;
            QuitLabel.BackColor = Color.Transparent;
            QuitLabel.Cursor = Cursors.Hand;
            QuitLabel.Font = new Font("Silkscreen", 24F, FontStyle.Bold, GraphicsUnit.Point);
            QuitLabel.ForeColor = Color.White;
            QuitLabel.Location = new Point(560, 341);
            QuitLabel.Name = "QuitLabel";
            QuitLabel.Size = new Size(103, 28);
            QuitLabel.TabIndex = 6;
            QuitLabel.Text = "Exit";
            QuitLabel.Visible = false;
            QuitLabel.Click += QuitLabel_Click;
            QuitLabel.MouseEnter += QuitLabel_MouseEnter;
            QuitLabel.MouseLeave += QuitLabel_MouseLeave;
            // 
            // EndGamePanel
            // 
            EndGamePanel.BackColor = Color.Transparent;
            EndGamePanel.Controls.Add(ScoreInfoFinal);
            EndGamePanel.Controls.Add(label3);
            EndGamePanel.Controls.Add(SubmitButton);
            EndGamePanel.Controls.Add(timeFinal);
            EndGamePanel.Controls.Add(label4);
            EndGamePanel.Controls.Add(scoreFinal);
            EndGamePanel.Controls.Add(label2);
            EndGamePanel.Controls.Add(NameInput);
            EndGamePanel.Controls.Add(label1);
            EndGamePanel.Location = new Point(58, 42);
            EndGamePanel.Name = "EndGamePanel";
            EndGamePanel.Size = new Size(677, 496);
            EndGamePanel.TabIndex = 7;
            EndGamePanel.Visible = false;
            // 
            // ScoreInfoFinal
            // 
            ScoreInfoFinal.AutoSize = true;
            ScoreInfoFinal.BackColor = Color.Transparent;
            ScoreInfoFinal.Font = new Font("Silkscreen Expanded", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ScoreInfoFinal.ForeColor = Color.Transparent;
            ScoreInfoFinal.Location = new Point(156, 309);
            ScoreInfoFinal.Name = "ScoreInfoFinal";
            ScoreInfoFinal.Size = new Size(20, 14);
            ScoreInfoFinal.TabIndex = 13;
            ScoreInfoFinal.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Silkscreen", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(154, 45);
            label3.Name = "label3";
            label3.Size = new Size(368, 43);
            label3.TabIndex = 12;
            label3.Text = "GAME OVER";
            // 
            // SubmitButton
            // 
            SubmitButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SubmitButton.AutoSize = true;
            SubmitButton.Font = new Font("Silkscreen Expanded", 24F, FontStyle.Italic, GraphicsUnit.Point);
            SubmitButton.ForeColor = Color.White;
            SubmitButton.Location = new Point(258, 440);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(161, 28);
            SubmitButton.TabIndex = 11;
            SubmitButton.Text = "Submit";
            SubmitButton.Click += SubmitButton_Click;
            SubmitButton.MouseEnter += SubmitButton_MouseEnter;
            SubmitButton.MouseLeave += SubmitButton_MouseLeave;
            // 
            // timeFinal
            // 
            timeFinal.AutoSize = true;
            timeFinal.Font = new Font("Silkscreen Expanded", 12F, FontStyle.Bold, GraphicsUnit.Point);
            timeFinal.ForeColor = Color.White;
            timeFinal.Location = new Point(156, 350);
            timeFinal.Name = "timeFinal";
            timeFinal.Size = new Size(113, 14);
            timeFinal.TabIndex = 10;
            timeFinal.Text = "00:00:00";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Silkscreen Expanded", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(65, 350);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(78, 14);
            label4.TabIndex = 9;
            label4.Text = "Time : ";
            label4.TextAlign = ContentAlignment.TopRight;
            // 
            // scoreFinal
            // 
            scoreFinal.AutoSize = true;
            scoreFinal.BackColor = Color.Transparent;
            scoreFinal.Font = new Font("Silkscreen Expanded", 12F, FontStyle.Regular, GraphicsUnit.Point);
            scoreFinal.ForeColor = Color.Transparent;
            scoreFinal.Location = new Point(65, 309);
            scoreFinal.Name = "scoreFinal";
            scoreFinal.Size = new Size(86, 14);
            scoreFinal.TabIndex = 8;
            scoreFinal.Text = "Score :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Silkscreen Expanded", 24F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(50, 246);
            label2.Name = "label2";
            label2.Size = new Size(280, 28);
            label2.TabIndex = 2;
            label2.Text = "Final Score";
            // 
            // NameInput
            // 
            NameInput.BackColor = SystemColors.ActiveBorder;
            NameInput.BorderStyle = BorderStyle.FixedSingle;
            NameInput.Cursor = Cursors.IBeam;
            NameInput.Font = new Font("Silkscreen", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            NameInput.ForeColor = Color.White;
            NameInput.Location = new Point(371, 159);
            NameInput.Margin = new Padding(5);
            NameInput.Name = "NameInput";
            NameInput.PlaceholderText = "Enter name here";
            NameInput.Size = new Size(236, 26);
            NameInput.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Silkscreen Expanded", 24F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(50, 157);
            label1.Name = "label1";
            label1.Size = new Size(316, 28);
            label1.TabIndex = 0;
            label1.Text = "Enter Name : ";
            // 
            // scoreInfo
            // 
            scoreInfo.AutoSize = true;
            scoreInfo.BackColor = Color.Transparent;
            scoreInfo.Font = new Font("Silkscreen Expanded", 12F, FontStyle.Regular, GraphicsUnit.Point);
            scoreInfo.ForeColor = Color.Transparent;
            scoreInfo.Location = new Point(94, 25);
            scoreInfo.Name = "scoreInfo";
            scoreInfo.Size = new Size(20, 14);
            scoreInfo.TabIndex = 14;
            scoreInfo.Text = "0";
            // 
            // LevelLabel
            // 
            LevelLabel.AutoSize = true;
            LevelLabel.BackColor = Color.Transparent;
            LevelLabel.Font = new Font("Silkscreen Expanded", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LevelLabel.ForeColor = Color.Transparent;
            LevelLabel.Location = new Point(547, 25);
            LevelLabel.Name = "LevelLabel";
            LevelLabel.Size = new Size(95, 14);
            LevelLabel.TabIndex = 15;
            LevelLabel.Text = "Level: 0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 2, 36);
            ClientSize = new Size(784, 561);
            Controls.Add(LevelLabel);
            Controls.Add(scoreInfo);
            Controls.Add(EndGamePanel);
            Controls.Add(QuitLabel);
            Controls.Add(ResumeLabel);
            Controls.Add(PauseLabel);
            Controls.Add(GameTimeLabel);
            Controls.Add(playerHealthLabel);
            Controls.Add(pictureBox1);
            Controls.Add(ScoreLabel);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            EndGamePanel.ResumeLayout(false);
            EndGamePanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer MoveBgTimer;
        private System.Windows.Forms.Timer LeftMoveTimer;
        private System.Windows.Forms.Timer RightMoveTimer;
        private System.Windows.Forms.Timer UpMoveTimer;
        private System.Windows.Forms.Timer DownMoveTimer;
        private System.Windows.Forms.Timer MoveMunitionsTimer;
        private System.Windows.Forms.Timer MoveEnemyTimer;
        private System.Windows.Forms.Timer EnemyMunitionTimer;
        private Label ScoreLabel;
        private PictureBox pictureBox1;
        private Label playerHealthLabel;
        private Label GameTimeLabel;
        private System.Windows.Forms.Timer GameTime;
        private Label PauseLabel;
        private Label ResumeLabel;
        private Label QuitLabel;
        private Panel EndGamePanel;
        private TextBox NameInput;
        private Label label1;
        private Label label2;
        private Label scoreFinal;
        private Label label4;
        private Label SubmitButton;
        private Label timeFinal;
        private Label label3;
        private Label ScoreInfoFinal;
        private Label scoreInfo;
        private Label LevelLabel;
    }
}