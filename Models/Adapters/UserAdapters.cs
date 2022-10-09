using Winter.Models.Dto.Response;

namespace Winter.Models.Adapters;

public static class UserAdapters
{
  public static UserResponseDto AsResponseDto(
    this User user
  )
  {
    return new UserResponseDto(
      user.Id,
      user.Email,
      user.FirstName,
      user.LastName,
      user.Phone
    );
  }
}
