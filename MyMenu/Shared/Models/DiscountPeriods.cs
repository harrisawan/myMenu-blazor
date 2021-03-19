using System;
using System.Collections.Generic;

namespace MyMenu.Shared.Models
{
    public partial class DiscountPeriods
    {
        public DiscountPeriods()
        {
            DiscountTransaction = new HashSet<DiscountTransaction>();
        }

        public int Id { get; set; }
        public long? ItemId { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime? FromTime { get; set; }
        public DateTime? ToTime { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool? IsDelete { get; set; }
        public bool? IsActive { get; set; }

        public virtual Item Item { get; set; }
        public virtual ICollection<DiscountTransaction> DiscountTransaction { get; set; }
    }
}
