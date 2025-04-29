using LaboratorioDeTestesAPI.Data;
using Microsoft.EntityFrameworkCore;
using LaboratorioDeTestesAPI.Interfaces;
using LaboratorioDeTestesAPI.Services;
using LaboratorioDeTestesAPI.Repositories;

var builder = WebApplication.CreateBuilder(args);

DotNetEnv.Env.Load();

var dbServer = Environment.GetEnvironmentVariable("DB_SERVER");
var dbName = Environment.GetEnvironmentVariable("DB_NAME");
var saPassword = Environment.GetEnvironmentVariable("SA_PASSWORD");

var connectionString =
    $"Server={dbServer};Database={dbName};User Id=sa;Password={saPassword};TrustServerCertificate=True";

builder.Configuration["ConnectionStrings:DefaultConnection"] = connectionString;

builder.WebHost.UseUrls("http://0.0.0.0:5000");

builder.Services.AddScoped<ICar, CarChassiValidatorService>();
builder.Services.AddScoped<ICarRepository, CarRepository>();



builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddDbContext<ApiDbContext>(options =>
    options
        .UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
        .LogTo(Console.WriteLine, LogLevel.Information) // só para desenvolvimento
        .EnableSensitiveDataLogging());

builder.Services.AddCors(options =>
{
    options.AddPolicy("ReactPolicy", policy =>
    {
        policy.WithOrigins("http://localhost:5173")
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});



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


app.MapControllers();

app.Run();
