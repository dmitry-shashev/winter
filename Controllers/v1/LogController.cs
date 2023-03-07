namespace Winter.Controllers.v1;

// This controller has examples of working with logs

[DefaultController]
public class LogController : ControllerBase
{
  private readonly ILogger<LogController> _logger;

  public LogController(ILogger<LogController> logger)
  {
    _logger = logger;
  }

  [HttpGetFor(nameof(WriteLog))]
  public void WriteLog()
  {
    _logger.LogInformation("------> It works !!!");
  }
}
