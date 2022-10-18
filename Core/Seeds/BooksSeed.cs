using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Winter.Core.Seeds;

public class BooksSeed : IEntityTypeConfiguration<Book>
{
  public void Configure(EntityTypeBuilder<Book> builder)
  {
    builder.HasData(AllDataGenerator.BuildBooks());
  }
}
