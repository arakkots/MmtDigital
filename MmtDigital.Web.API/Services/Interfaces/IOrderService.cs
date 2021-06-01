using MmtDigital.DataAccess.Models;

namespace MmtDigital.WebAPI.Services.Interfaces
{
    public interface IOrderService
    {
        Order GetOrder(string customerId);
    }
}
