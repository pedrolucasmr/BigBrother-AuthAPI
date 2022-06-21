using AuthApiPoc.Models;

namespace AuthApiPoc.Repositories.Interfaces
{
    public interface ITemporaryUserRepository
    {
        bool InsertTemporaryUser(ITemporaryUserRepository user);
    }
}
