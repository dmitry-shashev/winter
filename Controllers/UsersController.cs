namespace Winter.Controllers;

[DefaultController]
public class UsersController : ControllerBase
{
  [HttpGet]
  public ActionResult<string> Get()
  {
    return "It works!";
  }
}
