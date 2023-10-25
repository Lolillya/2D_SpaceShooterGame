using _2D_SpaceShooterGame.src.characters;

// default player properties
public class Player : Characters
{
    public List<PictureBox> bulletsTest = new List<PictureBox>();
    public int BulletCount = 4;
    public PictureBox[] bullets;

    public Player() : base(10, 4, 7)
    {
        this.sprite.Image = Image.FromFile(@"..\..\..\assets\asserts\player.png");
        this.sprite.Size = new Size(50, 50);
        this.sprite.SizeMode = PictureBoxSizeMode.Zoom;
        this.sprite.BorderStyle = BorderStyle.None;
        this.sprite.BackColor = Color.Transparent;
        this.sprite.Visible = true;
        GenerateBullets();
    }

    // generate player bullets
    public void GenerateBullets()
    {
        bullets = new PictureBox[BulletCount];
        for (int i = 0; i < BulletCount; i++)
        {
            bullets[i] = new PictureBox();
            bullets[i].Size = new Size(8, 8);
            bullets[i].Image = Image.FromFile(@"../../../assets/asserts/munition.png");
            bullets[i].SizeMode = PictureBoxSizeMode.Zoom;
            bullets[i].BorderStyle = BorderStyle.None;
            bullets[i].Visible = false;
        }
    }


    // updates player health by decrementing by 1;
    public override void updateHealthPoints()
    {
        this.healthPoints--;
    }
}