using Microsoft.Data.Entity;
using System.Collections.Generic;
using Xunit;

namespace EFCore.Disconnected.Tests
{
    public class EFCoreSetStateTest
    {
        private readonly SampleContext _context;

        public EFCoreSetStateTest()
        {
            var builder = new DbContextOptionsBuilder();
            builder.UseInMemoryDatabase();
            _context = new SampleContext(builder.Options);
        }

        [Fact]
        public void Set_state_should_mark_single_entity()
        {
            // Arrange
            var detail = new OrderDetail();
            var order = new Order
            {
                OrderDetails = new List<OrderDetail> { detail }
            };

            // Act
            _context.Entry(order).State = EntityState.Added;

            // Assert
            Assert.Equal(EntityState.Detached, _context.Entry(detail).State);
        }
    }
}
