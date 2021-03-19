using System;
using System.Collections.Generic;

namespace MyMenu.Shared.Models
{
    public partial class User
    {
        public User()
        {
            UserCompany = new HashSet<UserCompany>();
            UserRole = new HashSet<UserRole>();
        }

        public long UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }

        public virtual ICollection<UserCompany> UserCompany { get; set; }
        public virtual ICollection<UserRole> UserRole { get; set; }
    }
}
