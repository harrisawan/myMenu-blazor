using System;
using System.Collections.Generic;

namespace MyMenu.Shared.Models
{
    public partial class Role
    {
        public Role()
        {
            UserRole = new HashSet<UserRole>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<UserRole> UserRole { get; set; }
    }
}
