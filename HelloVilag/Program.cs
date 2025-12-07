var builder = WebApplication.CreateBuilder(args);
builder.WebHost.UseUrls("http://0.0.0.0:8080");

var app = builder.Build();

app.MapGet("/", () => "Hello Világ :) Ez itt egy nagyszerû 'program' :P");
app.MapGet("/welcome/{name}", (string name) => $"Üdvözöllek, {name}!");

app.Run();
