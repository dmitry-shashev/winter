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

  public static bool IsEmpty(string? value)
  {
    if (value is null)
      return true;
    return value.Trim() == "";
  }

  public static string DetermineFileContentType(
    string fileName
  )
  {
    var contentType = "";
    if (
      fileName.IndexOf(
        ".pdf",
        StringComparison.OrdinalIgnoreCase
      ) >= 0
    )
      contentType = "application/pdf";
    if (
      fileName.IndexOf(
        ".jpg",
        StringComparison.OrdinalIgnoreCase
      ) >= 0
      || fileName.IndexOf(
        ".jpeg",
        StringComparison.OrdinalIgnoreCase
      ) >= 0
    )
      contentType = "image/jpeg";

    return contentType;
  }
}
