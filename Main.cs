namespace Intership;

class Program
{
    static void Main()
    {
        Init(3, 3);
    }

    static void Init(int harverstersCount, int warriorsCount)
    {
        Colony colony1 = new Colony(harverstersCount, warriorsCount, 25, 5, "Olga", 26, 5, "Fatleggy");
        for (int i = 0; i < harverstersCount; i++)
        {
            if(i%2 ==0)
                colony1.Harvesters.Add(new AntHarvester(10, 3, "LaoGanMa"));
            else
                colony1.Harvesters.Add(new AntHarvester(30, 15, "Gigachad"));
        }
        for (int i = 0; i < harverstersCount; i++)
        {
            colony1.Harvesters[i].info();
        }
    }


}

