#### Init the manifest file

> `https://csharpier.com/docs/Pre-commit`

```bash
dotnet new tool-manifest
```

#### Install husky

```bash
dotnet tool install husky
dotnet husky install
```

#### Add the task in the config

> `.husky/task-runner.json`

```bash
{
   "tasks": [
      {
        "name": "Run csharpier",
        "command": "dotnet",
        "args": [ "csharpier", "." ],
        "include": [ "**/*.cs" ]
      }
   ]
}
```

#### Add auto-install to the `*.csproj`

```bash
    <!-- set HUSKY to 0 in CI/CD disable this -->
    <Target Name="husky" BeforeTargets="Restore;CollectPackageReferences" Condition="'$(HUSKY)' != 0">
        <Exec Command="dotnet tool restore" StandardOutputImportance="Low" StandardErrorImportance="High"/>
        <Exec Command="dotnet husky install" StandardOutputImportance="Low" StandardErrorImportance="High" WorkingDirectory="."/>
    </Target>
```

#### Test

```bash
dotnet husky run
```

#### Add the final running

> It will create a `pre-commit` file

```bash
dotnet husky add pre-commit -c "dotnet husky run"
```