namespace Winter.Controllers;

[DefaultController]
public class UsersController : ControllerBase
{
  private readonly IUsersService _usersService;

  public UsersController(IUsersService usersService)
  {
    _usersService = usersService;
  }

  [HttpGet]
  public IEnumerable<UserResponseDto> GetAll()
  {
    var users = _usersService.GetAll();
    return users.Select(v => v.AsResponseDto());
  }

  [HttpGet("{id:guid}")]
  public UserResponseDto GetById(Guid id)
  {
    var user = _usersService.GetById(id);
    return user.AsResponseDto();
  }

  [HttpPost]
  public UserResponseDto CreateUser(
    AddUserRequestDto userDto
  )
  {
    var createdUser = _usersService.CreateUser(
      userDto.firstName,
      userDto.lastName
    );
    return createdUser.AsResponseDto();
  }

  [HttpPut("{id:guid}")]
  public UserResponseDto UpdateUser(
    Guid id,
    AddUserRequestDto userDto
  )
  {
    var updatedUser = _usersService.UpdateUser(
      id,
      userDto.firstName,
      userDto.lastName
    );
    return updatedUser.AsResponseDto();
  }
}
