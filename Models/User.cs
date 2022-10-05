namespace Winter.Models;

public record User(
  int Id,
  string FirstName,
  string LastName,
  DateTime CreatedAt
);
