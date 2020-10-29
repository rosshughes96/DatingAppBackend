using WebApplication.Entities;

namespace WebApplication.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}