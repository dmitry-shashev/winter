There are 2 approaches - create a separate project in the same
solution or add tests inside a real project.

In this project we are using the second one.

#### Install

```bash
dotnet add package xunit
dotnet add package Microsoft.NET.Test.Sdk
dotnet add package xunit.runner.console --version 2.4.2
dotnet add package xunit.runner.visualstudio
```

> We need anyway `xunit.runner.visualstudio` - otherwise it will not
> starting working from the console - super counterintuitive

#### Run tests

```bash
dotnet test
```

#### Add into a task runner - `task-runner.json`

```bash
    {
      "name":"Run unit tests",
      "command":"dotnet",
      "args":[
        "test"
      ]
    },
```