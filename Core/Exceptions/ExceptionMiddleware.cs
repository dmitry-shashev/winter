using System.Net;
using AspHttpContext = Microsoft.AspNetCore.Http.HttpContext;

namespace Winter.Core.Exceptions;

public class ExceptionMiddleware
{
  private readonly RequestDelegate _next;

  public ExceptionMiddleware(RequestDelegate next)
  {
    _next = next;
  }

  public async Task Invoke(AspHttpContext context)
  {
    try
    {
      await _next(context);
    }
    // handle own custom errors
    catch (NotFoundException ex)
    {
      HandleException(context, ex.StatusCode, ex.Message);
    }
    // override any other errors
    catch
    {
      // here we can send errors or log them
      HandleException(
        context,
        HttpStatusCode.InternalServerError,
        "Internal Server Error"
      );
    }
  }

  private static void HandleException(
    AspHttpContext context,
    HttpStatusCode statusCode,
    string message
  )
  {
    context.Response.ContentType = "application/json";
    context.Response.StatusCode = (int)statusCode;
    context.Response.WriteAsJsonAsync(
      new { Message = message, StatusCode = statusCode, }
    );
  }
}
