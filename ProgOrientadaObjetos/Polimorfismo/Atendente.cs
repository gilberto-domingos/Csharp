namespace Polimorfismo;

public class Atendente : Imposto
{
    public override void ValeAlimentacao(double salario)
    {
        Console.WriteLine("Desconto atendente do vale alimentação R$" + (salario * 0.12));
    }
}