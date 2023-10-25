using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _2D_SpaceShooterGame
{
    public partial class Form2 : Form
    {
        // initialize mysql server connection
        MySqlConnection con = new MySqlConnection("SERVER=LOCALHOST ;DATABASE=PlayerLeaderboards ;UID=root ;PASSWORD=drop 2 hard;");
        public Form2()
        {
            InitializeComponent();

        }


        // resize on mouse hover
        private void playBtn_onMouseEnter(object sender, EventArgs e)
        {
            menuPlayBtn.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void playBtn_onMouseLeave(object sender, EventArgs e)
        {
            menuPlayBtn.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void QuitBtn_onMouseEnter(object sender, EventArgs e)
        {
            menuQuitBtn.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void QuitBtn_onMouseLeave(object sender, EventArgs e)
        {
            menuQuitBtn.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        // hides this form on click then opens new form to the main game
        private void menuPlayBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 MainGame = new Form1();
            MainGame.ShowDialog(this);

            while (MainGame.Visible)
                if (!MainGame.Visible)
                    break;

            this.Show();
        }

        // exits application on click
        private void menuQuitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // center menu content on load
        private void MenuContainer_Paint(object sender, PaintEventArgs e)
        {
            int panelX = (this.Width - MenuContainer.Width) / 2;
            int panelY = (this.Height - MenuContainer.Height) / 2;
            MenuContainer.Location = new Point(panelX, panelY);
        }

        // resize on hover
        private void LeaderboardsButton_MouseEnter(object sender, EventArgs e)
        {
            LeaderboardsButton.Font = new Font(LeaderboardsButton.Font.FontFamily, LeaderboardsButton.Font.Size * 1.2f);
        }

        private void LeaderboardsButton_MouseLeave(object sender, EventArgs e)
        {
            LeaderboardsButton.Font = new Font(LeaderboardsButton.Font.FontFamily, 24, FontStyle.Bold);
        }

        // loads data from sql server then lists the data to the data-table 
        private void LeaderboardsButton_Click(object sender, EventArgs e)
        {
            leaderboardsPanel.Visible = true;


            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT Name, Score, Time FROM leaderboards ORDER BY Score DESC", con);
                DataSet ds = new DataSet();

                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }

            catch (Exception x)
            {
                MessageBox.Show(x + "");
            }
        }

        // resize on hover
        private void ReturnToMenu_MouseEnter(object sender, EventArgs e)
        {
            ReturnToMenu.Font = new Font(ReturnToMenu.Font.FontFamily, ReturnToMenu.Font.Size * 1.2f);
        }

        private void ReturnToMenu_MouseLeave(object sender, EventArgs e)
        {
            ReturnToMenu.Font = new Font(ReturnToMenu.Font.FontFamily, 28);
        }

        private void ReturnToMenu_Click(object sender, EventArgs e)
        {
            leaderboardsPanel.Visible = false;
        }
    }
}
