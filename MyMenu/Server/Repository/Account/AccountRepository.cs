using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyMenu.Shared.Models;
using MyMenu.Shared.ViewModels;
using Newtonsoft.Json.Linq;

namespace MyMenu.Server.Repository.Account
{
    public class AccountRepository
    { 
        MyMenuDbContext _context;
        public AccountRepository(MyMenuDbContext _db)
        {
            _context = _db;
        }
        public async Task<object> RegisterAsync(User customer)
        {
            try
            {
                var checkuserExist = _context.User.Where(a => a.Email == customer.Email).FirstOrDefault();
                if (!string.IsNullOrEmpty(checkuserExist.Email))
                {

                    User user = new User();
                    user.Email = customer.Email;
                    user.CreatedAt = DateTime.Now;
                    user.FirstName = customer.FirstName;
                    user.LastName = customer.LastName;
                    user.UpdatedAt = DateTime.Now;
                    user.Salt = customer.Salt;
                    user.IsActive = true;
                    user.IsDelete = false;

                    await _context.User.AddAsync(customer);
                    await _context.SaveChangesAsync();
                    return user;
                }
                return customer;
                
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<object> UpdateAsync( User customer)
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

        public async Task<object> LogIn(string emailAddress, string password)
        {
            try
            {
                var customer = await _context.User.Where(x => x.Email == emailAddress && x.Password == password)
                    .FirstOrDefaultAsync();
                return customer;
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
