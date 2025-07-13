namespace ServicosHeranca;

internal class People
{
    private string _name;
    private int _age;

    public string Name
    {
        get => _name;
        set => _name = value;
    }

    public int Age
    {
        get => _age;
        set => _age = value;
    }

    public People(string name, int age)
    {
        _name = name;
        _age = age;
    }
}