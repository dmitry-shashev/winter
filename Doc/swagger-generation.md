#### Add a package

```bash
dotnet tool install Swashbuckle.AspNetCore.Cli
```

Then we can generate it from the CLI

```bash
dotnet swagger tofile --output ./swagger.json ./bin/Debug/net6.0/Winter.dll v1
```

#### Add auto-update on build

Add into *.csproj

```bash
    <Target Name="CreateSwaggerJson" AfterTargets="Build" Condition="$(Configuration)=='Debug'">
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