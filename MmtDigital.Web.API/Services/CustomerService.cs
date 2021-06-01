using Microsoft.Extensions.Configuration;
using MmtDigital.DataAccess.Models;
using MmtDigital.WebAPI.Services.Interfaces;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;

namespace MmtDigital.WebAPI.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly HttpClient client;
        private readonly IConfiguration configuration;

        public CustomerService(HttpClient client, IConfiguration configuration)
        {
            this.client = client;
            this.configuration = configuration;
        }

        public Customer GetCustomerDetails(string email)
        {
            var apiCode = configuration["CustomerDetailsApi:ApiKey"];
            HttpResponseMessage response = client.GetAsync($"GetUserDetails?code={apiCode}&email={email}").Result;

            return response.StatusCode == HttpStatusCode.NotFound ||
                response.StatusCode == HttpStatusCode.BadRequest ||
                response.StatusCode == HttpStatusCode.InternalServerError
                    ? default(Customer)
                    : JsonConvert.DeserializeObject<Customer>(response.Content.ReadAsStringAsync().Result);
        }
    }
}
 