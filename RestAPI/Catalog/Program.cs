using System.Data.Common;
using Catalog.Repositories;
using Catalog.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//Repository(DI):
builder.Services.AddSingleton<IItemsRepository, InMemItemsRepository>();
builder.Services.AddSingleton<IItemService, ItemService>();

builder.Services.AddControllers();
// Learn more about configuring Swag at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
