using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyMenu.Server.Repository.Item;
using MyMenu.Shared.ViewModels;

namespace MyMenu.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private IItemRepository _trasection;
        public ItemsController(IItemRepository repository)
        {
            _trasection = repository;
        }
        [HttpPost("AddUpdateItem")]
        public async Task<ActionResult> AddUpdateItem(ItemViewModel viewModel, string user)
        {
            return Ok(await _trasection.AddUpdateItem(viewModel, user));
        }
        [HttpPost("DeleteItem")]
        public async Task<ActionResult> DeleteItem(int id)
        {
            return Ok(await _trasection.DeleteItem(id));
        }
        [HttpGet("GetItemById")]
        public async Task<ActionResult> GetItemById(int id)
        {
            return Ok(await _trasection.GetItemById(id));
        }
        [HttpGet("GetItemByCategoryId")]
        public async Task<ActionResult> GetItemByCategoryId(int id)
        {
            return Ok(await _trasection.GetItemByCategoryId(id));
        }
        [HttpGet("GetAllItem")]
        public async Task<ActionResult> GetAllItem()
        {
            return Ok(await _trasection.GetAllItem());
        }
    }
}
