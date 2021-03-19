using System;
using System.Collections.Generic;

namespace MyMenu.Shared.Models
{
    public partial class UserCompany
    {
        public int Id { get; set; }
        public long? UserId { get; set; }
        public int? CompanyId { get; set; }

        public virtual Company Company { get; set; }
        public virtual User User { get; set; }
    }
}
