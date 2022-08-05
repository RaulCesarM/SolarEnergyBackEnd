using Microsoft.EntityFrameworkCore;
using SolarEnergyBackEnd.Contextos;

var builder = WebApplication.CreateBuilder(args);
IConfiguration configuration = new ConfigurationBuilder()
                            .AddJsonFile("appsettings.json")
                            .Build();


#pragma warning disable CS8604
builder.Services.AddDbContext<UnidadesContexto>(
    opcoes => opcoes.UseSqlServer(configuration.GetConnectionString("ConexaoDB")));
#pragma warning restore CS8604 

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors();
var app = builder.Build();

if (app.Environment.IsDevelopment()) {
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();


app.UseAuthorization();

app.UseCors(opcoes => opcoes.AllowAnyOrigin()
                            .AllowAnyMethod()
                            .AllowAnyHeader());
app.MapControllers();
app.Run();
