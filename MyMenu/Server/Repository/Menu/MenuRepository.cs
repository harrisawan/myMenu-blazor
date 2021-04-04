using Microsoft.EntityFrameworkCore;
using MyMenu.Shared.Models;
using MyMenu.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMenu.Server.Repository.Menu
{
    public class MenuRepository : IMenuRepository
    {
        private MyMenuDbContext context;
        public MenuRepository(MyMenuDbContext context)
        {
            this.context = context;
        }
        public async Task<object> AddUpdateMenu(MenuViewModel menuViewModel, string UserName)
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


            //var menu = await context.Menu.FindAsync(menuViewModel.Id);
            //menu.Name = menuViewModel.Name;
            //menu.Description = menuViewModel.Description;
            //menu.UpdatedAt = DateTime.Now;
            //menu.UpdatedBy = UserName;
            //menu.IsActive = menuViewModel.IsActive;
            //context.Menu.Update(menu);
            //await context.SaveChangesAsync();
            //return menu;

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
        public async Task<object> GetAllMenu()
        {
            var menuList = await context.Menu.Where(x => x.IsDelete == false).ToListAsync();
            if (menuList != null)
            {
                return menuList;
            }
            return false;
        }

        public async Task<IEnumerable<Shared.Models.Menu>> GetAllMenuByCompanyId(string companyid)
        {
            return await context.Menu.Where(x => x.CompanyId == int.Parse(companyid)).ToListAsync();
        }

        public async Task<Shared.Models.Menu> AddMenu(MenuViewModel newmenu)
        {
            MyMenu.Shared.Models.Menu menu = new MyMenu.Shared.Models.Menu();
            menu.Name = newmenu.Name;
            menu.Description = newmenu.Description;
            menu.ImgUrl = newmenu.ImgUrl;
            menu.CompanyId = newmenu.CompanyId;
            menu.CreatedAt = DateTime.Now;
            menu.UpdatedAt = DateTime.Now;
            menu.IsActive = newmenu.IsActive;
            menu.IsDelete = false;
            await context.Menu.AddAsync(menu);
            await context.SaveChangesAsync();
            return menu;
        }

        public async Task<object> GetMenuById(long id)
        {
            var menu = await context.Menu.FindAsync(id);
            if (menu != null)
            {
                return menu;
            }
            return false;
        }

        public async Task<Shared.Models.Menu> DeleteMenu(long Id)
        {
            var result = await context.Menu.FirstOrDefaultAsync(e => e.Id == Id);
            var result1 = await context.Category.Where(x => x.MenuId == Id).ToListAsync();
            var result2 = await context.Item.Include(x => x.Category).Where(x => x.Category.MenuId == Id).ToListAsync();
            if (result2 != null)
            {
                context.Item.RemoveRange(result2);
                await context.SaveChangesAsync();
            }
            if (result1 != null)
            {
                context.Category.RemoveRange(result1);
                await context.SaveChangesAsync();
            }
            if (result != null)
            {
                context.Menu.Remove(result);
                await context.SaveChangesAsync();
                return result;
            }

            return null;
        }

        public async Task<Shared.Models.Menu> UpdateMenu(MenuViewModel newmenu, long id)
        {
            var result = await context.Menu
                .FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                result.Name = newmenu.Name;
                result.Description = newmenu.Description;
                result.ImgUrl = newmenu.ImgUrl;
                result.UpdatedAt = DateTime.Now;
                result.IsActive = newmenu.IsActive;
                await context.SaveChangesAsync();
                return result;
            }
            return null;
        }
    }
}
