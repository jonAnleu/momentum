using Microsoft.EntityFrameworkCore;

public class MomentumDbContext : DbContext
{
  public DbSet<Workout> Workout { get; set; }

  public MomentumDbContext(DbContextOptions<MomentumDbContext> options)
  : base(options)
  {}
}