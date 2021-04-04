using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMenu.Client.Services
{
    public interface IMyService
    {
        public event Action RefreshRequested;
       public void CallRequestRefresh();
    }
}
