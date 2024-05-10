namespace TableTop.Domain;

public class Market
{
    public List<BuyOrder> BuyOrders { get; } = [];
    public List<SellOrder> SellOrders { get; } = [];
}

public class BuyOrder
{
    public Guid OrderId { get; set; }
    /// <summary>
    /// The item being purchased
    /// </summary>
    public IItem Item { get; set; }
    public float PricePointPerUnit { get; set; }
    /// <summary>
    /// This is the quantity requested
    /// </summary>
    public uint Quantity { get; set; }
}

public class SellOrder
{
    public Guid OrderId { get; set; }
    /// <summary>
    /// The item being sold
    /// </summary>
    public IItem Item { get; set; }
    public float PricePointPerUnit { get; set; }
    /// <summary>
    /// This is the quantity offered
    /// </summary>
    public uint Quantity { get; set; }
}