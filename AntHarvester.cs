namespace Intership;

public class AntHarvester : Ant
{
    public int Backpack;
    public string Attributes;
    public AntHarvester(int health, int defence, string antname, string attributes) : base(health, defence, antname)
    {
        Attributes = attributes;
    }

    public void AttrCheck(List<Heap> heaps)
    {
        if (Attributes.Contains("сильный"))
        {
            for (int i = 0; i < 1; i++)
            {
                if (!Attributes.Contains("забывчивый"))
                {
                    Random rnd = new Random();
                    if (rnd.Next(1, 2) == 1)
                    {
                        if (Attributes.Contains("обычный"))
                        {
                            Getloot(heaps);
                        }

                        if (Attributes.Contains("продвинутый"))
                        {
                            Getloot(heaps);
                            Getloot(heaps);
                        }
                    }
                }
            }
        }
    }

    public void Getloot(List<Heap> heaps)
        {
        if (heaps[Place].Stick + heaps[Place].Pebble + heaps[Place].Leaf + heaps[Place].Dew > 0)
        {
            if (Attributes.Contains("веточка") & heaps[Place].Stick > 0)
            {
                Backpack++;
                heaps[Place].Stick--;
            }

            if (Attributes.Contains("камушек") & heaps[Place].Pebble > 0)
            {
                Backpack++;
                heaps[Place].Pebble--;
            }

            if (Attributes.Contains("листик") & heaps[Place].Leaf > 0)
            {
                Backpack++;
                heaps[Place].Leaf--;
            }

            if (Attributes.Contains("росинка") & heaps[Place].Dew > 0)
            {
                Backpack++;
                heaps[Place].Dew--;
            }
        }
        }

    public virtual int Stashloot()
    {
        int loot = Backpack;
        Backpack = 0;
        return loot;
    }
}