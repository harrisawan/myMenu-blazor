using MyMenu.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMenu.Server.Repository.Menu
{
    public interface IMenuRepository
    {
        Task<object> GetAllMenu();
        Task<object> GetMenuById(int id);
        Task<object> AddUpdateMenu(MenuViewModel Conditions, string UserName);
        Task<object> DeleteMenu(int Id);
        Task<object> GetMenuByCompanyId(int Id);
    }
}
