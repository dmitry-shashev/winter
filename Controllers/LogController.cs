using Winter.Core.Helpers;

namespace Winter.Controllers;

// This controller has examples of working with logs

[DefaultController]
public class LogController : ControllerBase
{
  private readonly ILogger<LogController> _logger;

  public LogController(ILogger<LogController> logger)
  {
    _logger = logger;
  }

  [HttpGet("write-log")]
  public void WriteLog()
  {
    _logger.LogInformation("------> It works !!!");
  }

  [HttpGet("test")]
  public void Test()
  {
    UserHelper.TestEnums();
  }
}
