using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using MyMenu.Shared.Models;
using MyMenu.Shared.ViewModels;
using Newtonsoft.Json.Linq;

namespace MyMenu.Server.Repository.Account
{
    public class AccountRepository : IAccountRepository
    {
        private readonly MyMenuDbContext _context;
        private readonly IConfiguration _configuration;
        public AccountRepository(MyMenuDbContext _db, IConfiguration configuration)
        {
            _context = _db;
            _configuration = configuration;
        }
        public async Task<RegisterResult> RegisterAsync(RegisterViewModel registerViewModel)
        {
            try
            {
                var checkuserExist = _context.User.Where(a => a.Email == registerViewModel.Email).FirstOrDefault();
                if (checkuserExist == null)
                {

                    User user = new User();
                    user.Email = registerViewModel.Email;
                    user.Password = registerViewModel.Password;
                    user.CreatedAt = DateTime.Now;
                    user.FirstName = registerViewModel.FirstName;
                    user.LastName = registerViewModel.LastName;
                    user.UpdatedAt = DateTime.Now;
                    user.Salt = "";
                    user.IsActive = true;
                    user.IsDelete = false;

                    await _context.User.AddAsync(user);
                    await _context.SaveChangesAsync();
                    var result = new RegisterResult { Successful = true };
                    return result;
                }

                return new RegisterResult { Successful = false, Errors = "Email already in use" };

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<object> UpdateAsync(User customer)
        {
            try
            {

                _context.Update(customer);
                await _context.SaveChangesAsync();
                return customer;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<LoginResult> LoginAsync(LoginViewModel loginViewModel)
        {
            try
            {
                var customer = await _context.User.Where(x => x.Email == loginViewModel.Email && x.Password == loginViewModel.Password)
                    .FirstOrDefaultAsync();
                if (customer != null)
                {
                    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtSecurityKey"]));
                    var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                    var expiry = DateTime.Now.AddDays(Convert.ToInt32(_configuration["JwtExpiryInDays"]));
                   
                    var claims = new[]
                {
                new Claim(ClaimTypes.Name, loginViewModel.Email)
            };

                    var token = new JwtSecurityToken(
                        _configuration["JwtIssuer"],
                        _configuration["JwtAudience"],
                        claims,
                        expires: expiry,
                        signingCredentials: creds
                    );
                    return new LoginResult { Successful = true, Token = new JwtSecurityTokenHandler().WriteToken(token) };
                }
                return new LoginResult { Successful = false, Error = "Username and password are invalid." };

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<object> Delete(int id)
        {
            User customer = _context.User.Where(x => x.UserId == id).FirstOrDefault();

            if (customer != null)
            {
                _context.Remove(customer);
                await _context.SaveChangesAsync();

                return customer;
            }
            return "";
        }


    }
}
