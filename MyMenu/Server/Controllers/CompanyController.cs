using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyMenu.Server.Repository.Company;
using MyMenu.Shared.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using MyMenu.Shared.Models;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace MyMenu.Server.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly IWebHostEnvironment webHostEnvirnoment;
        private ICompanyRepository _trasection;
        public CompanyController(ICompanyRepository repository, IWebHostEnvironment webHostEnvirnoment)
        {
            _trasection = repository;
            this.webHostEnvirnoment = webHostEnvirnoment;
        }
        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Company>> DeleteCompany(int id)
        {
            try
            {
                var companyToDelete = await _trasection.GetCompanyById(id);

                if (companyToDelete == null)
                {
                    return NotFound($"Company with Id = {id} not found");
                }

                return await _trasection.DeleteCompany(id);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error deleting data");
            }
        }
        [HttpGet("{companyid}")]
        public async Task<ActionResult> GetCompanyById(int companyid)
        {
            return Ok(await _trasection.GetCompanyById(companyid));
        }
        
        [HttpGet("{email}")]
        public async Task<ActionResult> GetUserByEmail(string email)
        {
            return Ok(await _trasection.GetUserByEmail(email));
        }
        [HttpGet]
        public async Task<ActionResult> GetAllCompanies()
        {
            return Ok(await _trasection.GetAllCompanies());
        }
        
        [HttpGet("{userid}")]
        public async Task<ActionResult<IEnumerable<Company>>> GetAllCompaniesByUserId(string userid)
        {
            try
            {
                return Ok(await _trasection.GetAllCompaniesByUserId(userid));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

        [HttpPost("{userid}")]
        public async Task<IActionResult> AddNewCompany([FromBody] CompanyDetailViewModel company,string userid)
        {
            try
            {
                return Ok(await _trasection.AddCompany(company,userid));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error occure during Registeration");
            }
        }
        [HttpPost("{id:int}")]
        public async Task<IActionResult> UpdateCompany([FromBody] CompanyDetailViewModel company, int id)
        {
            try
            {
                return Ok(await _trasection.UpdateCompany(company,id));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error occure during Registeration");
            }
        }
    }
}
