public class Palindrome
{
    public static bool isAlphaPalindrome(string code)
    {
        string filtered = new string(code
            .Where(char.IsLetter)
            .Select(char.ToLower)
            .ToArray());

        return filtered.SequenceEqual(filtered.Reverse());
    }
    
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite um palindromo");
        string input = Console.ReadLine();
        bool result = isAlphaPalindrome(input);
        Console.WriteLine(result ? 1 : 0);
    }
}