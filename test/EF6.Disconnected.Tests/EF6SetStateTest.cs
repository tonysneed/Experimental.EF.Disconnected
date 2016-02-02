using System.Collections.Generic;
using System.Data.Entity;
using Xunit;

namespace EF6.Disconnected.Tests
{
    public class EF6SetStateTest
    {
        private readonly SampleContext _context;

        public EF6SetStateTest()
        {
            _context = new SampleContext();
        }

        [Fact]
        public void Set_state_should_not_mark_single_entity()
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
            Assert.Equal(EntityState.Added, _context.Entry(detail).State);
        }
    }
}
