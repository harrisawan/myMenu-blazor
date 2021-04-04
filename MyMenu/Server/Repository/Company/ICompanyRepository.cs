using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyMenu.Shared.ViewModels;
using MyMenu.Shared.Models;
namespace MyMenu.Server.Repository.Company
{
    public interface ICompanyRepository
    {
        Task<object> GetAllCompanies();
        Task<IEnumerable<MyMenu.Shared.Models.Company>> GetAllCompaniesByUserId(string userid);
        Task<MyMenu.Shared.Models.Company> AddCompany(CompanyDetailViewModel newcompany, string userid);

        Task<object> GetCompanyById(int id);
        Task<object> GetUserByEmail(string email);
        Task<MyMenu.Shared.Models.Company> UpdateCompany(CompanyDetailViewModel newcompany, int id);
        Task<MyMenu.Shared.Models.Company> DeleteCompany(int Id);
    }
}
