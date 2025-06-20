using Ocelot.Middleware;
using Ocelot.DependencyInjection;
using Ocelot.Values;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder.WithOrigins(configuration["AllowedOrigins"]!.Split(";"))
               .AllowAnyMethod()
               .AllowAnyHeader()
               .AllowCredentials();
    });
});

builder.Configuration.SetBasePath(builder.Environment.ContentRootPath)
    .AddJsonFile("ocelot.json", optional: false, reloadOnChange: true);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddOcelot();
var app = builder.Build();

app.UseCors();

app.UseHttpsRedirection();

app.UseOcelot().Wait();

app.Run();