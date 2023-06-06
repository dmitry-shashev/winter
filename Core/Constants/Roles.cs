using Ardalis.SmartEnum;

namespace Winter.Core.Constants;

// might be better to have some base-id role

public class RoleValue
  : IComparable<RoleValue>,
    IEquatable<RoleValue>
{
  public readonly int Id;

  public readonly string Label;

  public readonly string Value;

  public RoleValue(int id, string label, string value)
  {
    Id = id;
    Label = label;
    Value = value;
  }

  public int CompareTo(RoleValue? other)
  {
    return this.Id - other?.Id ?? 0;
  }

  public bool Equals(RoleValue? other)
  {
    return this.Id == other?.Id;
  }

  public override bool Equals(object? obj)
  {
    return Equals(obj as RoleValue);
  }

  public override int GetHashCode()
  {
    return HashCode.Combine(Id);
  }
}

public sealed class Roles : SmartEnum<Roles, RoleValue>
{
  //--------------------------------------------------------------------
  // possible values

  public static readonly Roles Admin =
    new(nameof(Admin), new RoleValue(1, "Admin", "admin"));

  public static readonly Roles RegularCustomer =
    new(
      nameof(RegularCustomer),
      new RoleValue(
        2,
        "Regular Customer",
        "regular_customer"
      )
    );

  //--------------------------------------------------------------------

  private Roles(string name, RoleValue value)
    : base(name, value) { }

  public static Roles? ParseFromLabel(string label)
  {
    return List.FirstOrDefault(v => v.Value.Label == label);
  }
}
