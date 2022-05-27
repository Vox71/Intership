using System.Collections.Generic;
using System;

class Nest
{
    public List<Unit> units;
    public Nest(int countUnits, int totalDefense)
    {
        units = new List<Unit>(countUnits);
    }

    public void info()
    {
        while() {
            Unit.info();
        }
    }
}

class Unit
{
    public int health;
    public int damage;
    public int defense;
    public string UnitType;

    public static void info()
    {
        Console.WriteLine("Здоровье = {health}, Урон = {damage}");
    }
}

class HarvesterAnt : Unit
{
    public void harvest();
}
class WarriorAnt : Unit
{
    public void attack();
}