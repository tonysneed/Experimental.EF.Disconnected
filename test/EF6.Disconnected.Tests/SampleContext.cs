using System.Data.Entity;

namespace EF6.Disconnected.Tests
{
    public class SampleContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}
