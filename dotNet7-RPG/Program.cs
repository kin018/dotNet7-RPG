global using AutoMapper;
global using dotNet7_RPG.DTOs.Character;
global using dotNet7_RPG.Models; //could have here
global using dotNet7_RPG.Services.CharacterService;
global using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//register automapper
builder.Services.AddAutoMapper(typeof(Program).Assembly);
builder.Services.AddScoped<ICharacterService, CharacterService>(); //Registered the Character Service.Now web API knows that it has to use character service class whenever controller wants inject the ICharacterService.   In the future if we want to use another implementation/change all we so is change CharacterService here

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