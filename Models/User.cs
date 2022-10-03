namespace Winter.Models;

public record User(
  Guid Id,
  string FirstName,
  string LastName,
  DateTime CreatedAt
);
