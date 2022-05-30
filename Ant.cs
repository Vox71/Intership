namespace Intership;

public class Ant
{
    public int health;
    public int damage;
    public int defence;
    public string antname;

    public Ant(int health, int damage, int defence, string antname)
    {
        this.health = health;
        this.damage = damage;
        this.defence = defence;
        this.antname = antname;
    }

    public static void info()
    {
        Console.WriteLine("Здоровье = {health}, Урон = {damage}");
    }
}