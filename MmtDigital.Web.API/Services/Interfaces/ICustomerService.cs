using MmtDigital.DataAccess.Models;

namespace MmtDigital.WebAPI.Services.Interfaces
{
    public interface ICustomerService
    {
        Customer GetCustomerDetails(string email);
    }
}
