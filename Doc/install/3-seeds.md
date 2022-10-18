#### Create a seed file

```bash
./Core/Seeds/UsersSeed.cs
```

#### Connect the seed file in the context

```bash
./Core/ApplicationDbContext.cs
```

#### Create and apply the migration

```bash
dotnet ef migrations add MockUsers && dotnet ef database update
```

#### Rollback last migration

```bash
dotnet ef database update 0 && dotnet ef migrations remove && dotnet ef database update
```

#### Reset and apply all migrations with seeds

```bash
dotnet ef database update 0 && dotnet ef database update
```
