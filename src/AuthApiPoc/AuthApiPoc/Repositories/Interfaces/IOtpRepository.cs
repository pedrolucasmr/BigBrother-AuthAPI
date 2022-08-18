using AuthApiPoc.Models;

namespace AuthApiPoc.Repositories.Interfaces
{
    public interface IOtpRepository
    {
        Task<bool> InsertAsync(Otp otp);
        Task<Otp> GetAsync(string id);
    }
}
