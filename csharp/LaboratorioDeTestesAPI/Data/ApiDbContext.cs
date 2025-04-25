namespace LaboratorioDeTestesAPI.Data;

using LaboratorioDeTestesAPI.Entities;
using Microsoft.EntityFrameworkCore;
using System;


internal sealed class ApiDbContext : DbContext
{
    public DbSet<Car> Cars { get; init; }

    public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApiDbContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }

    public static void Initialize(IServiceProvider serviceProvider, ApiDbContext context)
    {
        context.Database.Migrate();
    }
}
