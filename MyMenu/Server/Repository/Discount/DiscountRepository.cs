using Microsoft.EntityFrameworkCore;
using MyMenu.Shared.Models;
using MyMenu.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace MyMenu.Server.Repository.Discount
{
    public class DiscountRepository : IDiscountRepository
    {

        private MyMenuDbContext context;
        public DiscountRepository(MyMenuDbContext context)
        {
            this.context = context;
        }

        public async Task DeleteDiscount(int id)
        {
            var result = await context.DiscountPeriods.FirstOrDefaultAsync(e => e.Id == id);
            var discountTransaction = await context.DiscountTransaction.Where(x => x.DiscountPeriodId == id).ToListAsync();
            var item = await context.Item.Where(x => x.DiscountId == id).ToListAsync();
            if (discountTransaction != null)
            {
                context.DiscountTransaction.RemoveRange(discountTransaction);
                await context.SaveChangesAsync();
            }
            if (item != null)
            {
                foreach(var i in item)
                {
                    i.DiscountId= 0;
                    context.Entry(i).Property("DiscountId").IsModified = true;
                    context.SaveChanges();
                }
            }
            if (result != null)
                {
                    context.DiscountPeriods.Remove(result);
                    await context.SaveChangesAsync();
                }
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

        public async Task<IEnumerable<DiscountPeriods>> GetAllDiscountByCompanyId(string companyid)
        {
            return await context.DiscountPeriods.Where(x => x.CompanyId == int.Parse(companyid)).ToListAsync();
        }

        public async Task AddDiscount(DiscountViewModel newdiscount)
        {
            DiscountPeriods item = new DiscountPeriods();
            item.ItemId = newdiscount.ItemId;
            item.FromDate = newdiscount.FromDate;
            item.CompanyId = newdiscount.CompanyId;
            item.Name = newdiscount.Name;
            item.ToDate = newdiscount.ToDate;
            item.FromTime = newdiscount.FromTime;
            item.ToTime = newdiscount.ToTime;
            item.CreatedAt = DateTime.Now;
            item.UpdatedAt = DateTime.Now;
            item.IsActive = true;
            item.IsDelete = false;
            await context.DiscountPeriods.AddAsync(item);
            await context.SaveChangesAsync();
            foreach (var list in newdiscount.DaysIdList)
            {
                DiscountTransaction transaction = new DiscountTransaction();
                transaction.DiscountPeriodId = item.Id;
                transaction.DayId = list;
                await context.DiscountTransaction.AddAsync(transaction);
                await context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<DiscountTransaction>> GetDiscountTransactionByDiscountId(int discountid)
        {
            return await context.DiscountTransaction.Where(x => x.DiscountPeriodId == discountid).ToListAsync();
        }

        public async Task UpdateDiscount(DiscountViewModel newdiscount, int id)
        {
            var result = await context.DiscountPeriods.Include(x=>x.DiscountTransaction)
               .FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                var discountTransaction = await context.DiscountTransaction.Where(x => x.DiscountPeriodId == id).ToListAsync();
                if (discountTransaction != null)
                {
                    context.DiscountTransaction.RemoveRange(discountTransaction);
                    await context.SaveChangesAsync();
                    foreach (var list in newdiscount.DaysIdList)
                    {
                        DiscountTransaction transaction = new DiscountTransaction();
                        transaction.DiscountPeriodId = result.Id;
                        transaction.DayId = list;
                        await context.DiscountTransaction.AddAsync(transaction);
                        await context.SaveChangesAsync();
                    }
                }
                result.FromDate = newdiscount.FromDate;
                result.Name = newdiscount.Name;
                result.ToDate = newdiscount.ToDate;
                result.FromTime = newdiscount.FromTime;
                result.ToTime = newdiscount.ToTime;
                context.DiscountPeriods.Update(result);
                await context.SaveChangesAsync();
            }
        }
    }
}
