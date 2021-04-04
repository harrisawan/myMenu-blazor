using System;
using System.Collections.Generic;

namespace MyMenu.Shared.Models
{
    public partial class Item
    {
        public Item()
        {
            DiscountPeriods = new HashSet<DiscountPeriods>();
        }

        public long Id { get; set; }
        public int CategoryId { get; set; }
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] ImgUrl { get; set; }
        public decimal Price { get; set; }
        public decimal PriceWithDiscount { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public int DiscountId { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<DiscountPeriods> DiscountPeriods { get; set; }
    }
}
