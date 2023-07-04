namespace Winter.Models;

public class Book
{
  public int Id { get; init; }
  public string Author { get; set; } = "";
  public string BookName { get; set; } = "";
  public int UserId { get; init; }

  // one to many
  public User? User { get; init; }
}
