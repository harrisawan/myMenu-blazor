using Microsoft.EntityFrameworkCore;
using MyMenu.Shared.Models;
using MyMenu.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMenu.Server.Repository.Menu
{
    public class MenuRepository:IMenuRepository
    {
        private MyMenuDbContext context;
        public MenuRepository(MyMenuDbContext context)
        {
            this.context = context;
        }
        public async Task<object> AddUpdateMenu(MenuViewModel menuViewModel, string UserName)
        {

            if (menuViewModel.Id == 0)
            {
                MyMenu.Shared.Models.Menu menu = new MyMenu.Shared.Models.Menu();
                menu.Name = menuViewModel.Name;
                menu.Description = menuViewModel.Description;
                menu.ImgUrl = menuViewModel.ImgUrl;
                menu.CompanyId = menuViewModel.CompanyId;
                menu.CreatedBy = UserName;
                menu.CreatedAt = DateTime.Now;
                menu.UpdatedBy = UserName;
                menu.UpdatedAt = DateTime.Now;
                menu.IsActive = true;
                menu.IsDelete = false;
                context.Menu.Add(menu);
                await context.SaveChangesAsync();
                return menu;

            }
            else
            {
                var menu = await context.Menu.FindAsync(menuViewModel.Id);
                menu.Name = menuViewModel.Name;
                menu.Description = menuViewModel.Description;
                menu.UpdatedAt = DateTime.Now;
                menu.UpdatedBy = UserName;
                menu.IsActive = menuViewModel.IsActive;
                context.Menu.Update(menu);
                await context.SaveChangesAsync();
                return menu;
            }
        }

        public async Task<object> DeleteMenu(int Id)
        {
            var menu = await context.Menu.FindAsync(Id);
            if (menu != null)
            {
                menu.IsDelete = true;
                context.Menu.Update(menu);
                return true;
            }
            return false;
        }

        public async Task<object> GetMenuById(int Id)
        {
            var menu = await context.Menu.FindAsync(Id);
            if (menu != null)
            {
                return menu;
            }
            return false;
        }
        public async Task<object> GetMenuByCompanyId(int Id)
        {
            var menu = await context.Menu.Where(x=>x.CompanyId==Id).FirstOrDefaultAsync();
            if (menu != null)
            {
                return menu;
            }
            return false;
        }
        public async Task<object> GetAllMenu()
        {
            var menuList = await context.Menu.Where(x => x.IsDelete == false).ToListAsync();
            if (menuList != null)
            {
                return menuList;
            }
            return false;
        }
    }
}
