namespace Winter.Models.Dto.Response;

public record UserResponseDto(
  int Id,
  string Email,
  string FirstName,
  string LastName,
  string Phone,
  IEnumerable<BookResponseDto> Books,
  IEnumerable<LibraryResponseDto> Libraries
);
