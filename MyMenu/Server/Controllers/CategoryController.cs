using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyMenu.Server.Repository.Category;
using MyMenu.Shared.ViewModels;

namespace MyMenu.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private ICategoryRepository _trasection;
        public CategoryController(ICategoryRepository repository)
        {
            _trasection = repository;
        }
        [HttpPost("AddUpdateCategory")]
        public async Task<ActionResult> AddUpdateCategory(CategoryViewModel viewModel, string user)
        {
            return Ok(await _trasection.AddUpdateCategory(viewModel, user));
        }
        [HttpPost("DeleteCategory")]
        public async Task<ActionResult> DeleteCategory(int id)
        {
            return Ok(await _trasection.DeleteCategory(id));
        }
        [HttpGet("GetCategoryById")]
        public async Task<ActionResult> GetCategoryById(int id)
        {
            return Ok(await _trasection.GetCategoryById(id));
        }
        [HttpGet("GetAllCategory")]
        public async Task<ActionResult> GetAllCategory()
        {
            return Ok(await _trasection.GetAllCategory());
        }
    }
}
