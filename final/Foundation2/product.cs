public class Product
{
    private string _name;
    private string _productID;
    private float _individualPrice;
    private float _totalPrice;
    private int _quantity;


    // References about the total and includes the id and information
    public Product(string name, string productID, float individualPrice, int quantity)
    {
        _name = name;
        _productID = productID;
        _individualPrice = individualPrice;
        _quantity = quantity;
        CalculateTotalPrice();
    }
    private void CalculateTotalPrice()
    {
        _totalPrice = _individualPrice * _quantity;
    }

//getters for the program.cs
   public float GetTotalPrice()
    {
        return _totalPrice;
    }
    
            public int GetQuantity()
    {
        return _quantity;
    }
    public string GetProductName()
    {
        return _name;
    }

    public string GetProductID()
    {
        return _productID;
    }
    public float GetIndividualPrice()
    {
        return _individualPrice;
    }


}