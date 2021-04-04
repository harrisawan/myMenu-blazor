using MyMenu.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyMenu.Shared.Models;

namespace MyMenu.Server.Repository.Menu
{
    public interface IMenuRepository
    {
        Task<object> GetAllMenu();
        Task<IEnumerable<MyMenu.Shared.Models.Menu>> GetAllMenuByCompanyId(string companyid);
        Task<object> AddUpdateMenu(MenuViewModel Conditions, string UserName);
        Task<MyMenu.Shared.Models.Menu> AddMenu(MenuViewModel newmenu);
        Task<object> GetMenuById(long id);
        Task<MyMenu.Shared.Models.Menu> DeleteMenu(long Id);
        Task<MyMenu.Shared.Models.Menu> UpdateMenu(MenuViewModel newmenu, long id);
    }
}
