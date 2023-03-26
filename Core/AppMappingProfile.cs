using AutoMapper;

namespace Winter.Core;

public class AppMappingProfile : Profile
{
  public AppMappingProfile()
  {
    CreateMap<User, UserResponseSimpleDto>();
  }
}
