/*3- Escreva um algoritmo para ler uma quantidade indeterminada de números
    inteiros e positivos até que seja digitado o valor -1. Quando isso
    acontecer, seu programa deve imprimir quantos dos números digitados
    são pares e quantos são ímpares.*/


class SolvingProblem
{
    public int numberx { get; set; }
    public List<int> numbers = new List<int>();
    public List<int> evenNumbers = new List<int>();
    public List<int> oddNumbers = new List<int>();

    public void ReceiveNumber()
    {
        do
        {
            Console.WriteLine("Digite o numero e pressione enter");
            numberx = int.Parse(Console.ReadLine());

            if (numberx != -1)
            {
                numbers.Add(numberx);
            }

        }
        while (numberx != -1);

        foreach (int number in numbers)
        {
            if (number % 2 == 0)
            {
                evenNumbers.Add(number);
            }
            else
            {
                oddNumbers.Add(number);
            }
        }

        Console.WriteLine($"Total de números pares: {evenNumbers.Count}");
        Console.WriteLine($"Total de números impares: {oddNumbers.Count}");
    }
}



class Program
{
    static void Main(string[] args)
    {
        var obj = new SolvingProblem();
        obj.ReceiveNumber();
    }
}