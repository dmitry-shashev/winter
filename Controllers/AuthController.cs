namespace Winter.Controllers;

[DefaultController]
public class AuthController : ControllerBase
{
  private readonly IAuthService _authService;

  public AuthController(IAuthService authService)
  {
    _authService = authService;
  }

  [HttpPost("login")]
  public string Login(LoginRequestDto loginDto)
  {
    User user = _authService.Authenticate(
      loginDto.Email,
      loginDto.Password
    );
    return _authService.GenerateJwtToken(user);
  }
}
