using System.ComponentModel.DataAnnotations;

namespace LaboratorioDeTestesAPI.Entities
{
    public class Car
    {
        [Key]
        public Guid Id { get; set; }

    }
}
