using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Winter.Core.Seeds;

public class BooksSeed : IEntityTypeConfiguration<Book>
{
  public void Configure(EntityTypeBuilder<Book> builder)
  {
    builder.HasData(
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
    );
  }
}
