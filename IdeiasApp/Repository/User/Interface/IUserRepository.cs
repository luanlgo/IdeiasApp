using IdeiasApp.Domain.Login.Infaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace IdeiasApp.Repository.User.Interface
{
    public interface IUserRepository
    {

        void Add(IUser user);

        void Delete(IUser user);

        void List();

        IUser Find(IUser user);

    }
}
