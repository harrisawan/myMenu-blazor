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
                company.ImgUrl = companyViewModel.Photo;
                company.CreatedBy = UserName;
                company.CreatedAt = DateTime.Now;
                company.UpdatedBy = UserName;
                company.UpdatedAt= DateTime.Now;
                company.IsActive = true;
                company.IsDelete = false;
                await context.Company.AddAsync(company);
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
        public async Task<MyMenu.Shared.Models.Company> DeleteCompany(int Id)
        {
            var result = await context.Company.FirstOrDefaultAsync(e => e.Id == Id);
            var menu= await context.Menu.Where(x => x.CompanyId == Id).ToListAsync();
            var category = await context.Category.Where(x => x.CompanyId == Id).ToListAsync();
            var item = await context.Item.Where(x => x.CompanyId == Id).ToListAsync();
            var discount = await context.DiscountPeriods.Include(e=>e.DiscountTransaction).Where(x => x.CompanyId == Id).ToListAsync();
            if (discount != null)
            {
                foreach(var discountlist in discount)
                {
                    var discountTrans = await context.DiscountTransaction.Where(x => x.DiscountPeriodId == discountlist.Id).ToListAsync();
                    context.DiscountTransaction.RemoveRange(discountTrans);
                    await context.SaveChangesAsync();
                }
                
                context.DiscountPeriods.RemoveRange(discount);
                await context.SaveChangesAsync();
            }
            if (item != null)
            {
                context.Item.RemoveRange(item);
                await context.SaveChangesAsync();
            }
            if (category != null)
            {
                context.Category.RemoveRange(category);
                await context.SaveChangesAsync();
            }
            if (menu != null)
            {
                context.Menu.RemoveRange(menu);
                await context.SaveChangesAsync();
            }
            if (result != null)
            {
                context.Company.Remove(result);
                await context.SaveChangesAsync();
                return result;
            }

            return null;
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
        public async Task<IEnumerable<MyMenu.Shared.Models.Company>> GetAllCompaniesByUserId(string userid)
        {
            return await context.Company.Where(x => x.UserId == long.Parse(userid)).ToListAsync();
           
        }

        public async Task<Shared.Models.Company> AddCompany(CompanyDetailViewModel newcompany, string userid)
        {
            var result = await context.User.FirstOrDefaultAsync(e => e.UserId == int.Parse(userid));
            string fullname = result.FirstName + " " + result.LastName;
            MyMenu.Shared.Models.Company company = new MyMenu.Shared.Models.Company();
            company.Name = newcompany.Name;
            company.Description = newcompany.Description;
            company.ImgUrl = newcompany.Photo;
            company.UserId = newcompany.UserId;
            company.CreatedBy = fullname;
            company.CreatedAt = DateTime.Now;
            company.UpdatedBy = fullname;
            company.UpdatedAt = DateTime.Now;
            company.IsActive = true;
            company.IsDelete = false;
            await context.Company.AddAsync(company);
            await context.SaveChangesAsync();
            return company;
        }

        public async Task<Shared.Models.Company> UpdateCompany(CompanyDetailViewModel newcompany, int id)
        {
            var result = await context.Company
                .FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                result.Name = newcompany.Name;
                result.Description= newcompany.Description;
                result.ImgUrl = newcompany.Photo;
                result.UpdatedAt = DateTime.Now;
                await context.SaveChangesAsync();
                return result;
            }
            return null;
        }

        public async Task<object> GetUserByEmail(string email)
        {
            var user = await context.User.FindAsync(email);
            if (user != null)
            {
                return user;
            }
            return false;
        }
    }
}
