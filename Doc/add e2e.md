Add a project - choose `MSTest` with a name `e2e`

#### Install package

```bash
cd e2e
dotnet add package Microsoft.AspNetCore.Mvc.Testing

dotnet add package xunit
dotnet add package Microsoft.NET.Test.Sdk
dotnet add package xunit.runner.console --version 2.4.2
dotnet add package xunit.runner.visualstudio
```

#### Add in `Main` project settings

```bash
    <ItemGroup>
        <InternalsVisibleTo Include="e2e" />
    </ItemGroup>
```

#### In test controller choose import `Program` from `Main`

#### Start tests

```bash
cd e2e
dotnet test
```