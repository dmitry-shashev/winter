namespace Winter.Controllers;

// This controller has examples
// - working with cookies

[DefaultController]
public class SessionController : ControllerBase
{
  [HttpGetFor(nameof(ReadColorCookie))]
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

  [HttpGetFor(nameof(SetupColorCookie))]
  public string SetupColorCookie()
  {
    Response.Cookies.Append("color", "green");
    return "The cookie has been set up";
  }

  [HttpGetFor(nameof(DeleteColorCookie))]
  public string DeleteColorCookie()
  {
    Response.Cookies.Delete("color");
    return "The cookie has been deleted";
  }
}
