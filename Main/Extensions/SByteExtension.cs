namespace Winter.Extensions;

public static class SByteExtension
{
  public static bool? ToBool(this sbyte? value)
  {
    if (value is null)
      return null;

    if (value == 0)
      return false;

    return true;
  }
}
