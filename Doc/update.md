#### New build can be downloaded

```bash
https://dotnet.microsoft.com/en-us/download/dotnet/7.0
```

> Pay attention - they do not provide to do it automatically

If the project has `global.json` then instead of the last version - the
specified version will be used.

So we have to specify the new version in this file.

Also installed sdk may have other minor version, in order to see all possible

```bash
dontnet --info
```

In *.csproj

```bash
    <TargetFramework>net7.0</TargetFramework>
```

Update text version in the config file - `ConfigureSwaggerOptions.cs`

#### Update all tools

There is a special tool, or it can be done manually

> They do not support it out of the box

Get the list of current tools

```bash
dotnet tool list
```

Then update them

```bash
dotnet tool update husky
dotnet tool update swashbuckle.aspnetcore.cli
dotnet tool update dotnet-script
```

#### Update all packages

```bash
dotnet list package
```

They do not have `update command` - so we remove them and
install again

```bash
dotnet remove package Ardalis.SmartEnum
dotnet remove package AutoMapper
dotnet remove package AutoMapper.Extensions.Microsoft.DependencyInjection
dotnet remove package Microsoft.AspNetCore.Authentication.JwtBearer
dotnet remove package Microsoft.AspNetCore.Mvc.Versioning
dotnet remove package Microsoft.AspNetCore.Mvc.Versioning.ApiExplorer
dotnet remove package Microsoft.EntityFrameworkCore.Tools
dotnet remove package Microsoft.IdentityModel.Tokens
dotnet remove package Pomelo.EntityFrameworkCore.MySql
dotnet remove package Swashbuckle.AspNetCore
dotnet remove package System.IdentityModel.Tokens.Jwt

dotnet add package Ardalis.SmartEnum
dotnet add package AutoMapper
dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection
dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer
dotnet add package Microsoft.AspNetCore.Mvc.Versioning
dotnet add package Microsoft.AspNetCore.Mvc.Versioning.ApiExplorer
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet add package Microsoft.IdentityModel.Tokens
dotnet add package Pomelo.EntityFrameworkCore.MySql
dotnet add package Swashbuckle.AspNetCore
dotnet add package System.IdentityModel.Tokens.Jwt
```

#### Update certs

```bash
dotnet dev-certs https --clean
dotnet dev-certs https
```

