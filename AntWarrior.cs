namespace Intership;

public class AntWarrior : Ant
{
    public int Damage;
    public string Attributes;
    public string QueenName;
    public AntWarrior(int health, int defence, string antname, int damage, string attributes, string colonyName, string queenName) : base(health, defence, antname, colonyName)
    {
        Damage = damage;
        Attributes = attributes;
        QueenName = queenName;
    }
    public virtual void Info()
    {
        Console.WriteLine($"Здоровье = {Health}, Защита = {Defence}, Тип = {Antname}, Урон = {Damage}");
    }
    public void QueenInfo()
    {
        Console.WriteLine($"Я служу королеве по имени {QueenName}");
    }
}