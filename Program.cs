global using Microsoft.AspNetCore.Mvc;
global using Winter.Core;
global using Winter.Services;
global using Winter.Models;
global using Winter.Models.Adapters;
global using Winter.Models.Dto.Response;
global using Winter.Models.Dto.Request;
global using Winter.Core.Exceptions;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//##############################################################
// database

// build the options
var connectionString =
  builder.Configuration.GetConnectionString("Local");
var optionsBuilder =
  new DbContextOptionsBuilder<ApplicationDbContext>();
var options = optionsBuilder
  .UseMySql(
    connectionString,
    new MySqlServerVersion(new Version(8, 0, 11))
  )
  .Options;

// build the context
var context = new ApplicationDbContext(options);
if (context.Database.CanConnect() == false)
{
  throw new Exception("Can not connect to the Database");
}

// register the context as a singleton
builder.Services.AddSingleton(context);

//##############################################################
// services

builder.Services.AddSingleton<
  IUsersService,
  UsersService
>();

//##############################################################

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

//##############################################################
// exception middleware

app.UseMiddleware<ExceptionMiddleware>();

//##############################################################

if (app.Environment.IsDevelopment())
{
  app.UseSwagger();
  app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
