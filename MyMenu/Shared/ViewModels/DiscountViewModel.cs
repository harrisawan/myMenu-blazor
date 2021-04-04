
using MyMenu.Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyMenu.Shared.ViewModels
{
    public class DiscountViewModel
    {
        public long? ItemId { get; set; }
        public int  CompanyId{get;set;}
        public int? DiscountPercent { get; set; }
        public string Name { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public DateTime FromTime { get; set; }
        public DateTime ToTime { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool? IsDelete { get; set; }
        public bool? IsActive { get; set; }
        public List<int> DaysIdList { get; set; } = new List<int>();
    }
    public class Days
    {
        public int Id { get; set; }
        public bool IsChecked { get; set; }
    }
}
