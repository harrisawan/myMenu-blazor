using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace MyMenu.Shared.ViewModels
{
    public class AddCompanyViewModel
    {
        public string Name { get; set; }
        public long UserId { get; set; }
        public string Description { get; set; }
        public MultipartFormDataContent Photocontent { get; set; }
    }
}
