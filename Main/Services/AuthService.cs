using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace Winter.Services;

public class AuthService
{
  private readonly IConfiguration _config;
  private readonly ApplicationDbContext _dbContext;

  public AuthService(
    IConfiguration config,
    ApplicationDbContext context
  )
  {
    _config = config;
    _dbContext = context;
  }

  public string GenerateJwtToken(User user)
  {
    var securityKey = new SymmetricSecurityKey(
      Encoding.UTF8.GetBytes(_config["Jwt:Key"])
    );
    var credentials = new SigningCredentials(
      securityKey,
      SecurityAlgorithms.HmacSha256
    );
    var claims = new[]
    {
      new Claim(ClaimTypes.NameIdentifier, user.Email),
      new Claim(ClaimTypes.Role, user.Role)
    };
    var token = new JwtSecurityToken(
      _config["Jwt:Issuer"],
      _config["Jwt:Audience"],
      claims,
      expires: DateTime.Now.AddMinutes(15),
      signingCredentials: credentials
    );

    return new JwtSecurityTokenHandler().WriteToken(token);
  }

  public User Authenticate(string email, string password)
  {
    var query = _dbContext.Users.AsQueryable();
    var user = query.FirstOrDefault(
      p => p.Email == email && p.Password == password
    );
    if (user is null)
    {
      throw new AuthenticateException();
    }
    return user;
  }
}
