namespace Intership;

public class AntHarvester : Ant
{
    public int Backpack;
    public string Attributes;
    public string QueenName;
    public AntHarvester(int health, int defence, string antname, string attributes, string colonyName, string queenName) : base(health, defence, antname, colonyName)
    {
        Attributes = attributes;
        QueenName = queenName;
    }
    public void QueenInfo()
    {
        Console.WriteLine($"Я служу королеве по имени {QueenName}");
    }
}