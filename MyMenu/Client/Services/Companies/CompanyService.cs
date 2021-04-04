using MyMenu.Shared.Models;
using MyMenu.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace MyMenu.Client.Services.Companies
{
    public class CompanyService : ICompanyService
    {
        private readonly HttpClient httpClient;
        public CompanyService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<Company> AddNewCompany(CompanyDetailViewModel addCompany, string userid)
        {
            var result = await httpClient.PostAsJsonAsync("api/company/AddNewCompany/{userid}", addCompany);
            var res = result.Content.ReadFromJsonAsync<Company>();
            return await res;
        }
        public async Task<Company> UpdateCompany(CompanyDetailViewModel addCompany,int id)
        {
            var result = await httpClient.PostAsJsonAsync($"api/company/UpdateCompany/{id}", addCompany);
            var res = result.Content.ReadFromJsonAsync<Company>();
            return await res;
        }

        public async Task DeleteCompany(int id)
        {
            await httpClient.DeleteAsync($"api/company/DeleteCompany/{id}");
        }

        public async Task<IEnumerable<Company>> GetAllCompanies()
        {
            
              return await httpClient.GetFromJsonAsync<Company[]>("api/company/getallCompanies");
        }

        public async Task<IEnumerable<Company>> GetAllCompaniesByUserId(string userid)
        {
            return await httpClient.GetFromJsonAsync<Company[]>($"api/company/getallcompaniesbyuserid/{userid}");
        }

        public async Task<Company> GetCompaniesById(int companyid)
        {
            return await httpClient.GetFromJsonAsync<Company>($"api/company/GetCompanyById/{companyid}");
        }

        public async Task<User> GetUserByEmail(string email)
        {
            return await httpClient.GetFromJsonAsync<User>($"api/company/GetUserByEmail/{email}");
        }
    }
}
