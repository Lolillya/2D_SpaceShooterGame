namespace _2D_SpaceShooterGame.src.characters;

// game character default properties
public abstract class Characters : PictureBox
{
    public PictureBox sprite = new PictureBox();

    public int bulletSpeed { get; set; }
    public int moveSpeed { get; set; }
    public int healthPoints { get; set; }

    public Characters(int bulletSpeed, int moveSpeed, int healthPoints)
    {
        this.bulletSpeed = bulletSpeed;
        this.moveSpeed = moveSpeed;
        this.healthPoints = healthPoints;
    }

    public virtual void updateHealthPoints() { }

    public virtual void IncreaseBulletSpeed()
    {
        bulletSpeed++;
    }

    public virtual void IncreaseMoveSpeed()
    {
        moveSpeed++;
    }
}