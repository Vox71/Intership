namespace Intership;

public class AntQueen : Ant
{
    public int Damage;
    public AntQueen(int health, int defence, string antname, int damage, string colonyName) : base(health, defence, antname, colonyName)
    {
        Damage = damage;
    }
}