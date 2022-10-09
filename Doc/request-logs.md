We can add showing all headers in the console for each request

simply add in the `Program.cs`

```bash
app.UseHttpLogging();
```

and in `appsettings.json`

```bash
  "Logging": {
    "LogLevel": {
      // ...
      "Microsoft.AspNetCore.HttpLogging.HttpLoggingMiddleware": "Information"
    }
  },
```

#### Advanced method

```bash
./Controllers/LogController.cs
```
