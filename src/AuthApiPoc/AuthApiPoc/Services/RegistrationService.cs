using AuthApiPoc.DTOs.Request;
using AuthApiPoc.Models.Enums;
using AuthApiPoc.Repositories.Interfaces;
using AuthApiPoc.Services.Interfaces;

namespace AuthApiPoc.Services
{
    public class RegistrationService : IRegistrationService
    {
        private readonly IUserRepository _userRepository;
        private readonly ITemporaryUserRepository _temporaryUserRepository;

        public RegistrationService()
        {

        }

        public ErrorCode? ProcessRegistration(CreateRegistrationRequest request)
        {
            return null;
        }
    }
}
