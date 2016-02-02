using System.Collections.Generic;

namespace EF6.Disconnected.Tests
{
    public class Order
    {
        public int OrderId { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
