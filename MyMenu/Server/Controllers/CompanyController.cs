using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyMenu.Server.Repository.Company;
using MyMenu.Shared.ViewModels;
using Microsoft.AspNetCore.Authorization;
namespace MyMenu.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private ICompanyRepository _trasection;
        public CompanyController(ICompanyRepository repository)
        {
            _trasection = repository;
        }
        [HttpPost("AddUpdateCompany")]
        public async Task<ActionResult> AddUpdateCompany(CompanyViewModel viewModel,string user)
        {
            return Ok(await _trasection.AddUpdateCompany(viewModel, user));
        }
        [HttpPost("DeleteCompany")]
        public async Task<ActionResult> DeleteCompany(int id)
        {
            return Ok(await _trasection.DeleteCompany(id));
        }
        [HttpGet("GetCompanyById")]
        public async Task<ActionResult> GetCompanyById(int id)
        {
            return Ok(await _trasection.GetCompanyById(id));
        }
        [HttpGet("GetAllCompanies")]
        public async Task<ActionResult> GetAllCompanies()
        {
            return Ok(await _trasection.GetAllCompanies());
        }
    }
}
