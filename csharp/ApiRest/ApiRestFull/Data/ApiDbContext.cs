using Microsoft.EntityFrameworkCore;
using ApiRestFull.Entities;

namespace ApiRestFull.Data
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options) { }

        public DbSet<Autor> Autores { get; set; }
        public DbSet<Livro> Livros { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApiDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }


        public static void Initialize(IServiceProvider serviceProvider, ApiDbContext context)
        {
            context.Database.EnsureCreated();

            if (!context.Autores.Any())
            {
                // Populando as tabelas na inicialização para teste dos end-points
                context.Autores.AddRange(
                    new Autor { IdAutor = Guid.NewGuid(), Nome = "Machado", Sobrenome = "de Assis" },
                    new Autor { IdAutor = Guid.NewGuid(), Nome = "Clarice", Sobrenome = "Lispector" },
                    new Autor { IdAutor = Guid.NewGuid(), Nome = "Jorge", Sobrenome = "Amado" },
                    new Autor { IdAutor = Guid.NewGuid(), Nome = "Cecília", Sobrenome = "Meireles" },
                    new Autor { IdAutor = Guid.NewGuid(), Nome = "Carlos", Sobrenome = "Drummond" }
                );

                context.SaveChanges();
            }

            if (!context.Livros.Any())
            {
                var autores = context.Autores.ToList();

                context.Livros.AddRange(
    new Livro { IdLivro = Guid.NewGuid(), Titulo = "Memórias", IdAutor = autores[0].IdAutor, Autor = autores[0] },
    new Livro { IdLivro = Guid.NewGuid(), Titulo = "Hora Estrelar", IdAutor = autores[1].IdAutor, Autor = autores[1] },
    new Livro { IdLivro = Guid.NewGuid(), Titulo = "Capitães", IdAutor = autores[2].IdAutor, Autor = autores[2] },
    new Livro { IdLivro = Guid.NewGuid(), Titulo = "Passaredo", IdAutor = autores[3].IdAutor, Autor = autores[3] },
    new Livro { IdLivro = Guid.NewGuid(), Titulo = "Alguma Poesia", IdAutor = autores[4].IdAutor, Autor = autores[4] }
);

                context.SaveChanges();
            }
        }
    }
}
