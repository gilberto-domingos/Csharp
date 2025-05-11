using System.ComponentModel.DataAnnotations;

namespace DevLabs.Api.Dtos


{
    public sealed record CarDto(Guid Id, string Name, int Chassi);
}