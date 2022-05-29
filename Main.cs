using System.Collections.Generic;
using System;
namespace Intership;

class Inicialization
{
    static void Main()
    {
        Ant ant1 = new Ant(15, 3, 4);
        Console.WriteLine("ant with stats {0}, {1}, {2} created", ant1.health, ant1.damage, ant1.defence);
        AntQueen.idk_do_somethin();
    }
}