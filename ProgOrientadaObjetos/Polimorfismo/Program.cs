namespace Polimorfismo;

class Program
{
    static void Main(string[] args)
    {
        List<Funcionario> funcionarios = new List<Funcionario>
        {
            new Gerente1("Joao"),
            new Vendedor("Maria"),
            new Estagiario1("Roberto")
        };

        foreach (Funcionario funcionario in funcionarios)
        {
            Console.WriteLine($"{funcionario.Nome} - Salario: R${funcionario.CalcularSalario(): 0.00}");
        }
        
        //--------------------------------------------------------//

         List<Figura> figuras = new List<Figura>();
         figuras.Add(new Quadrado());
         figuras.Add(new Circulo());
         figuras.Add(new Triangulo());
        
         foreach (Figura figura in figuras)
         {
             figura.Desenhar();
         }
         
         //--------------------------------------------------------//

         List<Animal> animais = new List<Animal>();
         animais.Add(new Cachorro());
         animais.Add(new Gato());
         animais.Add(new Vaca());
        
         foreach (Animal animal in animais)
         {
             animal.Falar();
         }

        //--------------------------------------------------------//
         Imposto objEst = new Estagiario();
         objEst.ValeAlimentacao(1000);
         objEst.ValeTransporte(1000);
         Console.WriteLine("---------------------------------------------");
        
         Imposto objGer = new Gerente();
         objGer.ValeAlimentacao(5000);
         objGer.ValeAlimentacao(5000);
         Console.WriteLine("--------------------------------------------");
        
         Imposto objAten = new Atendente();
         objAten.ValeAlimentacao(2000);
         objAten.ValeAlimentacao(2000);
         Console.WriteLine("-------------------------------------------");
    }
}