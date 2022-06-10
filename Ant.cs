namespace Intership;

public class Ant
{
    public int Health;
    public int Defence;
    public string Antname;
    public int Place = 0;


    public Ant(int health, int defence, string antname)

    {
        Health = health; 
        Defence = defence;
        Antname = antname;
    }

    public void Info()
    {
        Console.WriteLine($"Здоровье = {Health}, Защита = {Defence}, Тип = {Antname}");
        if (Place == 0)
            Console.WriteLine("Находится в колонии");
        else
            Console.WriteLine($"Находится в куче {Place}");
    }

    public void Gotoheap()
    {
        Random rnd = new Random();
        Place = rnd.Next(1, 5);
        Console.WriteLine($"{Antname} отправляется на кучу {Place}");
    }
    public void Gotocolony()
    {
        Place = 0;
    }
    
}