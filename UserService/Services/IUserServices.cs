using UserService.DTO;
using UserService.Model;

namespace UserService.Services
{
    public interface IUserServices
    {
        Task<UserDTO> RegisterUser(RegisterUserDTO registerUserDTO);
        Task<string> LoginUser(LoginDTO loginDTO);
        Task<string> GenerateAccessToken(User user);
        Task<string> GenerateRefreshToken();
    }
}
