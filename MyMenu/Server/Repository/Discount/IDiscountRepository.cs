using MyMenu.Shared.Models;
using MyMenu.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMenu.Server.Repository.Discount
{
    public interface IDiscountRepository
    {
        Task<object> GetAllDiscount();
        Task<object> GetDiscountByItemId(int id);
        Task<object> GetDiscountById(int id);
        Task DeleteDiscount(int Id);
        Task<IEnumerable<DiscountPeriods>> GetAllDiscountByCompanyId(string companyid);
        Task<IEnumerable<DiscountTransaction>> GetDiscountTransactionByDiscountId(int discountid);
        Task AddDiscount(DiscountViewModel newdiscount);
        Task UpdateDiscount(DiscountViewModel newdiscount, int id);
    }
}
