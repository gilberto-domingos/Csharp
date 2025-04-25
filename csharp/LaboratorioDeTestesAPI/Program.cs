using LaboratorioDeTestesAPI.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

DotNetEnv.Env.Load();

var dbServer = Environment.GetEnvironmentVariable("DB_SERVER");
var dbName = Environment.GetEnvironmentVariable("DB_NAME");
var saPassword = Environment.GetEnvironmentVariable("SA_PASSWORD");

var connectionString =
    $"Server={dbServer};Database={dbName};User Id=sa;Password={saPassword};TrustServerCertificate=True";

builder.Configuration["ConnectionStrings:DefaultConnection"] = connectionString;

builder.WebHost.UseUrls("http://0.0.0.0:5000");

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers();

builder.Services.AddDbContext<ApiDbContext>(options =>
    options
        .UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
        .LogTo(Console.WriteLine, LogLevel.Information) // só para desenvolvimento
        .EnableSensitiveDataLogging());



var app = builder.Build();


using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<ApiDbContext>();
    ApiDbContext.Initialize(scope.ServiceProvider, context);
}


app.MapControllers();

app.Run();
