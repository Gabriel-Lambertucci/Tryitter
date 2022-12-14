using Microsoft.EntityFrameworkCore;
using Tryitter.Models;

namespace Tryitter.Repository

{

  class TryitterContext : DbContext, ITryitterContext
  {
    public DbSet<Student> Students { get; set; }
    public DbSet<Post> Posts { get; set; }
   
    public TryitterContext(DbContextOptions<TryitterContext> options) : base(options) { }
    public TryitterContext() { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.EnableSensitiveDataLogging();
        if(!optionsBuilder.IsConfigured){
            optionsBuilder.UseSqlServer(@"
                Server=127.0.0.1;
                Database=tryitter_db;
                User=SA;
                Password=ps3rules;
            ");
        }
    }
  }
}