namespace Intership;

public class Colony
{
    public List<AntWarrior> Warriors;
    public List<AntHarvester> Harvesters;
    public AntQueen Queen;
    public AntSpecific Specific;
    public int stash;
    public Colony(int harvesterCount, int warriorsCount, int qHealth, int qDefence, string qAntname, int qDamage, int sHealth, int sDefence, string sAntname)
    {
        Harvesters = new List<AntHarvester>(harvesterCount);
        Warriors = new List<AntWarrior>(warriorsCount);
        Queen = new AntQueen(qHealth, qDefence, qAntname, qDamage);
        Specific = new AntSpecific(sHealth, sDefence, sAntname);
    }

    public void Info()
    {
        
    }

    public void Gotogang()
    {
        for (int i = 0; i < Warriors.Count; i++)
            Warriors[i].gotoheap();
        for (int i = 0; i < Harvesters.Count; i++)
            Harvesters[i].gotoheap();
        Specific.gotoheap();
    }
}