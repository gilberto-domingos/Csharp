using Microsoft.EntityFrameworkCore;
using ApiRestFull.Data;
using ApiRestFull.Interfaces;
using ApiRestFull.Services;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

DotNetEnv.Env.Load();

var dbServer = Environment.GetEnvironmentVariable("DB_SERVER");
var dbName = Environment.GetEnvironmentVariable("DB_NAME");
var saPassword = Environment.GetEnvironmentVariable("SA_PASSWORD");

var connectionString =
    $"Server={dbServer};Database={dbName};User Id=sa;Password={saPassword};TrustServerCertificate=True";

builder.Configuration["ConnectionStrings:DefaultConnection"] = connectionString;

builder.WebHost.UseUrls("http://0.0.0.0:5000");

builder.Services.AddScoped<IAutor, AutorService>();
builder.Services.AddScoped<ILivro, LivroService>();
builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Title = "ApiRestFull",
        Version = "v1",
        Description = "Documentação da ApiRestFull",
        Contact = new Microsoft.OpenApi.Models.OpenApiContact
        {
            Name = "gilberto domingos jr",
            Email = "jrdomingosjr00@gmail.com",
        }
    });

    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    c.IncludeXmlComments(xmlPath);
});

builder.Services.AddDbContext<ApiDbContext>(options =>
    options
    .UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
    .LogTo(Console.WriteLine, LogLevel.Information)  // Log só para desenvolvimento
    .EnableSensitiveDataLogging()); //

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<ApiDbContext>();
    ApiDbContext.Initialize(scope.ServiceProvider, context);
}

app.UseRouting();

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseSwagger();
app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "ApiRestFull v1");
    options.RoutePrefix = string.Empty;
});

app.MapControllers();

app.Run();
