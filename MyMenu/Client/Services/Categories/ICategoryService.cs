using MyMenu.Shared.Models;
using MyMenu.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMenu.Client.Services.Categories
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetAllCategoryByCompanyId(string companyid);
        Task<Category> AddNewCategory(CategoryViewModel addCategory);
        Task DeleteCategory(int id);
        Task<Category> GetCategoryById(int categoryid);
        Task<Category> UpdateCategory(CategoryViewModel addcategory, int id);
    }
}
