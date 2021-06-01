using MmtDigital.DataAccess.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MmtDigital.DataAccess.Models
{
    public class CutomerLatestOrder
    {
        public Customer Customer { get; set; }
        public Order Order { get; set; }

        public CustomerLatestOrderDto ToCustomerLatestOrderDto()
        {
            CustomerLatestOrderDto model = new CustomerLatestOrderDto
            {
                Customer = new CustomerDto
                {
                    FirstName = Customer.FirstName,
                    LastName = this.Customer.LastName
                },
                Order = new OrderDto
                {
                    OrderNumber = this.Order.OrderId,
                    OrderDate = this.Order.OrderDate.Value.ToString("dd-MMM-yyyy"),
                    DeliveryAddress = $"{this.Customer.HouseNumber}, {this.Customer.Street}, {this.Customer.Town}, {this.Customer.Postcode}",
                    OrderItems = Order.OrderItems.Select(oi => new OrderItemDto
                    { 
                        Product = Order.ContainsGift.Value?"Gift":oi.Product.ProductName,
                        Quantity = oi.Quantity.Value,
                        PriceEach = oi.Price.Value
                    }),
                    DeliveryExpected = this.Order.DeliveryExpected.Value.ToString("dd-MMM-yyyy")
                }
            };

            return model;
        }
    }
}
