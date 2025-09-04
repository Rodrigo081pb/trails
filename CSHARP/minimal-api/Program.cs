using Microsoft.EntityFrameworkCore;
using minimal_api.Dominio.DTOs;
using minimal_api.Infraestrutura.Db;

var builder = WebApplication.CreateBuilder(args);

// Configura a string de conexão via appsettings.json e injeta o DbContext
builder.Services.AddDbContext<DbContexto>(options =>
{
    var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
    options.UseSqlServer(connectionString);
});

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapPost("/login", (LoginDTO loginDTO) =>
{
    if (loginDTO.Email == "admin@teste.com" && loginDTO.Senha == "123Senha")
    {
        var mensagem = "Login realizado com sucesso!";
        return Results.Json(new {mensagem}, statusCode: 200);
    }
    else
    {
        var mensagem = "Email ou senha incorretos";
        return Results.Json(new { mensagem }, statusCode: 401);
    }
});

app.Run();
