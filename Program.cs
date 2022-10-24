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

var connectionString =
  builder.Configuration.GetConnectionString("Local");
builder.Services.AddDbContextPool<ApplicationDbContext>(
  options =>
    options.UseMySql(
      connectionString,
      new MySqlServerVersion(new Version(8, 0, 11))
    )
);

//##############################################################
// services

builder.Services.AddScoped<IUsersService, UsersService>();
builder.Services.AddScoped<IAuthService, AuthService>();

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
