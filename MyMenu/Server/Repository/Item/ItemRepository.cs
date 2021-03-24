using Microsoft.EntityFrameworkCore;
using MyMenu.Shared.Models;
using MyMenu.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMenu.Server.Repository.Item
{
    public class ItemRepository: IItemRepository
    {
        private MyMenuDbContext context;
        public ItemRepository(MyMenuDbContext context)
        {
            this.context = context;
        }
        public async Task<object> AddUpdateItem(ItemViewModel itemViewModel, string UserName)
        {
            if (itemViewModel.Id == 0)
            {
                MyMenu.Shared.Models.Item item = new MyMenu.Shared.Models.Item();
                item.Name = itemViewModel.Name;
                item.Description = itemViewModel.Description;
                item.ImgUrl = itemViewModel.ImgUrl;
                item.CategoryId = itemViewModel.CategoryId;
                item.Price = itemViewModel.Price;
                item.PriceWithDiscount = itemViewModel.PriceWithDiscount;
                item.CreatedBy = UserName;
                item.CreatedAt = DateTime.Now;
                item.UpdatedBy = UserName;
                item.UpdatedAt = DateTime.Now;
                item.IsActive = true;
                item.IsDelete = false;
                context.Item.Add(item);
                await context.SaveChangesAsync();
                return item;

            }
            else
            {
                var item = await context.Item.FindAsync(itemViewModel.Id);
                item.Name = itemViewModel.Name;
                item.Description = itemViewModel.Description;
                item.ImgUrl = itemViewModel.ImgUrl;
                item.CategoryId = itemViewModel.CategoryId;
                item.Price = itemViewModel.Price;
                item.PriceWithDiscount = itemViewModel.PriceWithDiscount;
                item.UpdatedAt = DateTime.Now;
                item.UpdatedBy = UserName;
                item.IsActive = itemViewModel.IsActive;
                context.Item.Update(item);
                await context.SaveChangesAsync();
                return item;
            }
        }

        public async Task<object> DeleteItem(int Id)
        {
            var item = await context.Item.FindAsync(Id);
            if (item != null)
            {
                item.IsDelete = true;
                item.IsActive = false;
                context.Item.Update(item);
                return true;
            }
            return false;
        }

        public async Task<object> GetItemById(int Id)
        {
            var item = await context.Item.FindAsync(Id);
            if (item != null)
            {
                return item;
            }
            return false;
        }
        public async Task<object> GetItemByCategoryId(int Id)
        {
            var itemList = await context.Item.Where(x=>x.CategoryId==Id).ToListAsync();
            if (itemList != null)
            {
                return itemList;
            }
            return false;
        }
        public async Task<object> GetAllItem()
        {
            var itemList = await context.Item.Where(x => x.IsDelete == false).ToListAsync();
            if (itemList != null)
            {
                return itemList;
            }
            return false;
        }
    }
}
