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

            
               //var item = await context.Item.FindAsync(itemViewModel.Id);
               // item.Name = itemViewModel.Name;
               // item.Description = itemViewModel.Description;
               // item.ImgUrl = itemViewModel.ImgUrl;
               // item.CategoryId = itemViewModel.CategoryId;
               // item.Price = itemViewModel.Price;
               // item.PriceWithDiscount = itemViewModel.PriceWithDiscount;
               // item.UpdatedAt = DateTime.Now;
               // item.UpdatedBy = UserName;
               // item.IsActive = itemViewModel.IsActive;
               // context.Item.Update(item);
               // await context.SaveChangesAsync();
               // return item;
            
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

        public async Task<IEnumerable<Shared.Models.Item>> GetAllItemByCompanyId(string companyid)
        {
            return await context.Item.Where(x => x.CompanyId == int.Parse(companyid)).ToListAsync();
        }

        public async Task AddItem(ItemViewModel newitem)
        {
            MyMenu.Shared.Models.Item item = new MyMenu.Shared.Models.Item();
            item.Name = newitem.Name;
            item.Description = newitem.Description;
            item.ImgUrl = newitem.ImgUrl;
            item.CategoryId = newitem.CategoryId;
            item.CompanyId = newitem.CompanyId;
            item.Price = newitem.Price;
            item.PriceWithDiscount = newitem.PriceWithDiscount;
            item.DiscountId = newitem.DiscountId;
            item.CreatedAt = DateTime.Now;
            item.UpdatedAt = DateTime.Now;
            item.IsActive = newitem.IsActive;
            item.IsDelete = false;
            await context.Item.AddAsync(item);
            await context.SaveChangesAsync();
        }

        public async Task<object> GetItemById(long id)
        {
            var item = await context.Item.FindAsync(id);
            if (item != null)
            {
                return item;
            }
            return false;
        }

        public async Task DeleteItem(long id)
        {
            var result = await context.Item.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                context.Item.Remove(result);
                await context.SaveChangesAsync();
            }
        }

        public async Task UpdateItem(ItemViewModel newitem, long id)
        {
            var result = await context.Item
               .FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                result.ImgUrl = newitem.ImgUrl;
                result.Price = newitem.Price;
                result.PriceWithDiscount = newitem.PriceWithDiscount;
                result.CategoryId = newitem.CategoryId;
                result.DiscountId = newitem.DiscountId;
                result.UpdatedAt = DateTime.Now;
                result.Name = newitem.Name;
                result.Description = newitem.Description;
                result.IsActive = newitem.IsActive;
                context.Item.Update(result);
                await context.SaveChangesAsync();
            }
        }
    }
}
