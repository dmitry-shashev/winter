using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using Microsoft.AspNetCore.Mvc.Routing;
using Winter.Core.Helpers;

namespace Winter.Core;

// It encapsulates transforming names to kebab case

// for classes - we are using - SlugifyParameterTransformer.cs

[AttributeUsage(
  AttributeTargets.Method,
  AllowMultiple = true,
  Inherited = true
)]
public class HttpGetForAttribute
  : Attribute,
    IActionHttpMethodProvider,
    IRouteTemplateProvider
{
  private int? _order;

  public HttpGetForAttribute(string methodName)
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
