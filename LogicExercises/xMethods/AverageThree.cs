namespace xMethods;

public class AverageThree
{
    public double Average(double number1, double number2, double number3)
    {
      var totalAverage = (number1 + number2 + number3) / 3.0;
      
      return totalAverage;
    }
}