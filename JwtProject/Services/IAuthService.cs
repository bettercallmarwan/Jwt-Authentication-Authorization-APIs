using JwtAuthenticationProject.Entities;
using JwtAuthenticationProject.Models;
using JwtProject.Models;

namespace JwtProject.Services
{
    public interface IAuthService
    {
        Task<User?> RegisterAsync(UserDto request);
        Task<TokenResponseDto?> LoginAsync(UserDto request);
        Task<TokenResponseDto?> RefreshTokensAsync(RefreshTokenRequestDto request);
    }
}
