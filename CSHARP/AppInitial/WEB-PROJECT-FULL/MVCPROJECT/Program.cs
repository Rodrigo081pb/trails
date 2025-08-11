// Cria um construtor do nosso aplicativo web
var builder = WebApplication.CreateBuilder(args);

// Adiciona os serviços MCV - Permitindo uso dos controladores 
builder.Services.AddControllersWithViews();

var app = builder.Build();

// verifica se o ambiente é de desenvolvimento
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

// permite o uso de arquivos estáticos
app.UseStaticFiles();

// permite o uso de roteamento na aplicação
app.UseRouting();

// Habilita a autenticação e autorização
app.UseAuthorization();

// mapeia a rota padrão para os controladores
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
