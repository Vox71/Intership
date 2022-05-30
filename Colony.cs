namespace Intership;

public class Colony
{
    public List<AntWarrior> Warriors;
    public List<AntHarvester> Harvesters;
    public AntQueen Queen;
    public AntSpecific Specific;
    public Colony(int HarversterCount, int WarriorsCount, int QHealth, int QDefence, string QAntname, int SHealth, int SDefence, string SAntname)
    {
        Harvesters = new List<AntHarvester>(HarversterCount);
        Warriors = new List<AntWarrior>(WarriorsCount);
        Queen = new AntQueen(QHealth, QDefence, QAntname);
        Specific = new AntSpecific(SHealth, SDefence, SAntname);
    }

    public void Info()
    {
        
    }

}