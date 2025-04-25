using Microsoft.Identity.Client;

namespace LaboratorioDeTestesAPI.Entities;

internal class Car
{
    public Guid Id { get; init; }
    public string Name { get; set; }

    public Car() { }

    public Car(Guid id, string name)
    {
        Id = id;
        Name = name;
    }

}