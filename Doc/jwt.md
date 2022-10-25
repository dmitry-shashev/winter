#### Install packages

```bash
dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer
dotnet add package Microsoft.IdentityModel.Tokens
dotnet add package System.IdentityModel.Tokens.Jwt
```

#### Add configs into `appsettings.json`

```bash
  "Jwt": {
    "Key": "some_random_key",
    "Issuer": "test.com",
    "Audience": "test.com"
  },
```

#### Register in `Program.cs`

```bash
builder.Services.AddAuthentication(
  JwtBearerDefaults.AuthenticationScheme
).AddJwtBearer(options => {
    options.TokenValidationParameters = new TokenValidationParameters {
        ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = builder.Configuration["Jwt:Issuer"],
            ValidAudience = builder.Configuration["Jwt:Audience"],
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
    };
});
```

#### Core functions

They are placed in the `AuthService.cs`