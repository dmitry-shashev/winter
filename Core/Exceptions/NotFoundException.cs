using System.Net;

namespace Winter.Core.Exceptions;

public class NotFoundException : Exception
{
  public HttpStatusCode StatusCode { get; init; }

  public NotFoundException(string message)
    : base(message)
  {
    StatusCode = HttpStatusCode.NotFound;
  }
}
