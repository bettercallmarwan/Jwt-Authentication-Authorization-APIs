using JwtAuthenticationProject.Entities;
using JwtAuthenticationProject.Models;

namespace JwtProject.Services
{
    public interface IAuthService
    {
        Task<User?> RegisterAsync(UserDto request);
        Task<string?> LoginAsync(UserDto request);
    }
}
