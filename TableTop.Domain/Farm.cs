using TableTop.Domain.Items;

namespace TableTop.Domain;

public class Farm : IProducer, IConsumer, IStorage
{
    public IEnumerable<Product> Products { get; }
    public IEnumerable<Product> Inputs { get; }
    public IInventory Storage { get; }

    public Farm(Crop crop, uint produced, Seed seed, uint consumed)
    {
        Inputs = [
            new Product(seed, consumed)
        ];
        Products = [
            new Product(crop, produced),
            new Product(seed, produced)
        ];
    }

    private bool CanProduce()
    {
        return Inputs.All(Storage.ContainsProduct);
    }

    public void Produce()
    {
        if (CanProduce())
        {
            var productsProduced = ConsumeAndProduce();
            foreach (var product in productsProduced)
            {
                Storage.AddProduct(product);
            }
        }
        else
        {
            // Increase Desperation for inputs
            // return Error.Conflict("Missing.Product.NotSufficient");
        }
    }

    private IEnumerable<Product> ConsumeAndProduce()
    {
        foreach (var input in Inputs)
        {
            Storage.RemoveProduct(input);
        }

        return Products;
    }

}