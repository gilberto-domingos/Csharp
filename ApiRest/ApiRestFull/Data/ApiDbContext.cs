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

            base.OnModelCreating(modelBuilder);
        }


        public static void Initialize(IServiceProvider serviceProvider, ApiDbContext context)
        {
            context.Database.EnsureCreated();

            if (!context.Autores.Any())
            {
                // Populando as tabelas na inicialização para teste dos end-points
                context.Autores.AddRange(
                    new AutorModel { IdAutor = Guid.NewGuid(), Nome = "Machado", Sobrenome = "de Assis" },
                    new AutorModel { IdAutor = Guid.NewGuid(), Nome = "Clarice", Sobrenome = "Lispector" },
                    new AutorModel { IdAutor = Guid.NewGuid(), Nome = "Jorge", Sobrenome = "Amado" },
                    new AutorModel { IdAutor = Guid.NewGuid(), Nome = "Cecília", Sobrenome = "Meireles" },
                    new AutorModel { IdAutor = Guid.NewGuid(), Nome = "Carlos", Sobrenome = "Drummond" }
                );

                context.SaveChanges();
            }

            if (!context.Livros.Any())
            {
                var autores = context.Autores.ToList();

                context.Livros.AddRange(
                    new LivroModel { IdLivro = Guid.NewGuid(), Titulo = "Memórias", IdAutor = autores[0].IdAutor },
                    new LivroModel { IdLivro = Guid.NewGuid(), Titulo = "Hora Estrelar", IdAutor = autores[1].IdAutor },
                    new LivroModel { IdLivro = Guid.NewGuid(), Titulo = "Capitães", IdAutor = autores[2].IdAutor },
                    new LivroModel { IdLivro = Guid.NewGuid(), Titulo = "Passaredo", IdAutor = autores[3].IdAutor },
                    new LivroModel { IdLivro = Guid.NewGuid(), Titulo = "Alguma Poesia", IdAutor = autores[4].IdAutor }
                );

                context.SaveChanges();
            }
        }
    }
}
