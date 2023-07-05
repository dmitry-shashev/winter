using Winter.Core.Constants;

namespace Winter.Core.Helpers;

public abstract class UserHelper
{
  public static void TestEnums()
  {
    var adminRole = Roles.Admin;

    // parse from name
    if (Roles.TryFromName("Admin", out var parsedRole))
      Console.WriteLine(
        $"Parsed admin role - {parsedRole.Value.Label}"
      );

    // compare
    if (adminRole.Equals(Roles.Admin))
      Console.WriteLine("Roles are equal");

    // custom parsing
    var parsedCustomRole = Roles.ParseFromLabel(
      "Regular Customer"
    );
    Console.WriteLine(
      $"Parsed custom role - {parsedCustomRole?.Value.Label}"
    );
  }
}
