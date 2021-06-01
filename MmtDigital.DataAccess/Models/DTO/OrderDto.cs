using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MmtDigital.DataAccess.Models.DTO
{
    public class OrderDto
    {
        public int OrderNumber { get; set; }
        public string OrderDate { get; set; }
        public string DeliveryAddress { get; set; }
        public IEnumerable<OrderItemDto> OrderItems { get; set; }
        public string DeliveryExpected { get; set; }
    }
}
