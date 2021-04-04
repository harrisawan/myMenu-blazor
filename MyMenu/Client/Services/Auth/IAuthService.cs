using MyMenu.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMenu.Client.Services.Auth
{
    public interface IAuthService
    {
        Task<RegisterResult> Register(RegisterViewModel registerModel);
        Task<LoginResult> Login(LoginViewModel registerModel);
        Task Logout();
    }
}
