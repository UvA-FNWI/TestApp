var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var config = app.Configuration;

var logger = app.Services.GetRequiredService<ILogger<WebApplication>>();
logger.LogWarning($"Starting test app. TESTVALUE: {config["TESTVALUE"]}");

app.MapGet("/", () => "Hello World!");

app.Run();