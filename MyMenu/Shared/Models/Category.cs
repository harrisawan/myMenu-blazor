using System;
using System.Collections.Generic;

namespace MyMenu.Shared.Models
{
    public partial class Category
    {
        public Category()
        {
            Item = new HashSet<Item>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public long MenuId { get; set; }
        public int CompanyId { get; set; }

        public virtual ICollection<Item> Item { get; set; }
    }
}
