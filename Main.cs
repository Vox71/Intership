namespace Intership;

class Inicialization
{
    static void Main()
    {
        AntQueen ant1 = new AntQueen(15, 3, 4, "Oleg");
        Console.WriteLine("ant with stats {0}, {1}, {2}, named {3} created", ant1.health, ant1.damage, ant1.defence, ant1.antname);
        AntQueen.idk_do_somethin();
    }
}