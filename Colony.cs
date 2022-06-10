namespace Intership;

public class Colony
{
    public List<AntWarrior> Warriors;
    public List<AntHarvester> Harvesters;
    public AntQueen Queen;
    public AntSpecific Specific;
    public string ColonyName;
    public int Stash;
    public Colony(int harvesterCount, int warriorsCount, int qHealth, int qDefence, string qAntname, int qDamage, int sHealth, int sDefence, string sAntname, int sDamage, string sAttributes, string colonyName)
    {
        Harvesters = new List<AntHarvester>(harvesterCount);
        Warriors = new List<AntWarrior>(warriorsCount);
        Queen = new AntQueen(qHealth, qDefence, qAntname, qDamage);
        Specific = new AntSpecific(sHealth, sDefence, sAntname, sDamage, sAttributes);
    }

    public void Info()
    {
        
    }

    public void Gotogang()
    {
        for (int i = 0; i < Warriors.Count; i++)
            Warriors[i].Gotoheap();
        for (int i = 0; i < Harvesters.Count; i++)
            Harvesters[i].Gotoheap();
        Specific.Gotoheap();
    }
    public void ColonyRaid(List<Heap> heaps)
    {
        for (int i = 0; i < Harvesters.Count; i++)
            Harvesters[i].Gotoheap();
        for (int i = 0; i < Warriors.Count; i++)
            Warriors[i].Gotoheap();
        for (int i = 0; i < Harvesters.Count; i++)
            Harvesters[i].AttrCheck(heaps);
        for (int i = 0; i < Warriors.Count; i++)
            Warriors[i].Gotocolony();
        for (int i = 0; i < Harvesters.Count; i++)
        {
            Stash += Harvesters[i].Stashloot();
            Harvesters[i].Gotocolony();
        }
    }
}