using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Winter.Core.Seeds;

public class UsersSeed : IEntityTypeConfiguration<User>
{
  public void Configure(EntityTypeBuilder<User> builder)
  {
    // create users
    var userOne = new User()
    {
      Id = 1,
      Email = "tt1@tt.tt",
      FirstName = "Tester",
      LastName = "Testerov",
      Phone = "12-12-12",
    };
    var userTwo = new User()
    {
      Id = 2,
      Email = "tt2@tt.tt",
      FirstName = "Mike",
      LastName = "Tyson",
      Phone = "13-99-14",
    };
    var userThree = new User()
    {
      Id = 3,
      Email = "tt3@tt.tt",
      FirstName = "Red",
      LastName = "Sky",
      Phone = "33-33-32",
    };
    builder.HasData(userOne, userTwo, userThree);
  }
}
