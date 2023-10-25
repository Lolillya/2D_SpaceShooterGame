namespace _2D_SpaceShooterGame;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
using MySql.Data.MySqlClient;
using System.Data;

public partial class Form1 : Form
{
    // initialize mysql server connection
    MySqlConnection con = new MySqlConnection("SERVER=LOCALHOST ;DATABASE=PlayerLeaderboards ;UID=root ;PASSWORD=drop 2 hard;");

    // add game bgm from properties resources
    SoundPlayer gameSound = new SoundPlayer(Properties.Resources.bgm);
    //SoundPlayer bulletSound;

    private int seconds;        

    public Form1()
    {
        InitializeComponent();
        seconds = 0;
        EndGamePanel.Width = this.Width;
        EndGamePanel.Height = this.Height;
    }

    PictureBox[] enemyMunition;

    PictureBox[] stars;
    Random rnd;

    Player player = new Player();
    Enemy[] enemy_a = new Enemy[10];

    int formWidth;
    int formHeight;

    int backgroundSpeed;
    private int score;
    int level;
    int dificulty;
    bool pause;

    // initialize enemy image from file
    Image enemy1 = Image.FromFile(@"../../../assets/asserts/E1.png");
    Image enemy2 = Image.FromFile(@"../../../assets/asserts/E2.png");
    Image enemy3 = Image.FromFile(@"../../../assets/asserts/E3.png");
    Image boss1 = Image.FromFile(@"../../../assets/asserts/Boss1.png");
    Image boss2 = Image.FromFile(@"../../../assets/asserts/Boss2.png");

    List<Image> image = new List<Image>();

    private void Form1_Load(object sender, EventArgs e)
    {
        // adds enemy image into list
        image.Add(enemy1);
        image.Add(enemy2);
        image.Add(enemy3);
        image.Add(boss1);
        image.Add(boss2);


        // game default values
        pause = false;
        score = 0;
        level = 1;
        dificulty = 9;
        backgroundSpeed = 4;
        // ----------------------------


        formWidth = this.Width;
        formHeight = this.Height;

        enemyMunition = new PictureBox[10];

        rnd = new Random();


        // Player model Initial Position
        Controls.Add(player.sprite);
        player.sprite.Location = new Point((this.Width - player.sprite.Width) / 2, (this.Height - player.sprite.Height) - 50);
        



        // loads enemies by initializing new instance of an array and randomly assigns image from image list
        for (int i = 0; i < enemy_a.Length; i++)
        {
            enemy_a[i] = new Enemy(level);
            enemy_a[i].Image = image[rnd.Next(0, image.Count)];
            this.Controls.Add(enemy_a[i]);

            int xPosition = (int)(((double)i / (enemy_a.Length - 1)) * (this.Width - enemy_a[i].Width));
            int yPosition = -50;

            enemy_a[i].Location = new Point(xPosition - 50, yPosition);
        }



        // Load Player bullets from Player Object then add the bullets to forms
        for (int i = 0; i < player.bullets.Length; i++)
            this.Controls.Add(player.bullets[i]);


        // Load Enemy bullets from PictureBox array then adds to forms
        for (int i = 0; i < enemyMunition.Length; i++)
        {
            enemyMunition[i] = new PictureBox();
            enemyMunition[i].Size = new Size(2, 25);
            enemyMunition[i].Visible = false;
            enemyMunition[i].BackColor = Color.Yellow;
            enemyMunition[i].Location = new Point(enemy_a[i].Location.X, enemy_a[i].Location.Y - 20);
            this.Controls.Add(enemyMunition[i]);
        }
        // ------------------------


        // adds stars background and assigns random speed to each stars 
        stars = new PictureBox[10];
        for (int i = 0; i < stars.Length; i++)
        {
            stars[i] = new PictureBox();
            stars[i].BorderStyle = BorderStyle.None;
            stars[i].Location = new Point(rnd.Next(20, formWidth), rnd.Next(-10, formHeight));
            if (i % 2 == 1)
            {
                stars[i].Size = new Size(2, 2);
                stars[i].BackColor = Color.Wheat;
            }
            else
            {
                stars[i].Size = new Size(3, 3);
                stars[i].BackColor = Color.DarkGray;
            }
            this.Controls.Add(stars[i]);
        }

        // plays game bgm
        gameSound.Play();

        // set player label text to player default health points
        playerHealthLabel.Text = player.healthPoints.ToString();

        // set level label to initial game level
        LevelLabel.Text = $"Level: {level}";
    }


