using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;

namespace EFCore.Disconnected.Tests
{
    public class SampleContext : DbContext
    {
        public SampleContext() { }
        public SampleContext(DbContextOptions options) : base(options) { }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}
