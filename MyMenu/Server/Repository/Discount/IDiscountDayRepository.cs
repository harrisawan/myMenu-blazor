using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMenu.Server.Repository.Discount
{
   public interface IDiscountDayRepository
    {
        Task<IEnumerable<MyMenu.Shared.Models.DaysOfWeek>> GetAllDiscountDay();
    }
}
