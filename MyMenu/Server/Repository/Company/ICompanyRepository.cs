using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyMenu.Shared.ViewModels;
namespace MyMenu.Server.Repository.Company
{
    public interface ICompanyRepository
    {
        Task<object> GetAllCompanies();
        Task<object> GetCompanyById(int id);
        Task<object> AddUpdateCompany(CompanyViewModel Conditions, string UserName);
        Task<object> DeleteCompany(int Id);
    }
}
