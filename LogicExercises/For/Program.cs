namespace For;

internal class Program
{
    public static void Main(string[] args)
    { 
        var sumAdd = new SumAddFor();
        Console.WriteLine("Soma de dez números inteiros");
        int result = sumAdd.SumTenNumbers();
        Console.WriteLine($"Resultado da soma {result}"); 

        var evenNumber = new EvenNumbers();
        Console.WriteLine("Mostra todos os numeros pares de 1 até 100");
        int result2 = evenNumber.ShowEvenNumbers();
        Console.WriteLine(result2); 
        
        
        var checker = new PrimeChecker();
        Console.WriteLine("Digite um número para verificar se é primo:");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            bool isPrime = checker.IsPrime(number);

            if (isPrime)
                Console.WriteLine($"{number} é um número primo.");
            else
                Console.WriteLine($"{number} não é um número primo.");
        }
        else
        {
            Console.WriteLine("Entrada inválida. Digite um número inteiro.");
        }
    }
}