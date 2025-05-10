using LaboratorioDeTestes.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LaboratorioDeTestes.Configurations
{
    public class AutorConfiguration : IEntityTypeConfiguration<Autor>
    {
        public void Configure(EntityTypeBuilder<Autor> autorBuilder)
        {
            autorBuilder.HasKey(key => key.IdAutor);

            autorBuilder.Property(autor => autor.Nome)
                        .IsRequired()
                        .HasMaxLength(100);

            autorBuilder.Property(autor => autor.Sobrenome)
                        .IsRequired()
                        .HasMaxLength(100);

            autorBuilder.HasMany(autor => autor.Livros)
                        .WithOne(livro => livro.Autor)
                        .HasForeignKey(livro => livro.IdAutor)
                        .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
