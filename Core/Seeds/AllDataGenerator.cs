namespace Winter.Core.Seeds;

public abstract class AllDataGenerator
{
  public static ICollection<User> BuildUsers()
  {
    return new List<User>()
    {
      new User()
      {
        Id = 1,
        Email = "tt1@tt.tt",
        FirstName = "Tester",
        LastName = "Testerov",
        Phone = "12-12-12",
      },
      new User()
      {
        Id = 2,
        Email = "tt2@tt.tt",
        FirstName = "Mike",
        LastName = "Tyson",
        Phone = "13-99-14",
      },
      new User()
      {
        Id = 3,
        Email = "tt3@tt.tt",
        FirstName = "Red",
        LastName = "Sky",
        Phone = "33-33-32",
      }
    };
  }

  public static ICollection<Book> BuildBooks()
  {
    return new List<Book>()
    {
      new Book()
      {
        Id = 1,
        Author = "Jane Austen",
        BookName = "Pride and Prejudice",
        UserId = 1,
      },
      new Book()
      {
        Id = 2,
        Author = "George Orwell",
        BookName = "1984",
        UserId = 1,
      },
      new Book()
      {
        Id = 3,
        Author = "Hamlet",
        BookName = "William Shakespeare",
        UserId = 3,
      }
    };
  }

  public static ICollection<Library> BuildLibraries()
  {
    return new List<Library>()
    {
      new Library()
      {
        Id = 1,
        Address = "Some street",
        Users = new List<User>()
      },
      new Library() { Id = 2, Address = "Work street", }
    };
  }
}
