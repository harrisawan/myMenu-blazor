using MyMenu.Shared.Models;
using MyMenu.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace MyMenu.Client.Services.Menus
{
    public class MenuService : IMenuService
    {
        private readonly HttpClient httpClient;
        public MenuService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<Menu>> GetAllMenuByCompanyId(string companyid)
        {
            return await httpClient.GetFromJsonAsync<Menu[]>($"api/menu/getallmenubycompanyid/{companyid}");
        }
        public async Task<Menu> AddNewMenu(MenuViewModel addMenu)
        {
            var result = await httpClient.PostAsJsonAsync("api/menu/addnewmenu", addMenu);
            var res = result.Content.ReadFromJsonAsync<Menu>();
            return await res;
        }

        public async Task DeleteMenu(long id)
        {
            await httpClient.DeleteAsync($"api/menu/DeleteMenu/{id}");
        }

        public async Task<Menu> GetMenuById(long menuid)
        {
            return await httpClient.GetFromJsonAsync<Menu>($"api/menu/GetMenuById/{menuid}");
        }

        public async Task<Menu> UpdateMenu(MenuViewModel addmenu, long id)
        {
            var result = await httpClient.PostAsJsonAsync($"api/menu/UpdateMenu/{id}", addmenu);
            var res = result.Content.ReadFromJsonAsync<Menu>();
            return await res;
        }

    }
}
