namespace Intership;

public class Colony
{
    public List<AntWarrior> Warriors;
    public List<AntHarvester> Harvesters;
    public AntQueen Queen;
    public AntSpecific Specific;
    public int stash;
    public Colony(int HarversterCount, int WarriorsCount, int QHealth, int QDefence, string QAntname, int QDamage, int SHealth, int SDefence, string SAntname)
    {
        Harvesters = new List<AntHarvester>(HarversterCount);
        Warriors = new List<AntWarrior>(WarriorsCount);
        Queen = new AntQueen(QHealth, QDefence, QAntname, QDamage);
        Specific = new AntSpecific(SHealth, SDefence, SAntname);
    }

    public void Info()
    {
        
    }



}