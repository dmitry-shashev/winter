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
    var users = _usersService.GetAllWithBooks();
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
    var user = _usersService.GetByIdLibraries(id);
    return user.AsResponseDto();
  }

  [HttpPost]
  public UserResponseDto CreateUser(
    AddUserRequestDto userDto
  )
  {
    var createdUser = _usersService.CreateUser(
      userDto.Email,
      userDto.FirstName,
      userDto.LastName,
      userDto.Phone
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
      id,
      userDto.FirstName,
      userDto.LastName,
      userDto.Phone
    );
    return updatedUser.AsResponseDto();
  }

  [HttpDelete("{id:int}")]
  public void DeleteUser(int id)
  {
    _usersService.DeleteUser(id);
  }
}
