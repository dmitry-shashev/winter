namespace Winter.Models.Dto.Response;

public record UserResponseSimpleDto(
  int Id,
  string Email,
  string FirstName,
  string LastName,
  string Phone
);
