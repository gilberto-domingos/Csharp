namespace DevLabs.Api.Entities;


public class Car
{
    public Guid Id { get; init; }
    public string Name { get; init; } = string.Empty;
    public int Chassi { get; init; }

    public Car() { }

    public Car(Guid id, string name)
    {
        Id = id;
        Name = name;
    }

    public Car(Guid id, string name, int chassi)
    {
        Id = id;
        Name = name;
        Chassi = chassi;
    }


}
