// Cria um construtor do nosso aplicativo web
var builder = WebApplication.CreateBuilder(args);

// Adiciona os servi�os MCV - Permitindo uso dos controladores 
builder.Services.AddControllersWithViews();

var app = builder.Build();

// verifica se o ambiente � de desenvolvimento
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

// permite o uso de arquivos est�ticos
app.UseStaticFiles();

// permite o uso de roteamento na aplica��o
app.UseRouting();

// Habilita a autentica��o e autoriza��o
app.UseAuthorization();

// mapeia a rota padr�o para os controladores
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
