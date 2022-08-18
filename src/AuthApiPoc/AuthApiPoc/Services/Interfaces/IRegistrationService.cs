using AuthApiPoc.DTOs.Request;
using AuthApiPoc.Models.Enums;

namespace AuthApiPoc.Services.Interfaces
{
    public interface IRegistrationService
    {
        Task<ErrorCode?> ProcessRegistration(CreateRegistrationRequest request);

        Task<ErrorCode?> CompleteRegistration(CompleteRegistrationRequest request);
    }
}
