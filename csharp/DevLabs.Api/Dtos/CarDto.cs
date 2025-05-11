using System.ComponentModel.DataAnnotations;

namespace LaboratorioDeTestes.Dtos


{
    public sealed record CarDto(Guid Id, string Name, int Chassi);
}