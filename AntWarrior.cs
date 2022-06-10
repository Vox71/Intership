namespace Intership;

public class AntWarrior : Ant
{
    public int Damage;
    public string Attributes;
    public AntWarrior(int health, int defence, string antname, int damage, string attributes) : base(health, defence, antname)
    {
        Damage = damage;
        Attributes = attributes;

    }

    public void Attack(List<Heap> heaps, ant)
    {
        for
    }
    public virtual void Info()
    {
        Console.WriteLine($"Здоровье = {Health}, Защита = {Defence}, Тип = {Antname}, Урон = {Damage}");
        if (Place == 0)
            Console.WriteLine("Находится в колонии");
        else
            Console.WriteLine($"Находится в куче {Place}");
    }
}