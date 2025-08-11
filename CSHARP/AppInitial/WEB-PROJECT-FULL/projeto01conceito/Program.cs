var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();


/*
    FrameWork da Microsoft

    1- Mais rápido
    2- Mais seguro
    3- Mais leve
    4- Open Source
    5- Multi plataforma (Windows, Linux, MacOS)
    6- Suporte para containers (Docker)
    7- Suporte para micro serviços
    8- Suporte para Cloud (Azure, AWS, Google Cloud)
 
 */