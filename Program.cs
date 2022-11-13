using atividadeAvaliativaModulo6.Database;
using atividadeAvaliativaModulo6.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var connectionMySQL = builder.Configuration.GetConnectionString("MainConnection");
builder.Services.AddDbContext<ClienteDbContext>(
    options => options.UseMySql(connectionMySQL, ServerVersion.Parse("8.0.30-mysql"))
);

builder.Services.AddScoped<IClienteRepository, ClienteRepo>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
