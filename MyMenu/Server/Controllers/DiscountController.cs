using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyMenu.Server.Repository.Discount;
using MyMenu.Shared.ViewModels;

namespace MyMenu.Server.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DiscountController : ControllerBase
    {
        private IDiscountRepository _trasection;
        public DiscountController(IDiscountRepository repository)
        {
            _trasection = repository;
        }

        [HttpGet("{discountid}")]
        public async Task<ActionResult> GetDiscountById(int discountid)
        {
            return Ok(await _trasection.GetDiscountById(discountid));
        }

        [HttpPost]
        public async Task<IActionResult> AddNewDiscount([FromBody] DiscountViewModel discount)
        {
            try
            {
                await _trasection.AddDiscount(discount);
                return Ok("Record Added Successfully");
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error occure during Adding");
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> DeleteDiscount(int id)
        {
            try
            {
                var DiscountToDelete = await _trasection.GetDiscountById(id);

                if (DiscountToDelete == null)
                {
                    return NotFound($"Discount with Id = {id} not found");
                }

                await _trasection.DeleteDiscount(id);
                return Ok("Record Deleted");
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error deleting data");
            }
        }

        //[HttpPost("DeleteDiscount")]
        //public async Task<ActionResult> DeleteDiscount(int id)
        //{
        //    return Ok(await _trasection.DeleteDiscount(id));
        //}
        [HttpGet("GetDiscountByItemId")]
        public async Task<ActionResult> GetDiscountByItemId(int id)
        {
            return Ok(await _trasection.GetDiscountByItemId(id));
        }
     
        [HttpGet("GetAllDiscount")]
        public async Task<ActionResult> GetAllDiscount()
        {
            return Ok(await _trasection.GetAllDiscount());
        }

        [HttpGet("{companyid}")]
        public async Task<ActionResult<IEnumerable<object>>> GetAllDiscountByCompanyId(string companyid)
        {
            try
            {
                return Ok(await _trasection.GetAllDiscountByCompanyId(companyid));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }
        [HttpGet("{discountid}")]
        public async Task<ActionResult<IEnumerable<object>>> GetTransactionByDiscountById(int discountid)
        {
            try
            {
                return Ok(await _trasection.GetDiscountTransactionByDiscountId(discountid));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

        [HttpPost("{id:int}")]
        public async Task<IActionResult> UpdateDiscount([FromBody] DiscountViewModel adddiscount, int id)
        {
            try
            {
                await _trasection.UpdateDiscount(adddiscount, id);
                return Ok("Updated Successful");
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error occure during Updating");
            }
        }
    }
}
