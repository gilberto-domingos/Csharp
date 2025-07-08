namespace HerancaServicos;

internal class ProductService
{
    private readonly List<ProductPromotional> _productPromotionals = new List<ProductPromotional>();

    public void AddProductPromotional(ProductPromotional productPromotional)
    {
        _productPromotionals.Add(productPromotional);
    }

    public List<ProductPromotional> GetAllProductPromotional()
    {
        return _productPromotionals;
    }
}