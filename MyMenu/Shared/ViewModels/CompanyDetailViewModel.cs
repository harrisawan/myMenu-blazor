using System;
using System.Collections.Generic;
using System.Text;

namespace MyMenu.Shared.ViewModels
{
    public class CompanyDetailViewModel
    {
        public string Name { get; set; }
        public long UserId { get; set; }
        public string Description { get; set; }
        public byte[] Photo{ get; set; }
    }
}
