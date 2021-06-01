using System;
using System.Collections.Generic;

namespace MmtDigital.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime? DeliveryExpected { get; set; }
        public bool ContainsGift { get; set; }
        public string ShippingMode { get; set; }
        public string OrderSource { get; set; }

        //public Customer Customer { get; set; }
        public List<OrderItem> OrderItems { get; set; }
    }
}
