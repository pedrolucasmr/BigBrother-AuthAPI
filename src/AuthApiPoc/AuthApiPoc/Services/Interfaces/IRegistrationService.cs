using AuthApiPoc.DTOs.Request;
using AuthApiPoc.Models.Enums;

namespace AuthApiPoc.Services.Interfaces
{
    public interface IRegistrationService
    {
        ErrorCode? ProcessRegistration(CreateRegistrationRequest request);
    }
}
