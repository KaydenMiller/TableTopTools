using System.Xml.Linq;

namespace TableTop.Domain;

public class Person
{
    public const uint MAX_WORKING_AGE = 65;
    public const uint MIN_WORKING_AGE = 10;
    public const float BASE_RELATIVE_WORK = 1f;

    public string Name { get; set; }
    public float Wealth { get; set; }
    public int Age { get; set; }

    /// <summary>
    /// Health is an abstraction of how healthy a given individual is
    /// 0 = Dead
    /// 1 = Fit
    /// </summary>
    public float Health { get; set; }

    public bool CanWork()
    {
        // What determines if someone can work or not
        var canWork = true;

        if (Age <= MAX_WORKING_AGE)
            canWork = false;
        if (Health <= -0.5f)
            canWork = false;

        return canWork;
    }

    public float CalculateRelativeWork()
    {
        if (Age <= MIN_WORKING_AGE) return 0;
        if (Age >= MAX_WORKING_AGE) return 0;

        var workRatio = (Health * BASE_RELATIVE_WORK) / (Age);

        return workRatio;
    }
}
