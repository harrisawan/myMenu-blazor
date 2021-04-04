using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyMenu.Shared.ViewModels;
namespace MyMenu.Server.Repository.Category
{
    public interface ICategoryRepository
    {
        Task<object> GetAllCategory();
        Task<IEnumerable<MyMenu.Shared.Models.Category>> GetAllCategoryByCompanyId(string companyid);
        Task<MyMenu.Shared.Models.Category> AddCategory(CategoryViewModel newcategory);
        Task<object> GetCategoryById(int id);
        Task<MyMenu.Shared.Models.Category> DeleteCategory(int id);
        Task<MyMenu.Shared.Models.Category> UpdateCategory(CategoryViewModel newcategory, int id);
        Task<object> GetCategoryByMenuId(int Id);
    }
}
