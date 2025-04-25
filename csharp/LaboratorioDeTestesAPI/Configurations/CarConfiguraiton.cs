using LaboratorioDeTestesAPI.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LaboratorioDeTestesAPI.Configurations;

internal class CarConfiguration : IEntityTypeConfiguration<Car>
{
    public void Configure(EntityTypeBuilder<Car> builder)
    {
        builder.ToTable("Cars");
        builder.HasKey(key => key.Id);
        builder.Property(car => car.Id).ValueGeneratedNever();
        builder.Property(car => car.Id).HasMaxLength(50);


        builder.HasData(
            new Car(new Guid("11111111-1111-1111-1111-111111111111"), "Fusca"),
            new Car(new Guid("22222222-2222-2222-2222-222222222222"), "Gol"),
            new Car(new Guid("33333333-3333-3333-3333-333333333333"), "Civic"),
            new Car(new Guid("44444444-4444-4444-4444-444444444444"), "Corolla"),
            new Car(new Guid("55555555-5555-5555-5555-555555555555"), "Uno"),
            new Car(new Guid("66666666-6666-6666-6666-666666666666"), "Palio"),
            new Car(new Guid("77777777-7777-7777-7777-777777777777"), "HB20"),
            new Car(new Guid("88888888-8888-8888-8888-888888888888"), "Onix"),
            new Car(new Guid("99999999-9999-9999-9999-999999999999"), "Cruze"),
            new Car(new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), "Fiesta")
        );
    }
}