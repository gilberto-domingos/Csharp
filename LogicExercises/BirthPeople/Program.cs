/* 5- Faça um programa que receba o ano de nascimento de 10 pessoas e
mostre quantas são maiores que 18 anos. Valide a entrada e permita a
digitação de um novo ano se for o caso. */

using System.Globalization;

class SolveProblem
{
    public DateTime Birthx { get; set; }
    public List<DateTime> Births = new List<DateTime>();


    public void receiveDates()
    {
        while (true)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite a data de nascimento (ou ENTER vazio para encerrar)");
                string date = Console.ReadLine();
           
                if(string.IsNullOrWhiteSpace(date))
                    break;

                DateTime tempBirth;
                bool isValid = DateTime.TryParseExact(date,
                    "dd/MM/yyyy",
                    new CultureInfo("pt-BR"),
                    DateTimeStyles.None,
                    out tempBirth);
                
                if (isValid)
                {
                    Birthx = tempBirth;
                    Births.Add(Birthx);
                    Console.WriteLine($"Data registrada: {Birthx:dd/MM/yyyy}");
                }
                else
                {
                    Console.WriteLine("Data inválida! Digite novamente no formato dd/MM/yyyy.");
                }
                
                foreach (DateTime birth in Births)
                {
                    Console.WriteLine(birth);
                    int age = CalculateAge(birth);
                    string status = age >= 18 ? "Maior de 18 anos" : "Menor de 18 anos";

                    Console.WriteLine($"{birth:dd/MM/yyyy} - {age} anos - {status}");
                }
            }
        } 
    }
    int CalculateAge(DateTime birthDate)
    {
        DateTime today = DateTime.Today;
        int age = today.Year - birthDate.Year;
        if (birthDate > today.AddYears(-age)) age--; 
        return age;
    }
}

class Program
{
    static void Main(string[] args)
    {
        var birthPeople = new SolveProblem();
        birthPeople.receiveDates();
    }
}