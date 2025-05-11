using DevLabs.Api.Data;
using DevLabs.Api.Entities;
using Microsoft.Extensions.Logging;

public class DataSeeder : IDataSeeder
{
    public async Task SeedAsync(ApiDbContext context, ILogger logger)
    {
        if (!context.Autores.Any())
        {
            var autores = new List<Autor>
            {
                new Autor { IdAutor = Guid.NewGuid(), Nome = "Machado", Sobrenome = "de Assis" },
                new Autor { IdAutor = Guid.NewGuid(), Nome = "Clarice", Sobrenome = "Lispector" },
                new Autor { IdAutor = Guid.NewGuid(), Nome = "Jorge", Sobrenome = "Amado" },
                new Autor { IdAutor = Guid.NewGuid(), Nome = "Cecília", Sobrenome = "Meireles" },
                new Autor { IdAutor = Guid.NewGuid(), Nome = "Carlos", Sobrenome = "Drummond" }
            };

            context.Autores.AddRange(autores);
            await context.SaveChangesAsync();
            logger.LogInformation("Autores inseridos.");
        }

        if (!context.Livros.Any())
        {
            var autores = context.Autores.ToList();
            var livros = new List<Livro>
            {
                new Livro { IdLivro = Guid.NewGuid(), Titulo = "Memórias", IdAutor = autores[0].IdAutor, Autor = autores[0] },
                new Livro { IdLivro = Guid.NewGuid(), Titulo = "Hora Estrelar", IdAutor = autores[1].IdAutor, Autor = autores[1] },
                new Livro { IdLivro = Guid.NewGuid(), Titulo = "Capitães", IdAutor = autores[2].IdAutor, Autor = autores[2] },
                new Livro { IdLivro = Guid.NewGuid(), Titulo = "Passaredo", IdAutor = autores[3].IdAutor, Autor = autores[3] },
                new Livro { IdLivro = Guid.NewGuid(), Titulo = "Alguma Poesia", IdAutor = autores[4].IdAutor, Autor = autores[4] }
            };

            context.Livros.AddRange(livros);
            await context.SaveChangesAsync();
            logger.LogInformation("Livros inseridos.");
        }

        if (!context.Cars.Any())
        {
            var cars = new List<Car>
            {
                new Car { Id = new Guid("11111111-1111-1111-1111-111111111111"), Chassi = 123456, Name = "Ferrari 488 GTB" },
                new Car { Id = new Guid("22222222-2222-2222-2222-222222222222"), Chassi = 234567, Name = "Lamborghini Aventador" },
                new Car { Id = new Guid("33333333-3333-3333-3333-333333333333"), Chassi = 345678, Name = "Porsche 911 Turbo" },
                new Car { Id = new Guid("44444444-4444-4444-4444-444444444444"), Chassi = 456789, Name = "BMW M5 Competition" },
                new Car { Id = new Guid("55555555-5555-5555-5555-555555555555"), Chassi = 567890, Name = "Audi R8 V10" }
            };

            context.Cars.AddRange(cars);
            await context.SaveChangesAsync();
            logger.LogInformation("Carros inseridos.");
        }
    }
}
