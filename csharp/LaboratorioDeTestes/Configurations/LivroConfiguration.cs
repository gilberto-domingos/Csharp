using LaboratorioDeTestes.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LaboratorioDeTestes.Configurations
{
    public class LivroConfiguration : IEntityTypeConfiguration<Livro>
    {
        public void Configure(EntityTypeBuilder<Livro> builder)
        {
            builder.HasKey(key => key.IdLivro);
            builder.Property(livro => livro.Titulo).IsRequired().HasMaxLength(200);
        }
    }
}
