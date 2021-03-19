using MyMenu.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMenu.Server.Repository.Item
{
    public interface IItemRepository
    {
        Task<object> GetAllItem();
        Task<object> GetItemById(int id);
        Task<object> AddUpdateItem(ItemViewModel Conditions, string UserName);
        Task<object> DeleteItem(int Id);
        Task<object> GetItemByCategoryId(int Id);
    }
}
