using Microsoft.EntityFrameworkCore;
using MyMenu.Shared.Models;
using MyMenu.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMenu.Server.Repository.Discount
{
    public class DiscountRepository:IDiscountRepository
    {

        private MyMenuDbContext context;
        public DiscountRepository(MyMenuDbContext context)
        {
            this.context = context;
        }
        public async Task<object> AddUpdateDiscount(DiscountViewModel itemViewModel, string UserName)
        {

            if (itemViewModel.Id == 0)
            {
                DiscountPeriods item = new DiscountPeriods();
                item.ItemId = itemViewModel.ItemId;
                item.FromDate = itemViewModel.FromDate;
                item.ToDate = itemViewModel.ToDate;
                item.FromTime = itemViewModel.FromTime;
                item.ToTime = itemViewModel.ToTime;
                item.CreatedAt = DateTime.Now;
                item.UpdatedAt = DateTime.Now;
                item.IsActive = true;
                item.IsDelete = false;
                context.DiscountPeriods.Add(item);
                await context.SaveChangesAsync();
                foreach (var day in itemViewModel.daysOfWeek.Where(x=>x.IsChecked==true))
                {
                    DiscountTransaction transaction = new DiscountTransaction();
                    transaction.DiscountPeriodId = item.Id;
                    transaction.DayId = day.Id;
                }
                await context.SaveChangesAsync();
                return item;

            }
            else
            {
                var item = await context.DiscountPeriods.FindAsync(itemViewModel.Id);
                item.ItemId = itemViewModel.ItemId;
                item.FromDate = itemViewModel.FromDate;
                item.ToDate = itemViewModel.ToDate;
                item.FromTime = itemViewModel.FromTime;
                item.ToTime = itemViewModel.ToTime;
                item.CreatedAt = DateTime.Now;
                item.UpdatedAt = DateTime.Now;
                item.IsActive = itemViewModel.IsActive;
                context.DiscountPeriods.Update(item);
                await context.SaveChangesAsync();
                var DaysOff = await context.DiscountTransaction.Where(x => x.DiscountPeriodId == itemViewModel.Id).ToListAsync();
                foreach (var day in DaysOff)
                {
                    context.DiscountTransaction.Remove(day);
                    await context.SaveChangesAsync();
                }
                foreach (var day in itemViewModel.daysOfWeek.Where(x => x.IsChecked == true))
                {
                    DiscountTransaction transaction = new DiscountTransaction();
                    transaction.DiscountPeriodId = item.Id;
                    transaction.DayId = day.Id;
                    await context.SaveChangesAsync();
                }
                return item;
            }
        }

        public async Task<object> DeleteDiscount(int Id)
        {
            var item = await context.DiscountPeriods.FindAsync(Id);
            if (item != null)
            {
                item.IsDelete = true;
                item.IsActive = false;
                context.DiscountPeriods.Update(item);
                return true;
            }
            return false;
        }

        public async Task<object> GetDiscountById(int Id)
        {
            var item = await context.DiscountPeriods.FindAsync(Id);
            if (item != null)
            {
                return item;
            }
            return false;
        }
        public async Task<object> GetDiscountByItemId(int Id)
        {
            var itemList = await context.DiscountPeriods.FindAsync(Id);
            if (itemList != null)
            {
                return itemList;
            }
            return false;
        }
        public async Task<object> GetAllDiscount()
        {
            var itemList = await context.DiscountPeriods.Where(x => x.IsDelete == false).ToListAsync();
            if (itemList != null)
            {
                return itemList;
            }
            return false;
        }
    }
}
