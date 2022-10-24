namespace Winter.Services;

public interface IAuthService
{
  public string GetToken(string email, string password);
}

public class AuthService : IAuthService
{
  public string GetToken(string email, string password)
  {
    return "Bearer token";
  }
}
