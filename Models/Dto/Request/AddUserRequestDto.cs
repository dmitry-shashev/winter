using System.ComponentModel.DataAnnotations;
using Winter.Core.Validators;

namespace Winter.Models.Dto.Request;

public record AddUserRequestDto(
  [Required] [EmailAddress] string Email,
  [Required]
  [StringLength(50, MinimumLength = 2)]
    string FirstName,
  [Required]
  [StringLength(50, MinimumLength = 2)]
    string LastName,
  [Required] [CustomPhone] string Phone
);
