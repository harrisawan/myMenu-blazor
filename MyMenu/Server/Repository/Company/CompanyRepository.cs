using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyMenu.Shared.ViewModels;
using Microsoft.EntityFrameworkCore;
using MyMenu.Shared.Models;

namespace MyMenu.Server.Repository.Company
{
    public class CompanyRepository: ICompanyRepository
    {
        private MyMenuDbContext context;
        public CompanyRepository(MyMenuDbContext context)
        {
            this.context = context;
        }
        public async Task<object> AddUpdateCompany(CompanyViewModel companyViewModel, string UserName)
        {
            if (companyViewModel.Id == 0)
            {
                MyMenu.Shared.Models.Company company = new MyMenu.Shared.Models.Company();
                company.Name = companyViewModel.Name;
                company.Description = companyViewModel.Description;
                company.ImgUrl = companyViewModel.ImgUrl;
                company.CreatedBy = UserName;
                company.CreatedAt = DateTime.Now;
                company.UpdatedBy = UserName;
                company.UpdatedAt= DateTime.Now;
                company.IsActive = true;
                company.IsDelete = false;
                context.Company.Add(company);
                await context.SaveChangesAsync();
                return company;

            }
            else
            {
                var company = await context.Company.FindAsync(companyViewModel.Id);
                company.Name = companyViewModel.Name;
                company.Description = companyViewModel.Description;
                company.UpdatedAt = DateTime.Now;
                company.UpdatedBy = UserName;
                company.IsActive = companyViewModel.IsActive;
                context.Company.Update(company);
                await context.SaveChangesAsync();
                return company;
            }
        }

        public async Task<object> DeleteCompany(int Id)
        {
            var company = await context.Company.FindAsync(Id);
            if (company != null)
            {
                company.IsDelete = true;
                context.Company.Update(company);
                return true;
            }
            return false;
        }

        public async Task<object> GetCompanyById(int Id)
        {
            var company = await context.Company.FindAsync(Id);
            if (company != null)
            {
                return company;
            }
            return false;
        }

        public async  Task<object> GetAllCompanies()
        {
            var companyList = await context.Company.Where(x=>x.IsDelete==false).ToListAsync();
            if (companyList != null)
            {
                return companyList;
            }
            return false;
        }
    }
}
