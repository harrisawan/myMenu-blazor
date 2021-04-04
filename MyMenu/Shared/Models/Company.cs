using System;
using System.Collections.Generic;

namespace MyMenu.Shared.Models
{
    public class Company
    {
        public Company()
        {
            Menu = new HashSet<Menu>();
            UserCompany = new HashSet<UserCompany>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] ImgUrl { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public long UserId { get; set; }

        public virtual ICollection<Menu> Menu { get; set; }
        public virtual ICollection<UserCompany> UserCompany { get; set; }
    }
}
