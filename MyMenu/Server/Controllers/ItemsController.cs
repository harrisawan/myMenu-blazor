using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyMenu.Server.Repository.Item;
using MyMenu.Shared.Models;
using MyMenu.Shared.ViewModels;

namespace MyMenu.Server.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private IItemRepository _trasection;
        public ItemsController(IItemRepository repository)
        {
            _trasection = repository;
        }
        [HttpDelete("{id:long}")]
        public async Task<ActionResult> DeleteItem(long id)
        {
            try
            {
                await _trasection.DeleteItem(id);
                return Ok("Record Deleted");
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error deleting data");
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddNewItem([FromBody] ItemViewModel item)
        {
            try
            {
                await _trasection.AddItem(item);
                return Ok("Record Added Successfully");
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error occure during Adding");
            }
        }

        [HttpGet("{companyid}")]
        public async Task<ActionResult<IEnumerable<Item>>> GetAllItemByCompanyId(string companyid)
        {
            try
            {
                return Ok(await _trasection.GetAllItemByCompanyId(companyid));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }
        [HttpGet("{itemid}")]
        public async Task<ActionResult> GetItemById(int itemid)
        {
            return Ok(await _trasection.GetItemById(itemid));
        }

        [HttpPost("{id:long}")]
        public async Task<IActionResult> UpdateItem([FromBody] ItemViewModel item, long id)
        {
            try
            {
                await _trasection.UpdateItem(item, id);
                return Ok("Added Successfully");
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error occur");
            }
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
