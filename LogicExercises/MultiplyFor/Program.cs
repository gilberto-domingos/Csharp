class Program
{
    static void Main(string[] args)
    {
        try
        {
           Console.WriteLine("Digite um número inteiro para ver a tabuada.");
           string input = Console.ReadLine();

           bool validade = int.TryParse(input, out int number);

           if (validade)
           {
               for (int i = 0; i <= 10; i++)
               {
                   Console.WriteLine($"{number} x {i} = {number * i}");
               }
           }
           else
           {
               Console.WriteLine("Entrada invalida, digite um número inteiro.");
           }
        }
        catch (Exception ex)
        {
            throw new ArgumentException("Ocorreu um erro no sistema", ex.Message);
        }
    }
}