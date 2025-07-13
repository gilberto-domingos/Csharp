namespace ServicosHeranca;

internal class Product
{
    private string _name;
    private decimal _price;

    public string Name
    {
        get => _name;
        set => _name = value;
    }

    public decimal Price
    {
        get => _price;
        set => _price = value;
    }

    public Product(string name, decimal price)
    {
        _name = name;
        _price = price; 
    }
}