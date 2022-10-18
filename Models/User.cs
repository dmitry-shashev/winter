namespace Winter.Models;

public class User
{
  public int Id { get; init; }
  public string Email { get; init; } = "";
  public string FirstName { get; set; } = "";
  public string LastName { get; set; } = "";
  public string Phone { get; set; } = "";
  public DateTime CreatedAt { get; init; } = DateTime.Now;

  // one to many
  public ICollection<Book> Books { get; set; } =
    new List<Book>();

  // many to many
  public ICollection<Library> Libraries { get; set; } =
    new List<Library>();
}
