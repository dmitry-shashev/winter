using Microsoft.EntityFrameworkCore;
using Winter.Core.Seeds;
using Xunit;

namespace Winter.Services;

// install
//  dotnet add package Microsoft.EntityFrameworkCore.InMemory --version 7.0.5

public static class UserServiceTest
{
  [Fact]
  public static void GetById()
  {
    var options =
      new DbContextOptionsBuilder<ApplicationDbContext>()
        .UseInMemoryDatabase(databaseName: "winter")
        .Options;
    using var context = new ApplicationDbContext(options);

    // seed
    context.Users.AddRange(AllDataGenerator.BuildUsers());
    context.Books.AddRange(AllDataGenerator.BuildBooks());
    context.Libraries.AddRange(
      AllDataGenerator.BuildLibraries()
    );
    context.SaveChanges();

    // check
    UsersService usersService = new UsersService(context);
    var user = usersService.GetById(2);

    Assert.Equal("tt2@tt.tt", user.Email);
  }
}
