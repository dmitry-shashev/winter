using Microsoft.EntityFrameworkCore;
using Winter.Core.Seeds;

namespace Winter.Core;

public class ApplicationDbContext : DbContext
{
  public DbSet<User> Users => Set<User>();
  public DbSet<Book> Books => Set<Book>();

  public ApplicationDbContext(
    DbContextOptions<ApplicationDbContext> options
  ) : base(options) { }

  protected override void OnModelCreating(
    ModelBuilder modelBuilder
  )
  {
    // apply seeds
    modelBuilder.ApplyConfiguration(new UsersSeed());
    modelBuilder.ApplyConfiguration(new BooksSeed());
  }
}
