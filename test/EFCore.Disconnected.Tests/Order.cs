using System.Collections.Generic;

namespace EFCore.Disconnected.Tests
{
    public class Order
    {
        public int OrderId { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
