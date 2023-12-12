using gestor.Funcionalidades.Comentarios;
using gestor.Funcionalidades.Proyectos;
using gestor.Funcionalidades.Tickets;
using gestor.Funcionalidades.Usuarios;
using gestor;
using src;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddServiceManager();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapComentarioEndpoint();

app.MapProyectoEndpoint();

app.MapTicketEndpoint();

app.MapUsuarioEndpoint();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
