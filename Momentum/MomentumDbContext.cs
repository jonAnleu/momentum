using Microsoft.EntityFrameworkCore;

public class MomentumDbContext : DbContext
{
    public MomentumDbContext(DbContextOptions<MomentumDbContext> options)
        : base(options)
    {
    }

    public DbSet<TodoItem> Todos { get; set; }
}
