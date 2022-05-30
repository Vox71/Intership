namespace Intership;

class Program
{
    static void Main()
    {
        Init(3, 3);
    }

    static void Init(int harverstersCount, int warriorsCount)
    {
        Colony colony1 = new Colony(harverstersCount, warriorsCount, 25, 5, "Olga", 27, 26, 5, "Fatleggy");
        for (int i = 0; i < harverstersCount; i++)
        {
            if(i%2 ==0)
                colony1.Harvesters.Add(new AntHarvester(10, 3, "LaoGanMa"));
            else
                colony1.Harvesters.Add(new AntHarvester(30, 15, "Gigachad"));
        }
        for (int i = 0; i < warriorsCount; i++)
        {
            if(i%2 ==0)
                colony1.Warriors.Add(new AntWarrior(10, 3, "Abrikos", 1));
            else
                colony1.Warriors.Add(new AntWarrior(30, 15, "chiki_briki", 1));
        }
        for (int i = 0; i < harverstersCount; i++)
        {
            colony1.Harvesters[i].info();
        }
        for (int i = 0; i < warriorsCount; i++)
        {
            colony1.Warriors[i].info();
        }
        colony1.Gotogang();
    }


}

