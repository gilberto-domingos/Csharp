using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Digite sua idade: ");
            string input = Console.ReadLine() ?? "";
            
            

            if (int.TryParse(input, out int age))
            {
                if (age < 0 || age > 150)
                {
                    Console.WriteLine("Idade inválida! Digite um valor entre 0 e 150.");
                    return;
                }
                
                string category = age switch
                {
                    < 18 => "Você é menor de idade",
                    >= 18 and < 60 => "Você é maior de idade",
                    >= 60 => "Você é idoso"
                };

                Console.WriteLine(category);
            }
            else
            {
                Console.WriteLine("Entrada inválida! Digite apenas números inteiros.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocorreu um erro inesperado: {ex.Message}");
        }
    }
}