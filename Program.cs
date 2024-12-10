using AutoMapping.Store.ViewModels;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAutoMapper(typeof(Program).Assembly);

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.Run();