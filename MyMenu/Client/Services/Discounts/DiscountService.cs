using MyMenu.Shared.Models;
using MyMenu.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace MyMenu.Client.Services.Discounts
{
    public class DiscountService : IDiscountService
    {
        private readonly HttpClient httpClient;
        public DiscountService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task AddNewDiscount(DiscountViewModel discount)
        {
           var res= await httpClient.PostAsJsonAsync("api/discount/addnewdiscount", discount);
        }

        public async Task DeleteDiscount(int id)
        {
            await httpClient.DeleteAsync($"api/discount/DeleteDiscount/{id}");
        }

        public async Task<IEnumerable<DiscountPeriods>> GetAllDiscountByCompanyId(string companyid)
        {
            return await httpClient.GetFromJsonAsync<DiscountPeriods[]>($"api/discount/getalldiscountbycompanyid/{companyid}");
        }

        public async Task<DiscountPeriods> GetDiscountById(int discountid)
        {
            return await httpClient.GetFromJsonAsync<DiscountPeriods>($"api/discount/getdiscountbyid/{discountid}");
        }

        public async Task<IEnumerable<DiscountTransaction>> GetDiscountTransactionByDiscountId(int discountid)
        {
            return await httpClient.GetFromJsonAsync<DiscountTransaction[]>($"api/discount/gettransactionbydiscountbyid/{discountid}");
        }

        public async Task UpdateDiscount(DiscountViewModel adddiscount, int id)
        {
            var result = await httpClient.PostAsJsonAsync($"api/discount/Updatediscount/{id}", adddiscount);
        }
    }
}
