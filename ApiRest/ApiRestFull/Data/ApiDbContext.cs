using Microsoft.EntityFrameworkCore;
using ApiRestFull.Models;

namespace ApiRestFull.Data
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options) { }

        public DbSet<AutorModel> Autores { get; set; }
        public DbSet<LivroModel> Livros { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LivroModel>()
                .HasOne(livro => livro.Autor)
                .WithMany(autor => autor.Livros)
                .HasForeignKey(livro => livro.IdAutor)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<AutorModel>().HasData(
                new AutorModel { IdAutor = 1, Nome = "Machado", Sobrenome = "de Assis" },
                new AutorModel { IdAutor = 2, Nome = "Clarice", Sobrenome = "Lispector" },
                new AutorModel { IdAutor = 3, Nome = "Jorge", Sobrenome = "Amado" },
                new AutorModel { IdAutor = 4, Nome = "Cecília", Sobrenome = "Meireles" },
                new AutorModel { IdAutor = 5, Nome = "Carlos", Sobrenome = "Drummond de Andrade" }
            );

            modelBuilder.Entity<LivroModel>().HasData(
                new LivroModel { IdLivro = 1, Titulo = "Memórias Póstumas de Brás Cubas", IdAutor = 1 },
                new LivroModel { IdLivro = 2, Titulo = "A Hora da Estrela", IdAutor = 2 },
                new LivroModel { IdLivro = 3, Titulo = "Capitães da Areia", IdAutor = 3 },
                new LivroModel { IdLivro = 4, Titulo = "Passaredo", IdAutor = 4 },
                new LivroModel { IdLivro = 5, Titulo = "Alguma Poesia", IdAutor = 5 }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}
