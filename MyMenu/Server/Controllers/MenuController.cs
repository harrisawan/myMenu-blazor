using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyMenu.Server.Repository.Menu;
using MyMenu.Shared.ViewModels;

namespace MyMenu.Server.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        private IMenuRepository _trasection;
        public MenuController(IMenuRepository repository)
        {
            _trasection = repository;
        }
        [HttpPost("AddUpdateMenu")]
        public async Task<ActionResult> AddUpdateMenu(MenuViewModel viewModel, string user)
        {
            return Ok(await _trasection.AddUpdateMenu(viewModel, user));
        }
        [HttpDelete("{id:long}")]
        public async Task<ActionResult<object>> DeleteMenu(long id)
        {
            try
            {
                var companyToDelete = await _trasection.GetMenuById(id);

                if (companyToDelete == null)
                {
                    return NotFound($"Menu with Id = {id} not found");
                }

                return await _trasection.DeleteMenu(id);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error deleting data");
            }
        }
        
        
        [HttpGet("GetAllMenu")]
        public async Task<ActionResult> GetAllMenu()
        {
            return Ok(await _trasection.GetAllMenu());
        }

        [HttpGet("{companyid}")]
        public async Task<ActionResult<IEnumerable<object>>> GetAllMenuByCompanyId(string companyid)
        {
            try
            {
                return Ok(await _trasection.GetAllMenuByCompanyId(companyid));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }
        
        [HttpPost]
        public async Task<IActionResult> AddNewMenu([FromBody] MenuViewModel menu)
        {
            try
            {
                return Ok(await _trasection.AddMenu(menu));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error occure during Registeration");
            }
        }
        [HttpGet("{menuid}")]
        public async Task<ActionResult> GetMenuById(int menuid)
        {
            return Ok(await _trasection.GetMenuById(menuid));
        }

        [HttpPost("{id:long}")]
        public async Task<IActionResult> UpdateMenu([FromBody] MenuViewModel menu, long id)
        {
            try
            {
                return Ok(await _trasection.UpdateMenu(menu, id));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error occure during Registeration");
            }
        }
    }
}
