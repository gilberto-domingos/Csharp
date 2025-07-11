namespace Polimorfismo;

internal class Vendedor : Funcionario
{
    private decimal _salarioBase = 2000;
    private decimal _totalVendas = 10000;

    public decimal SalarioBase
    {
        get => _salarioBase;
        set => _salarioBase = value;
    }

    public decimal TotalVendas
    {
        get => _totalVendas;
        set => _totalVendas = value;
    }
    
    public Vendedor(string nome): base(nome){}

    public override decimal CalcularSalario()
    {
        return SalarioBase + (TotalVendas * 0.10m);
    }
}