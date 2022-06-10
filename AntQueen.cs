namespace Intership;

public class AntQueen : Ant
{
    public int Damage;
    public AntQueen(int health, int defence, string antname, int damage) : base(health, defence, antname)
    {
        Damage = damage;

    }
}