namespace SwitchCase;

public class Calculator
{
    public string Calculate(double number1, double number2, char op)
    {
        switch (op)
        {
            case '+':
                return $"Result: {number1 + number2}";

            case '-':
                return $"Result: {number1 - number2}";

            case '*':
                return $"Result: {number1 * number2}";

            case '/':
                if (number2 == 0)
                    return "Error: Division by zero.";
                return $"Result: {number1 / number2}";

            default:
                return "Invalid operator.";
        }
    }
}