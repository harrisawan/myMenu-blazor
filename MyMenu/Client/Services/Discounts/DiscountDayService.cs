using MyMenu.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace MyMenu.Client.Services.Discounts
{
    public class DiscountDayService : IDiscountDayService
    {
        private readonly HttpClient httpClient;
        public DiscountDayService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<IEnumerable<DaysOfWeek>> GetAllDays()
        {
            return await httpClient.GetFromJsonAsync<DaysOfWeek[]>($"api/discountday/getalldiscountday");
        }
    }
}
