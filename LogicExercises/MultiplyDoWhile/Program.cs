class Program
{
    static void Main(string[] args)
    {
        try
        {
           Console.WriteLine("Digite um número inteiro para ver a tabuada.");
           string input = Console.ReadLine();

           bool validate = int.TryParse(input, out int number);

           if (validate)
           {
               int i = 1;
               do
               {
                   Console.WriteLine($"{number} x {i} = {number * i}");
                   i++;
               } while (i <= 10);
           }
           else
           {
               Console.WriteLine("Entrada inválida, digite um número inteiro");
           }
        }
        catch (Exception ex)
        {
            throw new ArgumentException("Ocorreu um erro no sistemaa", ex.Message);
        }
    }
}