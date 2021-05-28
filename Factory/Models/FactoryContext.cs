using Microsoft.EntityFrameworkCore;

namespace SillyFactory.Models
{
  public class FactoryContext : DbContext
  {
    public virtual DbSet<Engineer> Engineers { get; set; }
    public DbSet<Machine> Machines { get; set; }

    public DbSet<EngineerMachine> EngineerMachine { get; set; }
    
    public FactoryContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}