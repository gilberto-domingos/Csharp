using LaboratorioDeTestes.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LaboratorioDeTestes.Configurations;

internal class CarConfiguration : IEntityTypeConfiguration<Car>
{
    public void Configure(EntityTypeBuilder<Car> builder)
    {
        builder.ToTable("Cars");
        builder.HasKey(key => key.Id);
        builder.Property(car => car.Id).ValueGeneratedNever();
        builder.Property(car => car.Id).HasMaxLength(50);
        builder.Property(car => car.Name);
        builder.Property(car => car.Chassi);



        builder.HasData(
         new Car(Guid.Parse("11111111-1111-1111-1111-111111111111"), "Ferrari 488 GTB", 123456),
         new Car(Guid.Parse("22222222-2222-2222-2222-222222222222"), "Lamborghini Aventador", 234567),
         new Car(Guid.Parse("33333333-3333-3333-3333-333333333333"), "Porsche 911 Turbo", 345678),
         new Car(Guid.Parse("44444444-4444-4444-4444-444444444444"), "BMW M5 Competition", 456789),
         new Car(Guid.Parse("55555555-5555-5555-5555-555555555555"), "Audi R8 V10", 567890)
      );

    }
}