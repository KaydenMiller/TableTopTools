namespace TableTop.Domain;

public interface IProducer 
{
    public IEnumerable<Product> Products { get; }
    public void Produce();
}

public interface IConsumer
{
    public IEnumerable<Product> Inputs { get; }
}

public interface IStorage
{
    public IInventory Storage { get; }
}

public record Product(IItem Item, uint Amount);