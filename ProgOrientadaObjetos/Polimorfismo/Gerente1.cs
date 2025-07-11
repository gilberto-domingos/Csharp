namespace Polimorfismo;

internal class Gerente1 : Funcionario
{
    private decimal _salarioBase = 5000;
    private decimal _bonus = 2000;
    
    public Gerente1(string Nome) : base(Nome){}

    public override decimal CalcularSalario()
    {
        return _salarioBase + _bonus;
    }
}