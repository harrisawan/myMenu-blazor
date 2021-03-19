
using MyMenu.Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyMenu.Shared.ViewModels
{
    public class DiscountViewModel
    {
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
        public List<Days> daysOfWeek { get; set; }
        public List<DiscountTransaction> discountTransactions { get; set; }
    }
    public class Days
    {
        public int Id { get; set; }
        public bool IsChecked { get; set; }
    }
}
