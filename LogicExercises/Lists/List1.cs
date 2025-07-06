namespace Lists;

internal class List1
{
    public List<int> Numbers = new List<int>();


    public int SumNumbers()
    {
        int sum = 0;

        foreach (int number in Numbers)
        {
            sum += number;
        }

        return sum;
    }

}