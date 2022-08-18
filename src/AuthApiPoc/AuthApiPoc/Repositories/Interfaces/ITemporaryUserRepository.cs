using AuthApiPoc.Models;

namespace AuthApiPoc.Repositories.Interfaces
{
    public interface ITemporaryUserRepository
    {
        Task<bool> InsertTemporaryUser(TemporaryUser user);
        TemporaryUser GetTemporaryUserById(Guid id);
        TemporaryUser GetTemporaryUserByEmail(string email);
    }
}
