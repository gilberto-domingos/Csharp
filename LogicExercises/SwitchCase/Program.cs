using SwitchCase;

class Program
{
    static void Main()
    {

        var month = new MonthOfYear();

        Console.WriteLine("Enter a number from 1 to 12 to find out the corresponding month:");
        if (int.TryParse(Console.ReadLine(), out int numMonth))
        {
            string nameMonth = month.GetMonthName(numMonth);
            Console.WriteLine($"Result: {nameMonth}");
        }
        else
        {
            Console.WriteLine("Invalid input. Enter an integer from 1 to 12.");
        }

        var calc = new Calculator();

        Console.WriteLine("Enter the first number:");
        bool firstValid = double.TryParse(Console.ReadLine(), out double number1);

        Console.WriteLine("Enter the second number:");
        bool secondValid = double.TryParse(Console.ReadLine(), out double number2);

        Console.WriteLine("Enter the operator (+, -, *, /):");
        char op = Console.ReadKey().KeyChar;
        Console.WriteLine(); // Só para quebrar a linha

        if (firstValid && secondValid)
        {
            string result = calc.Calculate(number1, number2, op);
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Error: Invalid numeric input.");
        }

    }
}