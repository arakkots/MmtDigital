using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MmtDigital.DataAccess.Models.DTO
{
    public class CustomerLatestOrderDto
    {
        public CustomerDto Customer { get; set; }
        public OrderDto Order { get; set; }
    }
}
