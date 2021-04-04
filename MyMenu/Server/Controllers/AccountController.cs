using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using MyMenu.Server.Repository.Account;
using MyMenu.Shared.Models;
using MyMenu.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace MyMenu.Server.Controllers
{
    [Route("api/[controller]/[action]")]
        [ApiController]
        public class AccountController : Controller
        {
            private IAccountRepository accountrepository;
        private readonly IConfiguration _configuration;
        private readonly MyMenuDbContext _context;
        public AccountController(IAccountRepository accountrepository, IConfiguration configuration, MyMenuDbContext _db)
            {
                this.accountrepository = accountrepository;
            _configuration = configuration;
            _context = _db;
        }
            [HttpPost]
            public async Task<IActionResult> Register([FromBody] RegisterViewModel model)
            {
                try
                {
                    return Ok(await accountrepository.RegisterAsync(model));
                }
                catch (Exception)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError,
                        "Error occure during Registeration");
                }

            }
        [HttpPost]
        public async Task<IActionResult> Login([FromBody] LoginViewModel login)
        {

            var customer = await _context.User.Where(x => x.Email == login.Email && x.Password == login.Password).FirstOrDefaultAsync();

            if (customer==null) return BadRequest(new LoginResult { Successful = false, Error = "Username and password are invalid." });
            string userFullName = customer.FirstName + " " + customer.LastName;
            var claims = new[]
            {
                new Claim(ClaimTypes.Name, userFullName)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtSecurityKey"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expiry = DateTime.Now.AddDays(Convert.ToInt32(_configuration["JwtExpiryInDays"]));

            var token = new JwtSecurityToken(
                _configuration["JwtIssuer"],
                _configuration["JwtAudience"],
                claims,
                expires: expiry,
                signingCredentials: creds
            );

            return Ok(new LoginResult { Successful = true, Token = new JwtSecurityTokenHandler().WriteToken(token),UserId= customer.UserId.ToString()});

            //try
            //{
            //    return Ok(await accountrepository.LoginAsync(login));
            //}
            //catch (Exception)
            //{
            //    return StatusCode(StatusCodes.Status500InternalServerError,
            //        "Error occure during Login");
            //}
        }
    }
    }
