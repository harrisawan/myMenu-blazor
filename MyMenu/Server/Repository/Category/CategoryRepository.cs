using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyMenu.Shared.Models;
using MyMenu.Shared.ViewModels;

namespace MyMenu.Server.Repository.Category
{
    public class CategoryRepository: ICategoryRepository
    {
       
        private MyMenuDbContext db;
        public CategoryRepository(MyMenuDbContext context)
        {
            this.db = context;
        }
        public async Task<object> AddUpdateCategory(CategoryViewModel Category, string UserName)
        {

            if (Category.Id ==0)
            {

                db.Category.Add(new Shared.Models.Category
                {
                    CreatedAt = DateTime.Now,
                    MenuId = Category.MenuId,
                    Description = Category.Description,
                    IsDelete = false,
                    IsActive=true,
                    UpdatedAt = DateTime.Now,
                    Name = Category.Name
                   
                });
                await db.SaveChangesAsync();
                return Category;
            }
            else
            {
                var categoryExist = db.Category.Where(x => x.Id == Category.Id).FirstOrDefault();
                if (categoryExist != null)
                {
                    categoryExist.UpdatedAt = DateTime.Now;
                    categoryExist.Name = Category.Name;
                    categoryExist.Description = Category.Description;
                    categoryExist.IsActive = Category.IsActive;
                    categoryExist.MenuId = Category.MenuId;
                    await db.SaveChangesAsync();
                    return categoryExist;
                }
                else
                {
                    return "";
                }
            }
        }

        public async Task<object> DeleteCategory(int Id)
        {
           
            var accountgrp = db.Category.Where(x => x.Id == Id).FirstOrDefault();
            if (accountgrp != null)
            {
                accountgrp.IsDelete = true;
                accountgrp.UpdatedAt = DateTime.Now;
                await db.SaveChangesAsync();
                return accountgrp;
               // return Objectserializer.Serilized("Deleted", 200);
            }
            else
            {
                return "";
            }
        }
        public async Task<object> GetCategoryById(int Id)
        {
            var menu = await db.Category.FindAsync(Id);
            if (menu != null)
            {
                return menu;
            }
            return false;
        }
        public async Task<object> GetAllCategory()
        {
            var menu = await db.Category.Where(x=>x.IsDelete==false).ToListAsync();
            if (menu != null)
            {
                return menu;
            }
            return false;
        }
        public async Task<object> GetCategoryByMenuId(int Id)
        {
            var category = await db.Category.Where(x => x.MenuId == Id && x.IsDelete==false).FirstOrDefaultAsync();
            if (category != null)
            {
                return category;
            }
            return false;
        }
     
    }
}
