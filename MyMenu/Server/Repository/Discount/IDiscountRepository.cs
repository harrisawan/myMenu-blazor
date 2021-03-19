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
        Task<object> AddUpdateDiscount(DiscountViewModel discount, string UserName);
        Task<object> DeleteDiscount(int Id);
    }
}
