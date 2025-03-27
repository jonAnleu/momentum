using Microsoft.EntityFrameworkCore;

public class MomentumDbContext : DbContext
{
  public DbSet<Run> Run { get; set; }

  public MomentumDbContext(DbContextOptions<MomentumDbContext> options)
  : base(options)
  {}
}