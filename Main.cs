namespace Intership;
class Program
{
    static void Main()
    {
        NewColony1(18, 9, "Черные", "Ольга");
        NewColony2(15, 9, "Зеленые", "Агриппина");
        NewColony3(14, 5, "Красные", "Изабелла");
        GenerateHeaps();
    }

    static void NewColony1(int harverstersCount, int warriorsCount, string colonyName, string queenName)
    {
        Colony colony1 = new Colony(harverstersCount, warriorsCount, 25, 5, queenName, 
            27, 26, 5, "Толстоножка", 0,
            "трудолюбивый (может брать: веточка) обычный мирный любимчик королевы", colonyName);
        for (int i = 0; i < harverstersCount; i++)
        {
            if(i%2 ==0)
                colony1.Harvesters.Add(new AntHarvester(6, 2, "РАБОЧИЙ", "продвинутый (может брать: росинка или листик)", colonyName, queenName));
            else
                colony1.Harvesters.Add(new AntHarvester(1, 0, "РАБОЧИЙ", "обычный (может брать: листик) сильный", colonyName, queenName));
        }
        for (int i = 0; i < warriorsCount; i++)
        {
            if(i%2 ==0)
                colony1.Warriors.Add(new AntWarrior(6, 2, "ВОИН", 3, "продвинутый", colonyName, queenName));
            else
                colony1.Warriors.Add(new AntWarrior(6, 2, "ВОИН", 3, "продвинутый точный", colonyName, queenName));
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
    static void NewColony2(int harverstersCount, int warriorsCount, string colonyName, string queenName)
    {
        Colony colony2 = new Colony(harverstersCount, warriorsCount, 24, 6, queenName, 
            19, 19, 5, "Термит", 13,
            "трудолюбивый обычный агрессивный мифический сонный", colonyName);
        for (int i = 0; i < harverstersCount; i++)
        {
            if(i%2 ==0)
                colony2.Harvesters.Add(new AntHarvester(1, 0, "РАБОЧИЙ", "обычный", colonyName, queenName));
            else
                colony2.Harvesters.Add(new AntHarvester(1, 0, "РАБОЧИЙ","обычный забывчивый", colonyName, queenName));
        }
        for (int i = 0; i < warriorsCount; i++)
        {
            if(i%2 ==0)
                colony2.Warriors.Add(new AntWarrior(1, 0, "ВОИН", 1, "обычный", colonyName, queenName));
            else
                colony2.Warriors.Add(new AntWarrior(2, 1, "ВОИН", 2, "старший сосредоточенный",colonyName, queenName));
        }
        for (int i = 0; i < harverstersCount; i++)
        {
            colony2.Harvesters[i].Info();
        }
        for (int i = 0; i < warriorsCount; i++)
        {
            colony2.Warriors[i].Info();
        }
    }
    static void NewColony3(int harverstersCount, int warriorsCount, string colonyName, string queenName)
    {
        Colony colony3 = new Colony(harverstersCount, warriorsCount, 25, 5, queenName, 
            0, 26, 5, "Пчела", 0, "ленивый обычный мирный подготовленный", colonyName);
        for (int i = 0; i < harverstersCount; i++)
        {
            if(i%2 ==0)
                colony3.Harvesters.Add(new AntHarvester(6, 2, "РАБОЧИЙ", "продвинутый", colonyName, queenName));
            else
                colony3.Harvesters.Add(new AntHarvester(1, 0, "РАБОЧИЙ", "обычный глупый", colonyName, queenName));
        }
        for (int i = 0; i < warriorsCount; i++)
        {
            if(i%2 ==0)
                colony3.Warriors.Add(new AntWarrior(2, 1, "ВОИН", 2, "старший", colonyName, queenName));
            else
                colony3.Warriors.Add(new AntWarrior(10, 6, "ВОИН", 4, "легендарный точный", colonyName, queenName));
        }
        for (int i = 0; i < harverstersCount; i++)
        {
            colony3.Harvesters[i].Info();
        }
        for (int i = 0; i < warriorsCount; i++)
        {
            colony3.Warriors[i].Info();
        }
    }
    public static void GenerateHeaps()
    {
        List<Heap> heaps = new List<Heap>();
        heaps.Add(new Heap(14, 19, 0, 0));
        heaps.Add(new Heap(49, 0, 23, 0));
        heaps.Add(new Heap(36, 0, 26, 15));
        heaps.Add(new Heap(14, 0, 10, 0));
        heaps.Add(new Heap(14, 0, 0, 40));
    }
}

