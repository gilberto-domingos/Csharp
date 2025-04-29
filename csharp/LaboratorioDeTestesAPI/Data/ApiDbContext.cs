using Microsoft.EntityFrameworkCore;
using LaboratorioDeTestesAPI.Configurations;

namespace LaboratorioDeTestesAPI.Data
{
    public sealed class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {
        }

        public DbSet<Car> Cars { get; init; }

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
