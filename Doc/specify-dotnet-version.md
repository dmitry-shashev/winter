Dotnet may use the last version on the project

In order to prevent it - we can create `global.json` in the
project root directory

```bash
{
  "sdk": {
    "version": "6.0.401"
  }
}
```

#### See the list of SDK

```bash
dotnet --info
```

#### See the currently used SDK

```bash
dotnet --version
```

> After creating `global.json` it will show `currently` used version
> for the project
