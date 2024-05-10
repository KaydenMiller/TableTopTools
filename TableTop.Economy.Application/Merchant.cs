namespace TableTop.Economy.Application;

public interface IAi
{
    public void Main();
}

/// <summary>
/// Looks for deals to be made across all markets and trys to fulfill them to make profit
/// </summary>
public class Merchant : IAi
{
    public void Main()
    {
        // Look for all markets in range
        // Find any profitable trades
        // Trade
    }
}

/// <summary>
/// Consumes Goods, Produces Goods for Profit
/// </summary>
public class Capitalist : IAi
{
    public void Main()
    {
        // Check for required goods
        // Work on goods
        // Sell goods on market
    }
}

/// <summary>
/// Consumes Goods, Provides Workforce
/// </summary>
public class Laborer : IAi
{
    public float AvailableWork { get; set; }
    public float UtilizedWork { get; set; }
    public void Main()
    {
        // Check for required goods
        // Reduce or Increase AvailableWork
    }
}

