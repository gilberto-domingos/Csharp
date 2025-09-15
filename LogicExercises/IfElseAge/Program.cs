using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Digite sua idade :");
           // string input = Console.ReadLine();     // discutir com prof. validação
           // bool validate = int.TryParse(input, out int age);

            if (int.TryParse(Console.ReadLine(), out int age))
            {
                if (age < 18)
                {
                    Console.WriteLine("Você é menor de idade.");
                }
                else if (age >= 18 && age < 60)
                {
                    Console.WriteLine("Você é maior de idade.");
                }
                else
                {
                    Console.WriteLine("Você é idoso.");
                }
            }
        }
        catch (Exception ex)
        {
            throw new ArgumentException($"Entrada inválida, digite um número inteiro. {ex.Message}");
        }
    }
}


// Acima o codigo foi refatorado com melhorias 
/*
 class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite sua idade: ");

        int idade = int.Parse(Console.ReadLine());

        if (idade < 18)
        {
            Console.WriteLine("Você é menor de idade.");
        }
        else if (idade >= 18 && idade < 60)
        {
            Console.WriteLine("Você é maior de idade.");
        }
        else
        {
            Console.WriteLine("Você é idoso.");
        }
    }
}*/