using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ApiRestFull.Models;

namespace ApiRestFull.Configurations
{
    public class LivroConfiguration : IEntityTypeConfiguration<LivroModel>
    {
        public void Configure(EntityTypeBuilder<LivroModel> builder)
        {
            builder.HasKey(key => key.IdLivro);
            builder.Property(livro => livro.Titulo).IsRequired().HasMaxLength(200);
        }
    }
}
