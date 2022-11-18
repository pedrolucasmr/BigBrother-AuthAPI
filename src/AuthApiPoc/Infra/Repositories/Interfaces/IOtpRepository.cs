using AuthApiPoc.Models.Models;

namespace AuthApiPoc.Infra.Repositories.Interfaces
{
    public interface IOtpRepository
    {
        Task<bool> InsertAsync(Otp otp);
        Task<Otp> GetAsync(string id);
    }
}
