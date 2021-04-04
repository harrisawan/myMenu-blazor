using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyMenu.Server.Repository.Discount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMenu.Server.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DiscountDayController : Controller
    {
        private IDiscountDayRepository _trasection;
        public DiscountDayController(IDiscountDayRepository repository)
        {
            _trasection = repository;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<object>>> GetAllDiscountDay()
        {
            try
            {
                return Ok(await _trasection.GetAllDiscountDay());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }
    }
}
