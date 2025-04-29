using System.ComponentModel.DataAnnotations;

namespace LaboratorioDeTestesAPI.Dtos


{
    public sealed record CarDto(Guid Id, string Name, int Chassi);
}