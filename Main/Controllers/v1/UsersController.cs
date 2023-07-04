using Winter.Models.Adapters;

namespace Winter.Controllers.v1;

[DefaultController]
public class UsersController : ControllerBase
{
  private readonly UsersService _usersService;

  public UsersController(UsersService usersService)
  {
    _usersService = usersService;
  }

  [HttpGet]
  public IEnumerable<UserResponseDto> GetAll()
  {
    var users = _usersService.GetAll(true, true);
    return users.Select(v => v.AsResponseDto());
  }

  [HttpGet("{id:int}")]
  public UserResponseDto GetById(int id)
  {
    var user = _usersService.GetById(id);
    return user.AsResponseDto();
  }

  [HttpGet("{id:int}/libraries")]
  public UserResponseDto GetByIdLibraries(int id)
  {
    var user = _usersService.GetById(id, false, true);
    return user.AsResponseDto();
  }

  [HttpPost]
  public UserResponseDto CreateUser(
    AddUserRequestDto userDto
  )
  {
    var createdUser = _usersService.CreateUser(
      email: userDto.Email,
      firstName: userDto.FirstName,
      lastName: userDto.LastName,
      phone: userDto.Phone
    );
    return createdUser.AsResponseDto();
  }

  [HttpPut("{id:int}")]
  public UserResponseDto UpdateUser(
    int id,
    AddUserRequestDto userDto
  )
  {
    var updatedUser = _usersService.UpdateUser(
      id: id,
      firstName: userDto.FirstName,
      lastName: userDto.LastName,
      phone: userDto.Phone
    );
    return updatedUser.AsResponseDto();
  }

  [HttpDelete("{id:int}")]
  public void DeleteUser(int id)
  {
    _usersService.DeleteUser(id);
  }
}
