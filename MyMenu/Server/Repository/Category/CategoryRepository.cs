using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyMenu.Shared.Models;
using MyMenu.Shared.ViewModels;

namespace MyMenu.Server.Repository.Category
{
    public class CategoryRepository : ICategoryRepository
    {

        private MyMenuDbContext context;
        public CategoryRepository(MyMenuDbContext context)
        {
            this.context = context;
        }
        
        public async Task<object> GetCategoryById(int Id)
        {
            var menu = await context.Category.FindAsync(Id);
            if (menu != null)
            {
                return menu;
            }
            return false;
        }
        public async Task<object> GetAllCategory()
        {
            var menu = await context.Category.Where(x => x.IsDelete == false).ToListAsync();
            if (menu != null)
            {
                return menu;
            }
            return false;
        }
        public async Task<object> GetCategoryByMenuId(int id)
        {
            var category = await context.Category.FindAsync(id);
            if (category != null)
            {
                return category;
            }
            return false;
        }

        public async Task<IEnumerable<Shared.Models.Category>> GetAllCategoryByCompanyId(string companyid)
        {
            return await context.Category.Where(x => x.CompanyId == int.Parse(companyid)).ToListAsync();
        }

        public async Task<Shared.Models.Category> AddCategory(CategoryViewModel newcategory)
        {
            MyMenu.Shared.Models.Category category = new MyMenu.Shared.Models.Category();
            category.CreatedAt = DateTime.Now;
            category.MenuId = newcategory.MenuId;
            category.Description = newcategory.Description;
            category.IsDelete = false;
            category.IsActive = newcategory.IsActive;
            category.UpdatedAt = DateTime.Now;
            category.Name = newcategory.Name;
            category.CompanyId = newcategory.CompanyId;
            await context.Category.AddAsync(category);
            await context.SaveChangesAsync();
            return category;
        }

        public async Task<Shared.Models.Category> UpdateCategory(CategoryViewModel newcategory, int id)
        {
            var result = await context.Category
               .FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                result.UpdatedAt = DateTime.Now;
                result.Name = newcategory.Name;
                result.Description = newcategory.Description;
                result.IsActive = newcategory.IsActive;
                await context.SaveChangesAsync();
                return result;
            }
            return null;
        }

        public async Task<Shared.Models.Category> DeleteCategory(int id)
        {
            var result = await context.Category.FirstOrDefaultAsync(e => e.Id == id);
            var result2 = await context.Item.Where(x => x.CategoryId == id).ToListAsync();
            if (result2 != null)
            {
                context.Item.RemoveRange(result2);
                await context.SaveChangesAsync();
            }
            if (result != null)
            {
                context.Category.Remove(result);
                await context.SaveChangesAsync();
                return result;
            }

            return null;
        }
    }
}
