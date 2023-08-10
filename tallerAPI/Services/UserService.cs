using tallerAPI.Data;
using tallerAPI.Data.Models;
using Microsoft.EntityFrameworkCore;
using tallerAPI.Services;

namespace tallerAPI.Services
{
    public class UserService : IUserService
    {

        private readonly tallerDBContext _context;


        public UserService(tallerDBContext context)
        {
            _context = context;
        }

        public async Task<User>? GetUserAsync(string username, string password)
        {
            if (_context.Users == null)
            {
                return null;
            }
            var user = await _context.Users.FirstOrDefaultAsync(user => user.UserName == username && user.Password == password);

            return user;
        }
    }
}
