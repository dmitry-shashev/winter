using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Winter.Core.Seeds;

public class UsersSeed : IEntityTypeConfiguration<User>
{
  public void Configure(EntityTypeBuilder<User> builder)
  {
    builder.HasData(
      new User(
        1,
        "tt1@tt.tt",
        "Tester",
        "Testerov",
        DateTime.Now
      ),
      new User(
        2,
        "tt2@tt.tt",
        "Mike",
        "Tyson",
        DateTime.Now
      ),
      new User(3, "tt3@tt.tt", "Red", "Sky", DateTime.Now)
    );
  }
}
