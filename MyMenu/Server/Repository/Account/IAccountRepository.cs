using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyMenu.Shared.ViewModels;
namespace MyMenu.Server.Repository.Account
{
    public interface IAccountRepository
    {
        Task<RegisterResult> RegisterAsync(RegisterViewModel registerViewModel);
        Task<LoginResult> LoginAsync(LoginViewModel loginViewModel);
        //Task<object> GetAllCategory();
        //Task<object> GetCategoryById(int id);
        //Task<object> AddUpdateCategory(CategoryViewModel Category, string UserName);
        //Task<object> DeleteCategory(int Id);
        //Task<object> GetCategoryByMenuId(int Id);
    }
}
