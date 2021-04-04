using MyMenu.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMenu.Client.Services.Discounts
{
    public interface IDiscountDayService
    {
        Task<IEnumerable<DaysOfWeek>> GetAllDays();
    }
}
