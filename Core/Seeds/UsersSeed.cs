using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Winter.Core.Seeds;

public class UsersSeed : IEntityTypeConfiguration<User>
{
  public void Configure(EntityTypeBuilder<User> builder)
  {
    builder.HasData(
      new User(1, "Tester", "Testerov", DateTime.Now),
      new User(2, "Mike", "Tyson", DateTime.Now),
      new User(3, "Red", "Sky", DateTime.Now)
    );
  }
}
