using System;
using System.Collections.Generic;

namespace MyMenu.Shared.Models
{
    public class DaysOfWeek
    {
        public DaysOfWeek()
        {
            DiscountTransaction = new HashSet<DiscountTransaction>();
        }

        public int Id { get; set; }
        public string Days { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<DiscountTransaction> DiscountTransaction { get; set; }
    }
}
