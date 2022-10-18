namespace Winter.Models;

public class Library
{
  public int Id { get; init; }
  public string Address { get; set; } = "";

  // many to many
  public ICollection<User> Users { get; set; } =
    new List<User>();
}
