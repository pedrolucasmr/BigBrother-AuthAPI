using AuthApiPoc.Models.DTOs.Request;
using AuthApiPoc.Models.Models.Enums;

namespace AuthApiPoc.Business.Services.Interfaces
{
    public interface IRegistrationService
    {
        Task<ErrorCode?> ProcessRegistration(CreateRegistrationRequest request);

        Task<ErrorCode?> CompleteRegistration(CompleteRegistrationRequest request);
    }
}
