using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MmtDigital.DataAccess.Models.DTO
{
    public class OrderItemDto
    {
        public string Product { get; set; }
        public int Quantity { get; set; }
        public decimal PriceEach { get; set; }
    }
}
