using System.Globalization;

namespace PropertiesEncap;

public class Employee
{
    private double _salary;

    public double Salary
    {
        get => _salary;
        set => _salary = value <= 0 ? throw new InvalidOperationException("Valor não pode ser negativo !") : value;
    }
    public string SalaryFormatted => _salary.ToString("C", CultureInfo.GetCultureInfo("pt-BR"));
}