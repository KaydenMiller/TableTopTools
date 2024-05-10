using ErrorOr;

namespace TableTop.Domain;

public interface IInventory
{
    public void AddProduct(Product product);
    public ErrorOr<Product> RemoveProduct(Product product);
    public bool ContainsProduct(Product product);
}

public class Inventory : IInventory
{
    public Dictionary<string, Product> StoredProducts { get; } = [];

    public void AddProduct(Product product)
    {
        if (StoredProducts.ContainsKey(product.Item.Name))
        {
            // We have some product
            var currentProduct = StoredProducts[product.Item.Name];
            StoredProducts[product.Item.Name] = currentProduct with
            {
                Amount = currentProduct.Amount + product.Amount
            };
        }
        else
        {
            StoredProducts.Add(product.Item.Name, product);
        }
    }

    public bool ContainsProduct(Product product)
    {
        return StoredProducts.ContainsKey(product.Item.Name) &&
               StoredProducts[product.Item.Name].Amount >= product.Amount;
    }

    public ErrorOr<Product> RemoveProduct(Product product)
    {
        if (StoredProducts.ContainsKey(product.Item.Name))
        {
            // We have at least some of this product
            var currentProduct = StoredProducts[product.Item.Name];
            if (currentProduct.Amount >= product.Amount)
            {
                // we can remove this much product
                if (currentProduct.Amount == product.Amount)
                {
                    // there is no product remaining
                    StoredProducts.Remove(product.Item.Name);
                    return product;
                }
                
                StoredProducts[product.Item.Name] = currentProduct with
                {
                    Amount = currentProduct.Amount - product.Amount
                };
                return product;
            }

            return Error.Conflict("Missing.Product.NotSufficient");
        }
        else
        {
            // This inventory does not contain this product
            return Error.Conflict("Missing.Product.Empty");
        }
    }
}