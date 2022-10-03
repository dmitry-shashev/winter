namespace Winter.Models.Dto.Response;

public record UserResponseDto(
  Guid Id,
  string FirstName,
  string LastName
);
