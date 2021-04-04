using MyMenu.Shared.Models;
using MyMenu.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMenu.Client.Services.Items
{
    public interface IItemService
    {
        Task<IEnumerable<Item>> GetAllItemByCompanyId(string companyid);
        Task AddNewItem(ItemViewModel addItem);
        Task DeleteItem(long id);
        Task<Item> GetItemById(long itemid);
        Task UpdateItem(ItemViewModel additem, long id);
    }
}
