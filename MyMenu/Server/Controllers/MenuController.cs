using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyMenu.Server.Repository.Menu;
using MyMenu.Shared.ViewModels;

namespace MyMenu.Server.Controllers
{
    [Route("api/[controller]")]
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
        [HttpPost("DeleteMenu")]
        public async Task<ActionResult> DeleteMenu(int id)
        {
            return Ok(await _trasection.DeleteMenu(id));
        }
        [HttpGet("GetMenuById")]
        public async Task<ActionResult> GetMenuById(int id)
        {
            return Ok(await _trasection.GetMenuById(id));
        }
        [HttpGet("GetMenuById")]
        public async Task<ActionResult> GetMenuByCompanyId(int id)
        {
            return Ok(await _trasection.GetMenuByCompanyId(id));
        }
        [HttpGet("GetAllMenu")]
        public async Task<ActionResult> GetAllMenu()
        {
            return Ok(await _trasection.GetAllMenu());
        }
    }
}
