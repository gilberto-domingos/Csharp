using System.ComponentModel.DataAnnotations;

namespace LaboratorioDeTestesAPI.Dtos
{
    public sealed record CarDto
    {
        public Guid Id { get; init; }

        [Required]
        [StringLength(100)]
        public required string Name { get; init; }

        [Required]
        public required int Chassi { get; init; }
    }
}
