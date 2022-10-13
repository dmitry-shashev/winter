namespace Winter.Controllers;

// This controller has examples
// - working with cookies

[DefaultController]
public class SessionController : ControllerBase
{
  [HttpGet("read-color-cookie")]
  public string ReadColorCookie()
  {
    if (
      !Request.Cookies.TryGetValue("color", out var color)
    )
    {
      return "Cookie 'color' was not found";
    }
    return $"The value is - {color}";
  }

  [HttpGet("setup-color-cookie")]
  public string SetupColorCookie()
  {
    Response.Cookies.Append("color", "green");
    return "The cookie has been set up";
  }

  [HttpGet("delete-color-cookie")]
  public string DeleteColorCookie()
  {
    Response.Cookies.Delete("color");
    return "The cookie has been deleted";
  }
}
