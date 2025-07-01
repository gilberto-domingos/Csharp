using System;
using System.Globalization;
using PropertiesEncap;

class Program
{
    static void Main()
    {
        Student gradeStudent1 = new Student();
        
        Console.Write("Digite o nome do aluno:");
        gradeStudent1.Name = Console.ReadLine();
        
        Console.Write("Digite a nota do aluno (0 a 10): ");
        gradeStudent1.Grade = double.Parse(Console.ReadLine());

        try
        {
            //User user1 = new User("i9u90u9u09u*8");
            User user1 = new User("i*8");
            Console.WriteLine(user1.Password);
        }
        catch(InvalidOperationException ex)
        {
           Console.WriteLine($"Erro: {ex.Message}"); 
        }

    Employee emp1 = new Employee();
    Console.WriteLine("Digite o salário :");
    emp1.Salary = double.Parse(Console.ReadLine());
    
    Console.WriteLine($"Salário bruto: {emp1.SalaryFormatted}");

    }

}