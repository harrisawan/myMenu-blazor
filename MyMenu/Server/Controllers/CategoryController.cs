using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyMenu.Server.Repository.Category;
using MyMenu.Shared.ViewModels;

namespace MyMenu.Server.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private ICategoryRepository _trasection;
        public CategoryController(ICategoryRepository repository)
        {
            _trasection = repository;
        }
        [HttpGet("GetAllCategory")]
        public async Task<ActionResult> GetAllCategory()
        {
            return Ok(await _trasection.GetAllCategory());
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<object>> DeleteCategory(int id)
        {
            try
            {
                var companyToDelete = await _trasection.GetCategoryById(id);

                if (companyToDelete == null)
                {
                    return NotFound($"Menu with Id = {id} not found");
                }

                return await _trasection.DeleteCategory(id);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error deleting data");
            }
        }
        [HttpGet("{companyid}")]
        public async Task<ActionResult<IEnumerable<object>>> GetAllCategoryByCompanyId(string companyid)
        {
            try
            {
                return Ok(await _trasection.GetAllCategoryByCompanyId(companyid));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddNewCategory([FromBody] CategoryViewModel category)
        {
            try
            {
                return Ok(await _trasection.AddCategory(category));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error occure during Registeration");
            }
        }

        [HttpGet("{categoryid}")]
        public async Task<ActionResult> GetCategoryById(int categoryid)
        {
            return Ok(await _trasection.GetCategoryById(categoryid));
        }

        [HttpPost("{id:int}")]
        public async Task<IActionResult> UpdateCategory([FromBody] CategoryViewModel category, int id)
        {
            try
            {
                return Ok(await _trasection.UpdateCategory(category, id));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error occure during Registeration");
            }
        }
    }
}
