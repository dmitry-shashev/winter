using AutoMapper;
using Winter.Core.Helpers;

namespace Winter.Controllers.v1;

[DefaultController]
public class SomeTestController
{
  private readonly UsersService _usersService;

  private readonly IMapper _mapper;

  public SomeTestController(
    UsersService usersService,
    IMapper mapper
  )
  {
    _usersService = usersService;
    _mapper = mapper;
  }

  [HttpGetFor(nameof(TestOne))]
  public void TestOne()
  {
    UserHelper.TestEnums();
  }

  [HttpGet("auto-mapper/{id:int}")]
  public UserResponseSimpleDto TestAutoMapper(int id)
  {
    var user = _usersService.GetById(id, false, true);
    return _mapper.Map<UserResponseSimpleDto>(user);
  }
}
