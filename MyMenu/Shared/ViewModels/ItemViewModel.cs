using System;
using System.Collections.Generic;
using System.Text;

namespace MyMenu.Shared.ViewModels
{
    public class ItemViewModel
    {
        public long Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImgUrl { get; set; }
        public decimal? Price { get; set; }
        public decimal? PriceWithDiscount { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
    }
}
