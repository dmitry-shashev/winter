global using Microsoft.AspNetCore.Mvc;
global using Winter.Core;
global using Winter.Services;
global using Winter.Models;
global using Winter.Models.Dto.Response;
global using Winter.Models.Dto.Request;
global using Winter.Core.Exceptions;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.AspNetCore.Mvc.Versioning;
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

builder.Services.AddScoped<UsersService>();
builder.Services.AddScoped<AuthService>();

//##############################################################

builder.Services.AddControllers(options =>
{
  options.Conventions.Add(
    new RouteTokenTransformerConvention(
      new SlugifyParameterTransformer()
    )
  );
});

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
// versioning

builder.Services.AddApiVersioning(opt =>
{
  opt.DefaultApiVersion =
    new Microsoft.AspNetCore.Mvc.ApiVersion(1, 0);
  opt.AssumeDefaultVersionWhenUnspecified = true;
  opt.ReportApiVersions = true;
  opt.ApiVersionReader = ApiVersionReader.Combine(
    new UrlSegmentApiVersionReader(),
    new HeaderApiVersionReader("x-api-version"),
    new MediaTypeApiVersionReader("x-api-version")
  );
});

builder.Services.AddVersionedApiExplorer(options =>
{
  options.GroupNameFormat = "'v'VVV";
  options.SubstituteApiVersionInUrl = true;
});

builder.Services.ConfigureOptions<ConfigureSwaggerOptions>();

//##############################################################

var app = builder.Build();

//##############################################################
// exception middleware

app.UseMiddleware<ExceptionMiddleware>();

//##############################################################


var apiVersionDescriptionProvider =
  app.Services.GetRequiredService<IApiVersionDescriptionProvider>();
app.UseSwagger();
app.UseSwaggerUI(options =>
{
  foreach (
    var description in apiVersionDescriptionProvider.ApiVersionDescriptions
  )
  {
    options.SwaggerEndpoint(
      $"/swagger/{description.GroupName}/swagger.json",
      description.GroupName.ToUpperInvariant()
    );
  }
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
