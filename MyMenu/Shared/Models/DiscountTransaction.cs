using System;
using System.Collections.Generic;

namespace MyMenu.Shared.Models
{
    public partial class DiscountTransaction
    {
        public int Id { get; set; }
        public int DiscountPeriodId { get; set; }
        public int DayId { get; set; }

        public virtual DaysOfWeek Day { get; set; }
        public virtual DiscountPeriods DiscountPeriod { get; set; }
    }
}
