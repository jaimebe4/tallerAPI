using tallerAPI.Data.Models;

namespace tallerAPI.Services
{
    public interface IUserService
    {
        Task<User>? GetUserAsync(string username, string password);
    }
}
