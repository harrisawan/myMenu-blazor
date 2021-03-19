using System;
using System.Collections.Generic;

namespace MyMenu.Shared.Models
{
    public partial class TimeByDaysOfWeekInMinutes
    {
        public int Id { get; set; }
        public byte[] TimeSpan { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool? IsActive { get; set; }
    }
}
