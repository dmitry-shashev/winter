using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.Routing;

namespace Winter.Core;

// It encapsulates
//   [ApiController]
//   [Route("[controller]")]

// also adds versions logic

[AttributeUsage(
  AttributeTargets.Assembly | AttributeTargets.Class,
  AllowMultiple = false,
  Inherited = true
)]
public class DefaultControllerAttribute
  : ControllerAttribute,
    IApiBehaviorMetadata,
    IRouteTemplateProvider
{
  private int? _order;

  public string Template =>
    "api/v{version:apiVersion}/[controller]";

  public int Order
  {
    get => _order ?? 0;
    set => _order = value;
  }

  int? IRouteTemplateProvider.Order => _order;

  public string? Name { get; set; }
}
