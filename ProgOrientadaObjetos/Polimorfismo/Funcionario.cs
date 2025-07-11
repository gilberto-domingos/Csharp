namespace Polimorfismo;

internal class Funcionario
{
    private string _nome;

    public string Nome
    {
        get => _nome;
        set => _nome = value;
    }

    public Funcionario(string nome)
    {
        _nome = nome;
    }

    public virtual decimal CalcularSalario()
    {
        return 0;
    }
}