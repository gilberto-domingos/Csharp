namespace xMethods;

public class Potenciador
{
    public long Power(int baseNum, int expoent)
    {
        long result = 1;

        for (int i = 0; i < expoent; i++)
        {
            result *= baseNum;
        }

        return result;
    }
}