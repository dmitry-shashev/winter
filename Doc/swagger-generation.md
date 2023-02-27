#### Add a package

```bash
dotnet tool install Swashbuckle.AspNetCore.Cli
```

Then we can generate it from the CLI

```bash
dotnet swagger tofile --output ./swagger.json ./bin/Debug/net6.0/Winter.dll v1
```

#### Add auto-update on build

Add into main *.csproj

```bash
    <Target Name="CreateSwaggerJson" AfterTargets="PostBuildEvent" Condition="'$(Configuration)' == 'SwaggerConfig'">
        <Exec Command="dotnet tool restore" />
        <Exec Command="dotnet swagger tofile --output ./swagger.json $(OutputPath)$(AssemblyName).dll v1" WorkingDirectory="$(ProjectDir)" />
    </Target>
```

#### In `Program.cs`

```bash
if (app.Environment.IsDevelopment())
{
  app.UseSwagger();
  app.UseSwaggerUI();
}
```

#### Add into a pre-commit hook

Add the task in the file - `task-runner.json`

```bash
      {
         "name": "Test building - creating swagger.json",
         "command": "dotnet",
         "args": ["build", "-c", "SwaggerConfig", "./MSS.LostAndFound/Main/Main.csproj"]
      },
```