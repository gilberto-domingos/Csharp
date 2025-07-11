namespace Polimorfismo;

internal class Estagiario1 : Funcionario
{
    public Estagiario1(string nome) : base(nome){}

    public override decimal CalcularSalario()
    {
        return 1200;
    }
}