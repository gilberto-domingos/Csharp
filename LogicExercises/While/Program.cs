namespace While;

internal class Program
{
    public static void Main(string[] args)
    {
        var regresCounter = new CountdownTimer();
        regresCounter.Timer();
        Console.WriteLine("Contagem regressiva de 10 até 1");
        Console.WriteLine(regresCounter.Timer());


        var sumAdd = new SumAddWhile();
        Console.WriteLine("Soma de 10 números inteiros");
        var result = sumAdd.SumTenNumbers();
        Console.WriteLine($"Resultado da soma: {result}");
    }
}