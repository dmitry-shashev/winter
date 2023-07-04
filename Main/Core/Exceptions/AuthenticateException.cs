using System.Net;

namespace Winter.Core.Exceptions;

public class AuthenticateException : Exception
{
  public HttpStatusCode StatusCode { get; init; }

  public AuthenticateException()
    : base("Authentication failed")
  {
    StatusCode = HttpStatusCode.Forbidden;
  }
}
