namespace For;

public class PrimeChecker
{
    public bool IsPrime(int number)
    {
        if (number <= 1)
            return false;

        int divisorCount = 0;

        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                divisorCount++;
            }
        }

        return divisorCount == 2;
    }
}