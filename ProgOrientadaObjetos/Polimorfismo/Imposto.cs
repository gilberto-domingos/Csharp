namespace Polimorfismo;

public class Imposto
{
    public virtual void ValeAlimentacao(double salario)
    {
       Console.WriteLine("Desconto padrão do vale alimentação R$" + (salario * 0.1));
       
    }

    public virtual void ValeTransporte(double salario)
    {
        Console.WriteLine("Desconto padrão do vale transporte R$" + (salario * 0.06));
    }
}