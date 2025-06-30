using Shared.Configuration.Extensions;
using Baim.Identity.Data.Modules;
using Baim.Identity.Services.Modules;


var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddSharedConfiguration()
    .AddDataModule(builder.Configuration)
    .AddIdentityServices();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
