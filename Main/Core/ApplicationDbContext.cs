using Microsoft.EntityFrameworkCore;
using Winter.Core.Seeds;

namespace Winter.Core;

public class ApplicationDbContext : DbContext
{
  public DbSet<User> Users => Set<User>();
  public DbSet<Book> Books => Set<Book>();
  public DbSet<Library> Libraries => Set<Library>();

  public DbSet<UploadedFile> UploadedFiles =>
    Set<UploadedFile>();

  public ApplicationDbContext(
    DbContextOptions<ApplicationDbContext> options
  )
    : base(options) { }

  protected override void OnModelCreating(
    ModelBuilder modelBuilder
  )
  {
    // apply seeds
    modelBuilder.ApplyConfiguration(new UsersSeed());
    modelBuilder.ApplyConfiguration(new BooksSeed());
    modelBuilder.ApplyConfiguration(new LibrariesSeed());

    // bind many to many data
    modelBuilder.Entity(
      "LibraryUser",
      builder =>
      {
        builder.HasData(
          new { LibrariesId = 1, UsersId = 1 }
        );
        builder.HasData(
          new { LibrariesId = 1, UsersId = 2 }
        );
        builder.HasData(
          new { LibrariesId = 2, UsersId = 3 }
        );
      }
    );

    // example how we can do one to many using different fields
    // modelBuilder.Entity<User>()
    // 	.HasMany(c => c.Books)
    // 	.WithOne()
    // 	.HasForeignKey(v => v.SomeId)
    // 	.HasPrincipalKey(v => v.SomeOtherId);
  }
}
