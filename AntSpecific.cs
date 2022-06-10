namespace Intership;

public class AntSpecific : Ant
{
    public string Attributes;
    public int Damage;
    public int Backpack;

    public AntSpecific(int health, int defence, string antname, int damage, string attributes) : base(health, defence, antname)
    {
        Damage = damage;
        Attributes = attributes;

    }
    public virtual int Stashloot()
    {
        int loot = Backpack;
        Backpack = 0;
        return loot;
    }
}