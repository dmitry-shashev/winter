using Microsoft.EntityFrameworkCore;

namespace Winter.Core;

public class ApplicationDbContext : DbContext
{
  public DbSet<User> Users => Set<User>();

  public ApplicationDbContext(
    DbContextOptions<ApplicationDbContext> options
  ) : base(options) { }
}
