using DevLabs.Api.Data;

public interface IDataSeeder
{
    Task SeedAsync(ApiDbContext context, ILogger logger);
}
