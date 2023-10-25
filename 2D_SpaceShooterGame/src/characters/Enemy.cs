namespace _2D_SpaceShooterGame;
using _2D_SpaceShooterGame.src.characters;

// default enemy character properties
public class Enemy : Characters
{
    public PictureBox[] bullets = new PictureBox[3];
    public int HealthPoint;
    public Enemy(int health) : base(4, 4, 1)
    {
        //Image = Image.FromFile(@"../../../assets/asserts/E1.png");
        Size = new Size(40, 40);
        SizeMode = PictureBoxSizeMode.Zoom;
        BorderStyle = BorderStyle.None;
        BackColor = Color.Transparent;
        Visible = true;
        HealthPoint = health;
    }

    public void updateHealthPoints()
    {
        this.healthPoints--;
    }

    public void ResetHealth()
    {
        this.healthPoints = HealthPoint;
    }

    public override void IncreaseBulletSpeed()
    {
        this.bulletSpeed++;
    }

    public override void IncreaseMoveSpeed()
    {
        this.moveSpeed++;
    }
}