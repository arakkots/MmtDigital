using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MmtDigital.DataAccess.Models;
using MmtDigital.WebAPI.Services.Interfaces;
using System.Collections.Generic;

namespace MmtDigital.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        private readonly ICustomerService customerService;
        private readonly IOrderService orderService;

        public ServicesController(ICustomerService customerService, IOrderService orderService )
        {
            this.customerService = customerService;
            this.orderService = orderService;
        }

        // GET: /api/services/customer/latestOrder
        [HttpGet("customer/latestOrder")]
        //[ProducesResponseType(typeof(latestOrder), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(CutomerLatestOrder), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetCustomerLatestOrder(string user, string customerId)
        {
            CutomerLatestOrder result = new();
            result.Customer = customerService.GetCustomerDetails(user);

            if (result.Customer == null) {
                return NotFound();
            }
            else
            {
                if (result.Customer.CustomerId != customerId)
                {
                    return BadRequest();
                }
            }

            result.Order = orderService.GetOrder(customerId);
            return Ok(result.ToCustomerLatestOrderDto());
        } 
    }


}
