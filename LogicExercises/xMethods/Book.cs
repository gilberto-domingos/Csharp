namespace xMethods;

public class Book
{
    public string Title;
    public string Author;
    public int Year;

    public Book(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
    }

    public void ShowInformation()
    {
        Console.WriteLine($"O titulo do livro é {Title} do autor {Author} produzido no ano {Year}");
    }
}