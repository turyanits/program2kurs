using Lab1;
using Microsoft.EntityFrameworkCore;
namespace Lab1.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        {
        }

        public DbSet<Delivery> Deliveries { get; set; }
    }
}