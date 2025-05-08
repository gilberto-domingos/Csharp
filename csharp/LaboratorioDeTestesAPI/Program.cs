using LaboratorioDeTestesAPI.Data;
using LaboratorioDeTestesAPI.Interfaces;
using LaboratorioDeTestesAPI.Repositories;
using LaboratorioDeTestesAPI.Services;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Serilog;
using System.Reflection;

DotNetEnv.Env.Load();

Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Information()
    .Enrich.FromLogContext()
    .WriteTo.Console(
        outputTemplate: "[{Timestamp:HH:mm:ss} {Level:u3}] {Message:lj}{NewLine}{Exception}",
        theme: Serilog.Sinks.SystemConsole.Themes.AnsiConsoleTheme.Code)
    .CreateLogger();

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseSerilog();

var dbServer = Environment.GetEnvironmentVariable("DB_SERVER");
var dbName = Environment.GetEnvironmentVariable("DB_NAME");
var saPassword = Environment.GetEnvironmentVariable("SA_PASSWORD");

var connectionString =
    $"Server={dbServer};Database={dbName};User Id=sa;Password={saPassword};TrustServerCertificate=True";

builder.Configuration["ConnectionStrings:DefaultConnection"] = connectionString;

builder.WebHost.UseUrls("http://0.0.0.0:5000");

builder.Services.AddScoped<IAutor, AutorService>();
builder.Services.AddScoped<IAutorRepository, AutorRepository>();
builder.Services.AddScoped<ILivro, LivroService>();
builder.Services.AddScoped<ILivroRepository, LivroRepository>();
builder.Services.AddScoped<ICar, CarChassiValidatorService>();
builder.Services.AddScoped<ICarRepository, CarRepository>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApiDbContext>(options =>
    options
        .UseSqlServer(connectionString)
        .LogTo(Log.Logger.Information, LogLevel.Information)
        .EnableSensitiveDataLogging(false)
        .ConfigureWarnings(warnings =>
            warnings.Ignore(CoreEventId.SensitiveDataLoggingEnabledWarning)));

builder.Services.AddCors(options =>
{
    options.AddPolicy("ReactPolicy", policy =>
    {
        policy.WithOrigins("http://localhost:5173")
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

builder.Services.AddMediatR(Assembly.GetExecutingAssembly());

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<ApiDbContext>();
    ApiDbContext.Initialize(scope.ServiceProvider, context);
}

app.UseCors("ReactPolicy");

app.MapControllers();

app.Run();
