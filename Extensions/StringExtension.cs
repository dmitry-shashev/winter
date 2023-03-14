using System.Text.RegularExpressions;

namespace Winter.Extensions;

public static class StringExtension
{
  public static string ToKebabCase(this string value)
  {
    var handledValue = value?.ToString() ?? "";
    return Regex
      .Replace(handledValue, "([a-z])([A-Z])", "$1-$2")
      .ToLower();
  }
}
