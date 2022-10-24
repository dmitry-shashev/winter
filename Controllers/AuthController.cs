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
    var token = _authService.GetToken(
      loginDto.Email,
      loginDto.Password
    );
    return token;
  }
}
