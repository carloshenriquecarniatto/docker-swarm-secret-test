var builder = WebApplication.CreateBuilder(args);
builder.Configuration.AddUserSecrets("MySecret");
var app = builder.Build();

app.MapGet("/", () =>
{
    var config = app.Configuration["MySecret"] ?? string.Empty;
    return config;
});

app.Run();