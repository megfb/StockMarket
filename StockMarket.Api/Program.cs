using Microsoft.AspNetCore.SignalR;
using StockMarket.Api.Hubs;
using StockMarket.Repositories.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddIdentityService(builder.Configuration);
builder.Services.AddRepositories(builder.Configuration);
builder.Services.AddSignalR();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapHub<MyHub>("/MyHub");

app.UseAuthorization();

app.MapControllers();

app.Run();
