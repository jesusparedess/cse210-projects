public class Order
{
    private List<Product> products = new List<Product>();
    private Customer customer;
    private const double ShippingCostUSA = 5.0;
    private const double ShippingCostInternational = 35.0;

    public Order(Customer customer)
    {
        this.customer = customer;
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public double CalculateTotalCost()
    {
        double totalCost = products.Sum(p => p.GetTotalCost());
        double shippingCost = customer.IsInUSA() ? ShippingCostUSA : ShippingCostInternational;
        return totalCost + shippingCost;
    }

    public string GetPackingLabel()
    {
        var label = "Packing Label:\n";
        foreach (var product in products)
        {
            label += $"{product.Name} (ID: {product.ProductId})\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{customer.Name}\n{customer.Address.GetFullAddress()}";
    }
}