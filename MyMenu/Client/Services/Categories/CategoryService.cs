using MyMenu.Shared.Models;
using MyMenu.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace MyMenu.Client.Services.Categories
{
    public class CategoryService : ICategoryService
    {
        private readonly HttpClient httpClient;
        public CategoryService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<Category> AddNewCategory(CategoryViewModel addCategory)
        {
            var result = await httpClient.PostAsJsonAsync("api/category/addnewcategory", addCategory);
            var res = result.Content.ReadFromJsonAsync<Category>();
            return await res;
        }
        public async Task DeleteCategory(int id)
        {
            await httpClient.DeleteAsync($"api/category/DeleteCategory/{id}");
        }

        public async Task<IEnumerable<Category>> GetAllCategoryByCompanyId(string companyid)
        {
            return await httpClient.GetFromJsonAsync<Category[]>($"api/category/getallcategorybycompanyid/{companyid}");
        }

        public async Task<Category> GetCategoryById(int categoryid)
        {
            return await httpClient.GetFromJsonAsync<Category>($"api/category/getcategorybyid/{categoryid}");
        }

        public async Task<Category> UpdateCategory(CategoryViewModel addcategory, int id)
        {
            var result = await httpClient.PostAsJsonAsync($"api/category/updatecategory/{id}", addcategory);
            var res = result.Content.ReadFromJsonAsync<Category>();
            return await res;
        }


        

    }
}
