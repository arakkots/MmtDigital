using Microsoft.EntityFrameworkCore;
using MmtDigital.DataAccess.Models;
using MmtDigital.WebAPI.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace MmtDigital.WebAPI.Services
{
    public class OrderService : IOrderService
    {
        private readonly SSE_TestContext dbContext;

        public OrderService(SSE_TestContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Order GetOrder(string customerId)
        {
            var order = this.GetOrderQuery()
                .OrderByDescending(e => e.OrderDate)
                .FirstOrDefault(e => e.CustomerId == customerId);

            return order;
        }

        private IEnumerable<Order> GetOrderQuery()
        {
            return dbContext.Orders.Include(e => e.OrderItems).ThenInclude(e => e.Product);
        }
    }
}
