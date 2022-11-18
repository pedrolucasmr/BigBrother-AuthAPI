using AuthApiPoc.Business.DTOs.Request;
using AuthApiPoc.Business.Models.Enums;

namespace AuthApiPoc.Business.Services.Interfaces
{
    public interface IRegistrationService
    {
        Task<ErrorCode?> ProcessRegistration(CreateRegistrationRequest request);

        Task<ErrorCode?> CompleteRegistration(CompleteRegistrationRequest request);
    }
}
