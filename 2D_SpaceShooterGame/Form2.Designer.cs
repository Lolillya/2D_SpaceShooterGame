namespace _2D_SpaceShooterGame
{
    partial class Form2
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
            MenuContainer = new Panel();
            LeaderboardsButton = new Label();
            menuQuitBtn = new PictureBox();
            menuPlayBtn = new PictureBox();
            leaderboardsPanel = new Panel();
            dataGridView1 = new DataGridView();
            ReturnToMenu = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            MenuContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menuQuitBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)menuPlayBtn).BeginInit();
            leaderboardsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // MenuContainer
            // 
            MenuContainer.BackColor = Color.Transparent;
            MenuContainer.Controls.Add(LeaderboardsButton);
            MenuContainer.Controls.Add(menuQuitBtn);
            MenuContainer.Controls.Add(menuPlayBtn);
            MenuContainer.Location = new Point(236, 98);
            MenuContainer.Name = "MenuContainer";
            MenuContainer.Size = new Size(334, 366);
            MenuContainer.TabIndex = 0;
            MenuContainer.Paint += MenuContainer_Paint;
            // 
            // LeaderboardsButton
            // 
            LeaderboardsButton.AutoSize = true;
            LeaderboardsButton.Font = new Font("Silkscreen", 24F, FontStyle.Bold, GraphicsUnit.Point);
            LeaderboardsButton.ForeColor = Color.White;
            LeaderboardsButton.Location = new Point(7, 325);
            LeaderboardsButton.Name = "LeaderboardsButton";
            LeaderboardsButton.Size = new Size(324, 28);
            LeaderboardsButton.TabIndex = 3;
            LeaderboardsButton.Text = "Leaderboards";
            LeaderboardsButton.Click += LeaderboardsButton_Click;
            LeaderboardsButton.MouseEnter += LeaderboardsButton_MouseEnter;
            LeaderboardsButton.MouseLeave += LeaderboardsButton_MouseLeave;
            // 
            // menuQuitBtn
            // 
            menuQuitBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            menuQuitBtn.Cursor = Cursors.Hand;
            menuQuitBtn.Image = Properties.Resources.Quit_normal;
            menuQuitBtn.Location = new Point(60, 141);
            menuQuitBtn.Name = "menuQuitBtn";
            menuQuitBtn.Size = new Size(222, 81);
            menuQuitBtn.SizeMode = PictureBoxSizeMode.CenterImage;
            menuQuitBtn.TabIndex = 1;
            menuQuitBtn.TabStop = false;
            menuQuitBtn.Click += menuQuitBtn_Click;
            menuQuitBtn.MouseEnter += QuitBtn_onMouseEnter;
            menuQuitBtn.MouseLeave += QuitBtn_onMouseLeave;
            // 
            // menuPlayBtn
            // 
            menuPlayBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            menuPlayBtn.Cursor = Cursors.Hand;
            menuPlayBtn.Image = Properties.Resources.Play_normal;
            menuPlayBtn.Location = new Point(60, 61);
            menuPlayBtn.Name = "menuPlayBtn";
            menuPlayBtn.Size = new Size(222, 81);
            menuPlayBtn.SizeMode = PictureBoxSizeMode.CenterImage;
            menuPlayBtn.TabIndex = 0;
            menuPlayBtn.TabStop = false;
            menuPlayBtn.Click += menuPlayBtn_Click;
            menuPlayBtn.MouseEnter += playBtn_onMouseEnter;
            menuPlayBtn.MouseLeave += playBtn_onMouseLeave;
            // 
            // leaderboardsPanel
            // 
            leaderboardsPanel.BackgroundImage = Properties.Resources._360_F_264279006_WDXxV3OHjAOoHqH7iiLDrg23p0947g7U;
            leaderboardsPanel.Controls.Add(dataGridView1);
            leaderboardsPanel.Controls.Add(ReturnToMenu);
            leaderboardsPanel.Controls.Add(tableLayoutPanel1);
            leaderboardsPanel.Controls.Add(label1);
            leaderboardsPanel.Dock = DockStyle.Fill;
            leaderboardsPanel.Location = new Point(0, 0);
            leaderboardsPanel.Name = "leaderboardsPanel";
            leaderboardsPanel.Size = new Size(784, 561);
            leaderboardsPanel.TabIndex = 1;
            leaderboardsPanel.Visible = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.Black;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 170);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(784, 150);
            dataGridView1.TabIndex = 3;
            // 
            // ReturnToMenu
            // 
            ReturnToMenu.Anchor = AnchorStyles.None;
            ReturnToMenu.AutoSize = true;
            ReturnToMenu.BackColor = Color.Transparent;
            ReturnToMenu.Font = new Font("Silkscreen Expanded", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            ReturnToMenu.ForeColor = Color.White;
            ReturnToMenu.Location = new Point(317, 477);
            ReturnToMenu.Name = "ReturnToMenu";
            ReturnToMenu.Size = new Size(194, 32);
            ReturnToMenu.TabIndex = 2;
            ReturnToMenu.Text = "Return";
            ReturnToMenu.TextAlign = ContentAlignment.MiddleCenter;
            ReturnToMenu.Click += ReturnToMenu_Click;
            ReturnToMenu.MouseEnter += ReturnToMenu_MouseEnter;
            ReturnToMenu.MouseLeave += ReturnToMenu_MouseLeave;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 252F));
            tableLayoutPanel1.Controls.Add(label4, 2, 0);
            tableLayoutPanel1.Controls.Add(label3, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Location = new Point(3, 110);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(781, 54);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Silkscreen Expanded", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(595, 11);
            label4.Name = "label4";
            label4.Size = new Size(119, 32);
            label4.TabIndex = 2;
            label4.Text = "Time";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Silkscreen Expanded", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(314, 11);
            label3.Name = "label3";
            label3.Size = new Size(164, 32);
            label3.TabIndex = 1;
            label3.Text = "Score";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Silkscreen Expanded", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(61, 11);
            label2.Name = "label2";
            label2.Size = new Size(141, 32);
            label2.TabIndex = 0;
            label2.Text = "Name";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Silkscreen Expanded", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(121, 38);
            label1.Name = "label1";
            label1.Size = new Size(553, 43);
            label1.TabIndex = 0;
            label1.Text = "LEADERBOARDS";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._360_F_264279006_WDXxV3OHjAOoHqH7iiLDrg23p0947g7U;
            ClientSize = new Size(784, 561);
            Controls.Add(leaderboardsPanel);
            Controls.Add(MenuContainer);
            MaximumSize = new Size(800, 600);
            MinimumSize = new Size(800, 600);
            Name = "Form2";
            Text = "Form2";
            MenuContainer.ResumeLayout(false);
            MenuContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)menuQuitBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)menuPlayBtn).EndInit();
            leaderboardsPanel.ResumeLayout(false);
            leaderboardsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel MenuContainer;
        private PictureBox menuPlayBtn;
        private PictureBox menuQuitBtn;
        private Label LeaderboardsButton;
        private Panel leaderboardsPanel;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label ReturnToMenu;
        private DataGridView dataGridView1;
    }
}