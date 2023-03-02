using System.Text.RegularExpressions;

namespace Winter.Core.Helpers;

public abstract class StrHelper
{
  public static string ToKebabCase(object? value)
  {
    var handledValue = value?.ToString() ?? "";
    return Regex
      .Replace(handledValue, "([a-z])([A-Z])", "$1-$2")
      .ToLower();
  }
}
