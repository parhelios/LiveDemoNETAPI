using LiveDemo.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<AnimalService>();

var app = builder.Build();

app.MapAnimalEndpoints();

app.Run();
