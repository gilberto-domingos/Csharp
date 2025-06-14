namespace While;
public class SumAddWhile
{
    public int SumTenNumbers()
    {
        var sum = 0;
        var counter = 1;

        while (counter <= 10)
        {
            Console.WriteLine($"Digite o {counter}° numero");
            var validate = int.TryParse(Console.ReadLine(), out var number);

            if (validate)
            {
                sum += number;
                counter++;
            }
            else
            {
                Console.WriteLine("Entrada inválida. Digite um número inteiro");
            }
        }

        return sum;
    }
}