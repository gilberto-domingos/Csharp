// https://learn.microsoft.com/pt-br/dotnet/csharp/programming-guide/classes-and-structs/using-properties

namespace PropertiesEncap;

public class Student
{
    private string _name = string.Empty;
    private double _grade;

    public string Name
    {
        get => _name;
        set => _name = value;
    }

    public double Grade
    {
        get => _grade;
        set
        {
            if ((value <= 0) || (value >= 10))
                throw new InvalidOperationException("Nota invalida precisa ser entre 0 e 10");
            
            _grade = value;
        }
            
    }
}
