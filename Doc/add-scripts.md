#### Install

```bash
dotnet tool install dotnet-script
```

#### Init configs

```bash
dotnet script init
```

It will create next files

```bash
main.csx
omnisharp.json
```

> `main.csx` - example

We can add in the beginning of each script next line

```bash
#!/usr/bin/env dotnet script
```

And it allows to start each script simply

```bash
./main.csx
```

> Also if start in this way - do not forget to set up permissions

#### Create `Scripts` folder

#### Exclude from the build - `Winter.csproj`

```bash
    <ItemGroup>
        <Compile Remove="Scripts\**" />
        <Content Include="Scripts\**" />
    </ItemGroup>
```

#### Get all command arguments

> silly way - it provides only an array

Args - global array

```bash
foreach (var arg in Args)
{
    Console.WriteLine(arg);
}
```