// 1- Escreva um programa para exibir os números de 1 até 50 na tela.

class SolveProblem
{
    public void printNumbers()
    {
        for (int i = 1; i <= 50; i++)
        {
            Console.WriteLine($"Número:{i}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        var solveProblem = new SolveProblem();
        solveProblem.printNumbers();
    }
}