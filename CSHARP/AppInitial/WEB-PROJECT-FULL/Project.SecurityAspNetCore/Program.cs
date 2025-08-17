using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;

var builder = WebApplication.CreateBuilder(args); // Cria o construtor da aplicação

// Adicionar serviços de autenticação e de autorização
builder.Services.AddAuthentication("Cookies").AddCookie("Cookies", config =>
    {
        config.Cookie.Name = "User.Login.Cookie"; // significa que o cookie será chamado "User.Login.Cookie"
        config.LoginPath = "/account/login"; // caminho para a página de login
    }
);

// Abaixo significa que o cookie será usado para autenticação
builder.Services.AddAuthorization(config =>
    {
        config.AddPolicy("Admin", policy => policy.RequireClaim("Admin")); // política que requer o claim "Admin"
        config.AddPolicy("User", policy => policy.RequireClaim("User")); // política que requer o claim "User"
    }
);

// Significa que o ASP.NET Core usará o cookie de autenticação para autenticar os usuários
builder.Services.AddControllers();

// Adiciona o serviço do Swagger
builder.Services.AddSwaggerGen();

// Adiciona os serviços necessários para a aplicação
var app = builder.Build();

// Habilita o Swagger no pipeline
app.UseSwagger();
app.UseSwaggerUI();

// Autenticação e autorização
app.UseHttpsRedirection(); // Redireciona requisições HTTP para HTTPS
app.UseAuthentication(); // Ativa o middleware de autenticação
app.UseAuthorization(); // Ativa o middleware de autorização

app.MapControllers(); // Mapeia os controladores para as rotas
app.Run(); // Inicia a aplicação