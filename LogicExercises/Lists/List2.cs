namespace Lists;

internal class List2
{
    public List<string> Names = new List<string>();

    public void checkName()
    {
        foreach (string name in Names)
        {
            if (name == "fim")
            {
                Console.WriteLine($"Os nomes da lista são {string.Join(", ",Names)}");
            }
        }
            
    }
}