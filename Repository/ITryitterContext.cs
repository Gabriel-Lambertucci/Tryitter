using Microsoft.EntityFrameworkCore;
using Tryitter.Models;

namespace Tryitter.Repository
{
    interface ITryitterContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Post> Posts { get; set; }
        public int SaveChanges();
    }

}



