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
        "12-12-12",
        DateTime.Now
      ),
      new User(
        2,
        "tt2@tt.tt",
        "Mike",
        "Tyson",
        "13-99-14",
        DateTime.Now
      ),
      new User(
        3,
        "tt3@tt.tt",
        "Red",
        "Sky",
        "33-33-32",
        DateTime.Now
      )
    );
  }
}
