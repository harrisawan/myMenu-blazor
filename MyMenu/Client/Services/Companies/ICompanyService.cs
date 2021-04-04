using MyMenu.Shared.Models;
using MyMenu.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMenu.Client.Services.Companies
{
    public interface ICompanyService
    {
        Task<IEnumerable<Company>> GetAllCompanies();
        Task<IEnumerable<Company>> GetAllCompaniesByUserId(string userid);
        Task<Company> GetCompaniesById(int companyid);
        Task<Company> AddNewCompany(CompanyDetailViewModel addCompany, string userid);
        Task<Company> UpdateCompany(CompanyDetailViewModel addCompany,int id);

        Task<User> GetUserByEmail(string email);
        Task DeleteCompany(int id);
    }
}
