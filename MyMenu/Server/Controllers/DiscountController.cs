using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyMenu.Server.Repository.Discount;
using MyMenu.Shared.ViewModels;

namespace MyMenu.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountController : ControllerBase
    {
        private IDiscountRepository _trasection;
        public DiscountController(IDiscountRepository repository)
        {
            _trasection = repository;
        }
     
        [HttpPost("AddUpdateDiscount")]
        public async Task<ActionResult> AddUpdateDiscount(DiscountViewModel viewModel, string user)
        {
            return Ok(await _trasection.AddUpdateDiscount(viewModel, user));
        }
        [HttpPost("DeleteDiscount")]
        public async Task<ActionResult> DeleteDiscount(int id)
        {
            return Ok(await _trasection.DeleteDiscount(id));
        }
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
    }
}