    // move stars from top to bottom by 'n' pixels per 'm' timer interval
    private void MoveBgTimer_Tick(object sender, EventArgs e)
    {
        for (int i = 0; i < stars.Length / 2; i++)
        {
            stars[i].Top += backgroundSpeed;

            if (stars[i].Top >= this.Height)
                stars[i].Top = -stars[i].Height;

        }

        for (int i = stars.Length / 2; i < stars.Length; i++)
        {
            stars[i].Top += backgroundSpeed - 2;

            if (stars[i].Top >= this.Height)
                stars[i].Top = -stars[i].Height;
        }
    }

    // move player to left by 'n' pixels per 'm' timer interval
    private void LeftMoveTimer_Tick(object sender, EventArgs e)
    {
        if (player.sprite.Left > 10)
            player.sprite.Left -= player.moveSpeed;
    }

    // move player to right by 'n' pixels per 'm' timer interval
    private void RightMoveTimer_Tick(object sender, EventArgs e)
    {
        if (player.sprite.Right < formWidth - 20)
            player.sprite.Left += player.moveSpeed;
    }

    // move player upwards by 'n' pixels per 'm' timer interval
    private void UpMoveTimer_Tick(object sender, EventArgs e)
    {
        if (player.sprite.Top > 10)
            player.sprite.Top -= player.moveSpeed;
    }

    // move player downwards by 'n' pixels per 'm' timer interval
    private void DownMoveTimer_Tick(object sender, EventArgs e)
    {
        if (player.sprite.Top < formHeight - 100)
            player.sprite.Top += player.moveSpeed;
    }

    // sets player movement controls then call move method on key down press
    private void Form1_KeyDown(object sender, KeyEventArgs e)
    {
        if (!pause)
        {
            if (e.KeyCode == Keys.Right)
                RightMoveTimer.Start();
            if (e.KeyCode == Keys.Left)
                LeftMoveTimer.Start();
            if (e.KeyCode == Keys.Down)
                DownMoveTimer.Start();
            if (e.KeyCode == Keys.Up)
                UpMoveTimer.Start();

        }
        if (e.KeyCode == Keys.Escape)
            PauseGame();
    }

    // stops player movement on key release by stopping the move timer
    private void Form1_KeyUp(object sender, KeyEventArgs e)
    {
        RightMoveTimer.Stop();
        LeftMoveTimer.Stop();
        DownMoveTimer.Stop();
        UpMoveTimer.Stop();
    }

    // pause or unpause game then set pause menu if paused, hide it otherwise
    private void PauseGame()
    {
        if (pause)
        {
            pause = false;
            startTimers();
        }
        else
        {
            pause = true;
            stopTimers();
        }
        PauseLabel.Visible = pause ? true : false;
        ResumeLabel.Visible = pause ? true : false;
        QuitLabel.Visible = pause ? true : false;
    }

    // sets player bullet speed value from initialized value on Player object
    private void MoveMunitionsTimer_Tick(object sender, EventArgs e)
    {
        for (int i = 0; i < player.bullets.Length; i++)
        {
            if (player.bullets[i].Top > 0)
            {
                //PlayBulletSound(i);
                player.bullets[i].Visible = true;
                player.bullets[i].Top -= player.bulletSpeed;

                Collision();
            }
            else
            {
                player.bullets[i].Visible = false;
                player.bullets[i].Location = new Point(player.sprite.Location.X + 20, player.sprite.Location.Y - i * 30);
            }
        }
    }

