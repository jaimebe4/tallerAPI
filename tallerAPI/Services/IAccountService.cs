using tallerAPI.Data.Models;

namespace tallerAPI.Services
{
    public interface IAccountService
    {
        string GenerateJwtToken(User user);
    }
}
