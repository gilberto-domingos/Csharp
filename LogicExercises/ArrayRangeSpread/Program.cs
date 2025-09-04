class ArraysClass
{
    public IEnumerable<int> ReadSequence()
    {
        int[] numbers = { 1, 2, 3 };
        IEnumerable<int> moreNumbers = [..numbers, 4, 5, 6, 7, 8, 9, 10];

        return moreNumbers;
    }
}

class Program
{
    static void Main(string[] args)
    {
        ArraysClass arrays = new ArraysClass();

        foreach (var n in arrays.ReadSequence())
        {
            Console.WriteLine(n);
        }
    }
}