    // method chaining, passing Enemy object as parameter to call MoveEnemies method
    private void MoveEnemyTimer_Tick(object sender, EventArgs e)
    {
        MoveEnemies(enemy_a);
    }

    // assign enemy bullet speed from the values of an object
    private void MoveEnemies(Enemy[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i].Visible = true;
            array[i].Top += array[i].bulletSpeed;

            if (array[i].Top > this.Height)
            {
                array[i].Location = new Point((i + 1) * 50, -200);

            }
        }
    }

    // method chaining, object collision system between the player, enemies, and bullets
    private void Collision()
    {
        for (int i = 0; i < enemy_a.Length; i++)
        {
            PlayerMunitionCollision(i);


            if (player.sprite.Bounds.IntersectsWith(enemy_a[i].Bounds))
            {
                player.sprite.Visible = false;
                playerHealthLabel.Text = "0";
                gameOver("Game Over");
            }
        }
    }

    //private void PlayBulletSound(int i)
    //{
    //    if (player.bullets[i].Visible == false)
    //        bulletSound.Play();


    //}

    // if 'n' bullet from player collide to enemy[m], subtract enemy healthpoints by 1 then re-position the player bullet to player position
    // increase game difficulty by 1 per 30 score
    private void PlayerMunitionCollision(int i)
    {
        int xPosition = (int)(((double)i / (enemy_a.Length - 1)) * (this.Width - enemy_a[i].Width)) - 20;
        int yPosition = -50;

        for (int ii = 0; ii < player.bullets.Length; ii++)
        {
            if (player.bullets[ii].Bounds.IntersectsWith(enemy_a[i].Bounds))
            {

                enemy_a[i].updateHealthPoints();
                player.bullets[ii].Visible = false;
                player.bullets[ii].Location = new Point(player.sprite.Location.X + 20, player.sprite.Location.Y - i);
                if (enemy_a[i].healthPoints <= 0)
                {

                    //UnloadBullets();
                    //player.BulletCount++;
                    //player.GenerateBullets();
                    //ReloadBullets();

                    score += 1 * level;
                    scoreInfo.Text = $"{score}";
                    if (score % 30 == 0)
                    {
                        level++;
                        LevelLabel.Text = $"Level: {level}";
                        if (enemy_a[i].moveSpeed <= 10 && enemy_a[i].bulletSpeed <= 10 && dificulty >= 0)
                        {
                            dificulty--;
                            LevelUpEnemies();
                        }
                    }
                    enemy_a[i].ResetHealth();
                    enemy_a[i].Location = new Point(xPosition, yPosition);
                }

            }
        }
    }

    // increase enemy bullet speed, move speed, healthpoints on level up. also decrease enemy timers for faster movement
    private void LevelUpEnemies()
    {
        for (int i = 0; i < enemy_a.Length; i++)
        {
            enemy_a[i].IncreaseBulletSpeed();
            enemy_a[i].IncreaseMoveSpeed();
            enemy_a[i].HealthPoint++;
            enemy_a[i].ResetHealth();
        }
        MoveEnemyTimer.Interval -= 5;
        EnemyMunitionTimer.Interval -= 1;    
    }



    private void UnloadBullets()
    {
        for (int i = 0; i < player.bullets.Length; i++)
        {
            player.bullets[i].Visible = false;
        }
    }

    private void ReloadBullets()
    {
        for (int i = 0; i < player.bullets.Length; i++)
            this.Controls.Add(player.bullets[i]);
    }


    // show gameover window
    private void gameOver(string str)
    {
        gameSound.Stop();
        player.sprite.Visible = false;
        stopTimers();
        EndGamePanel.Visible = true;
        ScoreLabel.Visible = false;
        GameTimeLabel.Visible = false;
        scoreInfo.Visible = false;
        LevelLabel.Visible = false;
        ScoreInfoFinal.Text = scoreInfo.Text;
        timeFinal.Text = GameTimeLabel.Text;
    }

    // stops all timers
    private void stopTimers()
    {
        MoveBgTimer.Stop();
        MoveEnemyTimer.Stop();
        MoveMunitionsTimer.Stop();
        EnemyMunitionTimer.Stop();
        GameTime.Stop();
    }

    // starts all timers
    private void startTimers()
    {
        MoveBgTimer.Start();
        MoveEnemyTimer.Start();
        MoveMunitionsTimer.Start();
        EnemyMunitionTimer.Start();
        GameTime.Start();
    }

    // sets enemy bullet speed from object value, then call enemy bullet collision method
    private void EnemyMunitionTimer_Tick(object sender, EventArgs e)
    {
        for (int i = 0; i < enemyMunition.Length; i++)
        {
            if (enemyMunition[i].Top < this.Height)
            {
                enemyMunition[i].Visible = true;
                enemyMunition[i].Top += enemy_a[i].bulletSpeed;

                EnemyMunitionCollision();
            }

            else
            {
                enemyMunition[i].Visible = false;
                int x = rnd.Next(0, 10);
                enemyMunition[i].Location = new Point(enemy_a[x].Location.X + 20, enemy_a[x].Location.Y + 30);
            }
        }
    }

    // enemy bullet collision system, if bullets hits player, decrease player healthpoint then reposition bullet to a random enemy
    private void EnemyMunitionCollision()
    {
        for (int i = 0; i < enemyMunition.Length; i++)
        {
            if (enemyMunition[i].Bounds.IntersectsWith(player.sprite.Bounds))
            {
                enemyMunition[i].Visible = false;
                player.updateHealthPoints();
                playerHealthLabel.Text = player.healthPoints.ToString();
                enemyMunition[i].Visible = false;
                enemyMunition[i].Location = new Point(enemy_a[i].Location.X + 20, enemy_a[i].Location.Y + 30);
                if (player.healthPoints <= 0)
                    gameOver("Game Over");
            }
        }
    }

    // game timer tick, update timer label per tick
    private void GameTime_Tick(object sender, EventArgs e)
    {
        GameTimeLabel.Text = TimeSpan.FromSeconds(seconds).ToString(@"hh\:mm\:ss");
        seconds++;
    }

    private void label1_MouseEnter(object sender, EventArgs e)
    {
        ResumeLabel.Font = new Font(ResumeLabel.Font.FontFamily, ResumeLabel.Font.Size * 1.2f);
    }

    private void ResumeLabel_MouseLeave(object sender, EventArgs e)
    {
        ResumeLabel.Font = new Font(ResumeLabel.Font.FontFamily, 24);
    }

    private void QuitLabel_MouseEnter(object sender, EventArgs e)
    {
        QuitLabel.Font = new Font(QuitLabel.Font.FontFamily, QuitLabel.Font.Size * 1.2f);
    }

    private void QuitLabel_MouseLeave(object sender, EventArgs e)
    {
        QuitLabel.Font = new Font(QuitLabel.Font.FontFamily, 24);
    }


    private void ResumeLabel_Click(object sender, EventArgs e)
    {
        PauseGame();
    }

    private void QuitLabel_Click(object sender, EventArgs e)
    {
        gameSound.Stop();
        this.Close();
    }

    private void SubmitButton_MouseEnter(object sender, EventArgs e)
    {
        SubmitButton.Font = new Font(SubmitButton.Font.FontFamily, SubmitButton.Font.Size * 1.2f);
    }

    private void SubmitButton_MouseLeave(object sender, EventArgs e)
    {
        SubmitButton.Font = new Font(SubmitButton.Font.FontFamily, 24);
    }

    // submit final score to sql server
    private void SubmitButton_Click(object sender, EventArgs e)
    {
        try
        {
            MySqlDataAdapter da = new MySqlDataAdapter("INSERT INTO leaderboards(Name, Score, Time) " +
                "VALUES('" + NameInput.Text + "'," + score + ",'" + timeFinal.Text + "') ", con);
            DataSet ds = new DataSet();

            da.Fill(ds);
        }

        catch (Exception x)
        {
            MessageBox.Show(x + "");
        }

        this.Close();
    }
}