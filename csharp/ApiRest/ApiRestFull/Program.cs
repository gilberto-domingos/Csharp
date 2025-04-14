using Microsoft.EntityFrameworkCore;
using SistemaVendas.Data;
using SistemaVendas.Services;

var builder = WebApplication.CreateBuilder(args);

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