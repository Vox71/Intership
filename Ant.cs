namespace Intership;

public class Ant
{
    public int health;
    public int damage;
    public int defence;
    public string UnitType;

    public Ant(int health, int damage, int defence)
    {
        this.health = health;
        this.damage = damage;
        this.defence = defence;
    }

    public static void info()
    {
        Console.WriteLine("Здоровье = {health}, Урон = {damage}");
    }
}