﻿using AuthApiPoc.Models;

namespace AuthApiPoc.Repositories.Interfaces
{
    public interface IUserRepository
    {
        bool InsertUser(User user);
        User GetUserById(Guid id);
        User GetUserByEmail(string email);
    }
}
