namespace Winter.Extensions;

public static class BoolExtension
{
  public static sbyte? ToSByte(this bool? value)
  {
    return value.ToValue<sbyte?>(1, 0);
  }

  public static T ToValue<T>(
    this bool? value,
    T trueValue,
    T falseValue
  )
  {
    if (value is null or false)
      return falseValue;

    return trueValue;
  }

  public static T ToValue<T>(
    this bool value,
    T trueValue,
    T falseValue
  )
  {
    return value ? trueValue : falseValue;
  }
}
