namespace Intership;

public class AntSpecific : Ant
{
    public string Attributes;
    public int Damage;
    public int Backpack;
    public string QueenName;

    public AntSpecific(int health, int defence, string antname, int damage, string attributes, string colonyName, string queenName) : base(health, defence, antname, colonyName)
    {
        Damage = damage;
        Attributes = attributes;
        QueenName = queenName;

    }

    public void QueenInfo()
    {
        Console.WriteLine($"Я служу королеве по имени {QueenName}");
    }
}