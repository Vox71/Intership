namespace Intership;

class Program
{
    static void Main()
    {
        NewColony(3, 3);
        GenerateHeaps();
    }

    static void NewColony(int harverstersCount, int warriorsCount)
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
    }

    static void GenerateHeaps()
    {
        List<heap> heaps = new List<heap>();
        heaps.Add(new heap(14, 19, 0, 0));
        heaps.Add(new heap(49, 0, 23, 0));
        heaps.Add(new heap(36, 0, 26, 15));
        heaps.Add(new heap(14, 0, 10, 0));
        heaps.Add(new heap(14, 0, 0, 40));
    }


}

