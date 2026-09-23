var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", (IConfiguration configuration) =>
{
    var modelo = configuration["Gemini:Model"];
    bool haveKeyGemini = !string.IsNullOrEmpty(configuration["Gemini:ApiKey"]);
    bool haveTokenWpp = !string.IsNullOrEmpty(configuration["WhatsApp:UserToken"]);
    return new
    {
        modelo = modelo,
        servico = "WhatsApp AI Bot",
        haveKeyGemini = haveKeyGemini,
        haveTokenWpp = haveTokenWpp
        
        
    };
});

app.Run();
