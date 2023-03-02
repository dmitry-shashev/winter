using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using Microsoft.AspNetCore.Mvc.Routing;
using Winter.Core.Helpers;

namespace Winter.Core;

[AttributeUsage(
  AttributeTargets.Method,
  AllowMultiple = true,
  Inherited = true
)]
public class HttpGetDefaultAttribute
  : Attribute,
    IActionHttpMethodProvider,
    IRouteTemplateProvider
{
  private int? _order;

  public HttpGetDefaultAttribute(string methodName)
  {
    Template = StrHelper.ToKebabCase(methodName);
  }

  public IEnumerable<string> HttpMethods => new[] { "GET" };

  public string? Template { get; }

  public int Order
  {
    get => _order ?? 0;
    set => _order = value;
  }

  int? IRouteTemplateProvider.Order => _order;

  [DisallowNull]
  public string? Name { get; set; }
}