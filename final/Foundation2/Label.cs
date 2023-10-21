public class Order
{
    private List<Product> _products;
    private Customer _customer;
    private float _totalCost;
    private float _shippingCost;

    //calculate of the price of the products
    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;

        if (customer.GetIsFromUSA())
        {
            _shippingCost = 5;
        }
        else
        {
            _shippingCost = 35;
        }
        _products = products;
        CalculateTotalCostInMoney();

    }
    private void CalculateTotalCostInMoney()
    {
        _totalCost = _shippingCost;
        foreach(Product product in _products)
        {
            _totalCost += product.GetTotalPrice();
        }
    }
    public float GetTotalCosOfProducts()
    {
        return _totalCost;
    }
    // Return the name and adress inserted in program.Cs
    public string GetShipping()
    {
        return $"Client Name: {_customer.GetName()}\nClient Address:\n{_customer.GetAddress().GetFormattedLocation()}\n";
    }
    public string GetPacking()
    {
        string packingLabel = "";
        int cont = 1;
        foreach(Product product in _products)
        // The store Information About the products
        {
            packingLabel += $"Product N°{cont}:\n   Product Name: {product.GetProductName()}\n   Product ID in store: {product.GetProductID()}\n   Product Price: ${product.GetIndividualPrice()}\n   Product Quantity: {product.GetQuantity()}\n\n";
            cont += 1;
        }
        return packingLabel;
    }

}