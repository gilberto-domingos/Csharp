namespace Polimorfismo;

public class Estagiario : Imposto
{
    public override void ValeAlimentacao(double salario)
    {
        Console.WriteLine("Desconto estagiario do vale alimentação R$" + (salario * 0.1));
    }
}