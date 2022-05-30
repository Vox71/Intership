namespace Intership;

public class Ant
{
    public int health;
    public int defence;
    public string antname;
    public int place = 0;

    public Ant(int health, int defence, string antname)
    {
        this.health = health;
        this.defence = defence;
        this.antname = antname;
    }

    public void info()
    {
        Console.WriteLine($"Здоровье = {health}, Защита = {defence}, Имя = {antname}");
    }

    public void gotoheap()
    {
        Random rnd = new Random();
        place = rnd.Next(1, 5);
        Console.WriteLine($"{antname} отправляется на кучу {place}");
    }
}