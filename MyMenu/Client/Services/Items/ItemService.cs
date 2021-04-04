using MyMenu.Shared.Models;
using MyMenu.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace MyMenu.Client.Services.Items
{
    public class ItemService : IItemService
    {
        private readonly HttpClient httpClient;
        public ItemService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task AddNewItem(ItemViewModel addItem)
        {
            var result = await httpClient.PostAsJsonAsync("api/items/addnewitem", addItem);
        }

        public async Task DeleteItem(long id)
        {
            var result =await httpClient.DeleteAsync($"api/items/deleteitem/{id}");
        }

        public async Task<IEnumerable<Item>> GetAllItemByCompanyId(string companyid)
        {
            return await httpClient.GetFromJsonAsync<Item[]>($"api/items/getallitembycompanyid/{companyid}");
        }

        public async Task<Item> GetItemById(long itemid)
        {
            return await httpClient.GetFromJsonAsync<Item>($"api/items/getitembyid/{itemid}");
        }

        public async Task UpdateItem(ItemViewModel additem, long id)
        {
            var result = await httpClient.PostAsJsonAsync($"api/items/updateitem/{id}", additem);
        }
    }
}
