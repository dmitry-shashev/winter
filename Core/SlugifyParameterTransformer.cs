using System.Text.RegularExpressions;
using Winter.Core.Helpers;

namespace Winter.Core;

// we are using this class in order to apply auto routes
// transformation into kebab-case
// (works only for class names)

public class SlugifyParameterTransformer
  : IOutboundParameterTransformer
{
  public string? TransformOutbound(object? value)
  {
    return StrHelper.ToKebabCase(value);
  }
}
