global using Microsoft.AspNetCore.Mvc;
global using Winter.Core;
global using Winter.Services;
global using Winter.Models;
global using Winter.Models.Adapters;
global using Winter.Models.Dto.Response;
global using Winter.Models.Dto.Request;
global using Winter.Core.Exceptions;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);
var environmentName = builder.Environment.EnvironmentName;

//##############################################################
// Load configs according to the env
// for example - `dotnet run --environment Staging`
// - will try to load `appsettings.Staging.json`

builder.Configuration
  .AddJsonFile(
    "appsettings.json",
    optional: false,
    reloadOnChange: true
  )
  .AddJsonFile(
    $"appsettings.{environmentName}.json",
    optional: true,
    reloadOnChange: true
  )
  .AddEnvironmentVariables();
;

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

//##############################################################
// Add JWT

builder.Services
  .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
  .AddJwtBearer(options =>
  {
    options.TokenValidationParameters =
      new TokenValidationParameters
      {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = builder.Configuration["Jwt:Issuer"],
        ValidAudience = builder.Configuration[
          "Jwt:Audience"
        ],
        IssuerSigningKey = new SymmetricSecurityKey(
          Encoding.UTF8.GetBytes(
            builder.Configuration["Jwt:Key"]
          )
        )
      };
  });

//##############################################################

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
