namespace ServicosHeranca;

internal class Student : People
{
    private long _registration { get;}

    public Student(string name, int age, int registration) : base(name, age)
    {
        _registration = registration;
    }

    public string DisplayInformation()
    {
        return $"Nome : {Name}, Idade : {Age}, Matricula : {_registration}";
    }
}