using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Winter.Core.Seeds;

public class LibrariesSeed
  : IEntityTypeConfiguration<Library>
{
  public void Configure(EntityTypeBuilder<Library> builder)
  {
    builder.HasData(AllDataGenerator.BuildLibraries());
  }
}
