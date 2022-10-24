using System.ComponentModel.DataAnnotations;

namespace Winter.Models.Dto.Request;

public record LoginRequestDto(
  [Required] [EmailAddress] string Email,
  [Required]
  [StringLength(50, MinimumLength = 6)]
    string Password
);
