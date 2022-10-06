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
dotnet ef migrations add MockUsers
dornet ef database update
```
