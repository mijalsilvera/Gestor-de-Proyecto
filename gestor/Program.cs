using gestor.Funcionalidades.ComentarioF;
using gestor.Funcionalidades.ProyectoF;
using gestor.Funcionalidades.TicketF;
using gestor.Funcionalidades.UsuarioF;
using src;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<ITicketService, TicketService>();
builder.Services.AddSingleton<IComentarioService, ComentarioService>();
builder.Services.AddSingleton<IUsuarioService, UsuarioService>();
builder.Services.AddSingleton<IProyectoService, ProyectoService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapTicketEndpoint();

app.MapComentarioEndpoint();

app.MapUsuarioEndpoint();

app.MapProyectoEndpoint();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
