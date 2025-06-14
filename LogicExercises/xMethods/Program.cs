namespace xMethods;

internal class Program
{
    public static void Main(string[] args)
    {
        var calcc = new Potenciador();

        Console.WriteLine("Digite a base (número inteiro):");
        bool baseValidate = int.TryParse(Console.ReadLine(), out int baseNum);

        Console.WriteLine("Digite o expoente (número inteiro >= 0):");
        bool expoenteValidate = int.TryParse(Console.ReadLine(), out int expoente);

        if (baseValidate && expoenteValidate && expoente >= 0)
        {
            long resultado = calcc.Power(baseNum, expoente);
            Console.WriteLine($"{baseNum}^{expoente} = {resultado}");
        }
        else
        {
            Console.WriteLine("Erro: Entrada inválida. Use números inteiros e expoente ≥ 0.");
        }

        var calc = new FatorialCalculator();

        Console.WriteLine("\nDigite um número inteiro para calcular o fatorial:");
        bool valido = int.TryParse(Console.ReadLine(), out int numero);

        if (valido && numero >= 0)
        {
            long resultado = calc.Fatorial(numero);
            Console.WriteLine($"O fatorial de {numero} é: {resultado}");
        }
        else
        {
            Console.WriteLine("Erro: Digite um número inteiro positivo ou zero.");
        }

        var converter = new TempConverter();

        Console.WriteLine("\nDigite a temperatura em Celsius para converter em Fahrenheit:");
        bool validateTemp = double.TryParse(Console.ReadLine(), out double celsius);

        if (validateTemp)
        {
            double fahrenheit = converter.ConverterToFareheint(celsius);
            Console.WriteLine($"A temperatura em Fahrenheit é: {fahrenheit:F1} °F");
        }
        else
        {
            Console.WriteLine("Erro: Entrada inválida, digite um número real.");
        }

        var evenNumber = new EvenNumber();

        Console.WriteLine("\nDigite um número:");
        bool validateN = int.TryParse(Console.ReadLine(), out int numberx);

        if (validateN)
        {
            bool result = evenNumber.IsEven(numberx);
            string message = result ? "O número é par." : "O número é ímpar.";
            Console.WriteLine(message);
        }
        else
        {
            Console.WriteLine("Erro: Entrada inválida, digite um número inteiro.");
        }

        var comparer = new Comparer();

        Console.WriteLine("\nDigite o primeiro número:");
        bool validateA = int.TryParse(Console.ReadLine(), out int a);

        Console.WriteLine("Digite o segundo número:");
        bool validateB = int.TryParse(Console.ReadLine(), out int b);

        if (validateA && validateB)
        {
            int largestNumber = comparer.GreaterNumber(a, b);
            Console.WriteLine($"O número maior é: {largestNumber}");
        }
        else
        {
            Console.WriteLine("Erro: Entrada inválida para comparação.");
        }

        var calculator = new AverageThree();

        Console.WriteLine("\nDigite o primeiro número:");
        bool validateNum1 = double.TryParse(Console.ReadLine(), out double number1);

        Console.WriteLine("Digite o segundo número:");
        bool validateNum2 = double.TryParse(Console.ReadLine(), out double number2);

        Console.WriteLine("Digite o terceiro número:");
        bool validateNum3 = double.TryParse(Console.ReadLine(), out double number3);

        if (validateNum1 && validateNum2 && validateNum3)
        {
            double result = calculator.Average(number1, number2, number3);
            Console.WriteLine($"A média aritmética é: {result:F1}");
        }
        else
        {
            Console.WriteLine("Entrada numérica inválida - 0.0");
        }
    }
}
