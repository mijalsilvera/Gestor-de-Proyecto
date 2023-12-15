// using gestor.Funcionalidades.Comentarios;
// using gestor.Funcionalidades.Proyectos;
// using gestor.Funcionalidades.Tickets;
// using gestor.Funcionalidades.Usuarios;
using gestor.Funcionalidades;
using Carter;
using gestor.Persistencia;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddServiceManager();
builder.Services.AddCarter();

var connectionString = builder.Configuration.GetConnectionString("aplicacion_db");

builder.Services.AddDbContext<AplicacionDbContext>(opcion =>
    opcion.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 34))));

builder.Services.AddDbContext<AplicacionDbContext>();

var opciones = new DbContextOptionsBuilder<AplicacionDbContext>();

opciones.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 34)));

var contexto = new AplicacionDbContext(opciones.Options);

contexto.Database.EnsureCreated();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.MapComentarioEndpoint();
//app.MapProyectoEndpoint();
//app.MapTicketEndpoint();
//app.MapUsuarioEndpoint();

app.MapCarter();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
