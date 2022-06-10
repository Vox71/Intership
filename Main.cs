namespace Intership;
class Program
{
    
    static void Main()
    {
        NewColony1(18, 9);
        NewColony2(15, 9);
        //NewColony3(14, 5);
        //GenerateHeaps();
        
    }

    static void NewColony1(int harverstersCount, int warriorsCount)
    {
        Colony colony1 = new Colony(harverstersCount, warriorsCount, 25, 5, "Ольга", 
            27, 26, 5, "Толстоножка", 0,
            "трудолюбивый (может брать: веточка) обычный мирный любимчик королевы", "Черные");
        for (int i = 0; i < harverstersCount; i++)
        {
            if(i%2 ==0)
                colony1.Harvesters.Add(new AntHarvester(6, 2, "РАБОЧИЙ", "продвинутый (может брать: росинка или листик)"));
            else
                colony1.Harvesters.Add(new AntHarvester(1, 0, "РАБОЧИЙ", "обычный (может брать: листик) сильный"));
        }
        for (int i = 0; i < warriorsCount; i++)
        {
            if(i%2 ==0)
                colony1.Warriors.Add(new AntWarrior(6, 2, "ВОИН", 3, "продвинутый"));
            else
                colony1.Warriors.Add(new AntWarrior(6, 2, "ВОИН", 3, "продвинутый точный"));
        }
        for (int i = 0; i < harverstersCount; i++)
        {
            colony1.Harvesters[i].Info();
        }
        for (int i = 0; i < warriorsCount; i++)
        {
            colony1.Warriors[i].Info();
        }
    }
    static void NewColony2(int harverstersCount, int warriorsCount)
    {
        Colony colony1 = new Colony(harverstersCount, warriorsCount, 24, 6, "Агриппина", 
            19, 19, 5, "Термит", 13, "трудолюбивый обычный агрессивный мифический сонный", "Зеленые");
        for (int i = 0; i < harverstersCount; i++)
        {
            if(i%2 ==0)
                colony1.Harvesters.Add(new AntHarvester(1, 0, "РАБОЧИЙ", "обычный"));
            else
                colony1.Harvesters.Add(new AntHarvester(1, 0, "РАБОЧИЙ","обычный забывчивый"));
        }
        for (int i = 0; i < warriorsCount; i++)
        {
            if(i%2 ==0)
                colony1.Warriors.Add(new AntWarrior(1, 0, "ВОИН", 1, "обычный"));
            else
                colony1.Warriors.Add(new AntWarrior(2, 1, "ВОИН", 2, "старший сосредоточенный"));
        }
        for (int i = 0; i < harverstersCount; i++)
        {
            colony1.Harvesters[i].Info();
        }
        for (int i = 0; i < warriorsCount; i++)
        {
            colony1.Warriors[i].Info();
        }
    }
    /*static void NewColony3(int harverstersCount, int warriorsCount)
    {
        Colony colony1 = new Colony(harverstersCount, warriorsCount, 25, 5, "Olga", 
            27, 26, 5, "Fatleggy", 0, "Чорный");
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
            colony1.Harvesters[i].Info();
        }
        for (int i = 0; i < warriorsCount; i++)
        {
            colony1.Warriors[i].Info();
        }
    }*/
    public static void GenerateHeaps()
    {
        List<Heap> heaps = new List<Heap>();
        heaps.Add(new Heap(14, 19, 0, 0));
        heaps.Add(new Heap(49, 0, 23, 0));
        heaps.Add(new Heap(36, 0, 26, 15));
        heaps.Add(new Heap(14, 0, 10, 0));
        heaps.Add(new Heap(14, 0, 0, 40));
    }

    public void Raid()
    {
    }

}

