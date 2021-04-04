using MyMenu.Shared.Models;
using MyMenu.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMenu.Client.Services.Menus
{
    public interface IMenuService
    {
        Task<IEnumerable<Menu>> GetAllMenuByCompanyId(string companyid);
        Task<Menu> AddNewMenu(MenuViewModel addMenu);
        Task DeleteMenu(long id);
        Task<Menu> GetMenuById(long menuid);
        Task<Menu> UpdateMenu(MenuViewModel addmenu, long id);
    }
}
