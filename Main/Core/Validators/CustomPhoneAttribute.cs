using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Winter.Core.Validators;

[AttributeUsage(
  AttributeTargets.Field
    | AttributeTargets.Property
    | AttributeTargets.Parameter
)]
public sealed class CustomPhoneAttribute
  : ValidationAttribute
{
  public CustomPhoneAttribute()
  {
    ErrorMessage =
      "The phone number is invalid - should be: xx-xx-xx";
  }

  private static readonly string PhoneRegex =
    @"\d\d-\d\d-\d\d";

  public override bool IsValid(object? value)
  {
    var phone = (string?)value;
    if (phone is null)
      return false;

    var match = Regex.Match(PhoneRegex, phone);
    return match.Success;
  }
}
