using Microsoft.EntityFrameworkCore;
using MyMenu.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMenu.Server.Repository.Discount
{
    public class DiscountDayRepository : IDiscountDayRepository
    {
        private MyMenuDbContext context;
        public DiscountDayRepository(MyMenuDbContext context)
        {
            this.context = context;
        }
        public async Task<IEnumerable<DaysOfWeek>> GetAllDiscountDay()
        {
            return await context.DaysOfWeek.ToListAsync();
        }
    }
}
