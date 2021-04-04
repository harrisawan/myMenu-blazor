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
        Task<object> GetItemByCategoryId(int Id);
        Task<IEnumerable<MyMenu.Shared.Models.Item>> GetAllItemByCompanyId(string companyid);
        Task AddItem(ItemViewModel newitem);
        Task<object> GetItemById(long id);
        Task DeleteItem(long id);
        Task UpdateItem(ItemViewModel newitem, long id);
    }
}
