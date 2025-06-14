namespace For;

public class EvenNumbers
{
    public int ShowEvenNumbers()
    {
        int result = 0;

        for (int i = 0; i <= 100; i++)
        {
            if (i % 2 == 0)
            {
                result += i;
            }
        }
        return result;
    }
}