namespace HerancaServicos;

internal class ProductPromotional : Product
{
    private decimal _discount { get; }

    public ProductPromotional(string name, decimal price, decimal discount) : base(name, price)
    {
        _discount = discount;
    }

    public decimal CalculateDiscount()
    {
        return (decimal)Price *(1 - _discount);
    }

    public string DisplayInformation()
    {
        return $"Produto : {Name}, Preço : R${Price:F2}, Desconto de : {_discount:P0}, Com desconto : R${CalculateDiscount():F2}";
    }
}