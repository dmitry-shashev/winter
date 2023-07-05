namespace Winter.Core.Seeds;

public abstract class AllDataGenerator
{
  public static ICollection<User> BuildUsers()
  {
    return new List<User>()
    {
      new()
      {
        Id = 1,
        Email = "tt1@tt.tt",
        FirstName = "Tester",
        LastName = "Testerov",
        Role = "Admin",
        Password = "123456",
        Phone = "12-12-12"
      },
      new()
      {
        Id = 2,
        Email = "tt2@tt.tt",
        FirstName = "Mike",
        LastName = "Tyson",
        Role = "",
        Password = "123456",
        Phone = "13-99-14"
      },
      new()
      {
        Id = 3,
        Email = "tt3@tt.tt",
        FirstName = "Red",
        LastName = "Sky",
        Role = "Owner",
        Password = "123456",
        Phone = "33-33-32"
      }
    };
  }

  public static ICollection<Book> BuildBooks()
  {
    return new List<Book>()
    {
      new()
      {
        Id = 1,
        Author = "Jane Austen",
        BookName = "Pride and Prejudice",
        UserId = 1
      },
      new()
      {
        Id = 2,
        Author = "George Orwell",
        BookName = "1984",
        UserId = 1
      },
      new()
      {
        Id = 3,
        Author = "Hamlet",
        BookName = "William Shakespeare",
        UserId = 3
      }
    };
  }

  public static ICollection<Library> BuildLibraries()
  {
    return new List<Library>()
    {
      new()
      {
        Id = 1,
        Address = "Some street",
        Users = new List<User>()
      },
      new() { Id = 2, Address = "Work street" }
    };
  }
}
