using Auth.Models.Dto;

namespace Auth.Service.IService
{
    public interface IAuthService
    {
        Task<string> Register(RegistrationRequestDto registrationRequestDto);
        Task<LoginResponseDto> Login(LoginResquestDto loginRequestDto);
    }
}
