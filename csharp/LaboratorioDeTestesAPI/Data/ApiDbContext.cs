using Microsoft.EntityFrameworkCore;
using LaboratorioDeTestesAPI.Configurations;
using LaboratorioDeTestesAPI.Entities;

namespace LaboratorioDeTestesAPI.Data
{
    public sealed class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {
        }

        public DbSet<Car> Cars { get; init; }
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Livro> Livros { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new CarConfiguration());
        }

        public static void Initialize(IServiceProvider serviceProvider, ApiDbContext context)
        {
            context.Database.Migrate();
        }
    }
}
