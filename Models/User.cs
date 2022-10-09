namespace Winter.Models;

public record User(
  int Id,
  string Email,
  string FirstName,
  string LastName,
  string Phone,
  DateTime CreatedAt
);
