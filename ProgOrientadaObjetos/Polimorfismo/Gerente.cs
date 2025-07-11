namespace Polimorfismo;

public class Gerente : Imposto
{
    public override void ValeAlimentacao(double salario)
    {
        Console.WriteLine("Desconto gerente do vale alimentação R$" + (salario * 0.15));
    }
}