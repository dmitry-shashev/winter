namespace Winter.Models;

public class User
{
  public int Id { get; init; }
  public List<Book> Books { get; init; } = new List<Book>();
  public string Email { get; init; } = "";
  public string FirstName { get; set; } = "";
  public string LastName { get; set; } = "";
  public string Phone { get; set; } = "";
  public DateTime CreatedAt { get; init; } = DateTime.Now;
}
