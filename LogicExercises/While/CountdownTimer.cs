namespace While;
public class CountdownTimer
{
    public int Timer()
    {
        int counter = 10;
        int result = 0;

        while (counter > 0)
        {
            Console.WriteLine(counter);
            counter--;
        }

        return result;
    }
}