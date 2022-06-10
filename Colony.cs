namespace Intership;

public class Colony
{
    public List<AntWarrior> Warriors;
    public List<AntHarvester> Harvesters;
    public AntQueen Queen;
    public AntSpecific Specific;
    public string ColonyName;
    public Colony(int harvesterCount, int warriorsCount, int qHealth, int qDefence, string queenName, int qDamage, int sHealth, int sDefence, string sAntname, int sDamage, string sAttributes, string colonyName)
    {
        Harvesters = new List<AntHarvester>(harvesterCount);
        Warriors = new List<AntWarrior>(warriorsCount);
        Queen = new AntQueen(qHealth, qDefence, queenName, qDamage, colonyName);
        Specific = new AntSpecific(sHealth, sDefence, sAntname, sDamage, sAttributes, colonyName, queenName);
        ColonyName = colonyName;
    }

    public void Info()
    {
        Console.WriteLine($"Колонией {this.ColonyName} руководит королева по имени {Queen.Antname}");
        Console.WriteLine($"Колония содержит {Warriors.Count} воинов, {Harvesters.Count} рабочих, особое насекомое {Specific.Antname}");
    }
}