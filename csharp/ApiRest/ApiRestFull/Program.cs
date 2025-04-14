using Microsoft.EntityFrameworkCore;
using SistemaVendas.Data;
using SistemaVendas.Services;

var builder = WebApplication.CreateBuilder(args);

// Pegue os valores das variáveis de ambiente
var dbServer = Environment.GetEnvironmentVariable("DB_SERVER");
var dbName = Environment.GetEnvironmentVariable("DB_NAME");
var saPassword = Environment.GetEnvironmentVariable("SA_PASSWORD");

// Crie a string de conexão
var connectionString =
    $"Server={dbServer};Database={dbName};User Id=sa;Password={saPassword};TrustServerCertificate=True";

builder.Configuration["ConnectionStrings:DefaultConnection"] = connectionString;

builder.WebHost.UseUrls("http://0.0.0.0:5000");

builder.Services.AddScoped<HelloService>();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApiDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

app.UseRouting();

app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();

app.Run();