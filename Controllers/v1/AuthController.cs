namespace Winter.Controllers.v1;

[DefaultController]
public class AuthController : ControllerBase
{
  private readonly AuthService _authService;

  public AuthController(AuthService authService)
  {
    _authService = authService;
  }

  [HttpGetFor(nameof(Login))]
  public string Login(LoginRequestDto loginDto)
  {
    User user = _authService.Authenticate(
      loginDto.Email,
      loginDto.Password
    );
    return _authService.GenerateJwtToken(user);
  }
}
