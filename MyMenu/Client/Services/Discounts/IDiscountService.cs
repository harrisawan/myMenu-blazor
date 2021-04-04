using MyMenu.Shared.Models;
using MyMenu.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMenu.Client.Services.Discounts
{
    public interface IDiscountService
    {
        Task<IEnumerable<DiscountPeriods>> GetAllDiscountByCompanyId(string companyid);
        Task AddNewDiscount(DiscountViewModel discount);
        Task<DiscountPeriods> GetDiscountById(int discountid);
        Task<IEnumerable<DiscountTransaction>> GetDiscountTransactionByDiscountId(int discountid);
        Task UpdateDiscount(DiscountViewModel adddiscount, int id);
        Task DeleteDiscount(int id);
    }
}
