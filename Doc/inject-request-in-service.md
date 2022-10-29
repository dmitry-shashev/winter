#### Add in `Program.cs`

```bash
builder.Services.AddHttpContextAccessor();
```

#### Then it can be injected like

```bash
IHttpContextAccessor accessor
```

> Example how we can get the method name
> `accessor.HttpContext?.Request.Method`