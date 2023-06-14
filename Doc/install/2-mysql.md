#### Add local connection string

> `./appsettings.json`

#### Install packages

```bash
dotnet add package Pomelo.EntityFrameworkCore.MySql
dotnet add package Microsoft.EntityFrameworkCore.Tools
```

#### Add the db-context file

> `./Core/ApplicationDbContext.cs`

#### Register the context in `Program.cs`

> So far it registered as a singleton

#### Create the first migration

```bash
dotnet ef migrations add InitialCreate
```

#### Apply all

```bash
dotnet ef database update
```

#### For docker may require to update the connection string

Add

```bash
SSL Mode=None
```
