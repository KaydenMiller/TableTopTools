namespace TableTop.Domain;

public enum WealthClass
{
    Aristocratic,
    Upper,
    UpperMiddle,
    Middle,
    LowerMiddle,
    Lower,
    Homeless
}

public class Population
{
    public uint Total { get; }

    public Population(uint initialPopulation)
    {
        
    }
}