#### Install package

```bash
dotnet add package AutoMapper
dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection
```

#### Create init file

> AppMappingProfile

#### Add into `Program.cs`

```bash
builder.Services.AddAutoMapper(typeof(AppMappingProfile));
```

#### Then we can use it

```bash
  [HttpGet("auto-mapper/{id:int}")]
  public UserResponseSimpleDto TestAutoMapper(int id)
  {
    var user = _usersService.GetById(id, false, true);
    return _mapper.Map<UserResponseSimpleDto>(user);
  }
```

In docs we also can find how to adjust mapping with some
different names