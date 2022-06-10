namespace Intership;

public class Ant
{
    public int Health;
    public int Defence;
    public string Antname;
    public string ColonyName;
    public Ant(int health, int defence, string antname, string colonyName)
    {
        Health = health; 
        Defence = defence;
        Antname = antname;
        ColonyName = colonyName;
    }
    public void Info()
    {
        Console.WriteLine($"Здоровье = {Health}, Защита = {Defence}, Тип = {Antname}");
    }
    
}