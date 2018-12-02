using IdeiasApp.Domain.Login.Infaces;
using IdeiasApp.Repository.User.Interface;
using System;
using System.Collections.Generic;

namespace IdeiasApp.Repository.User
{
    public class UserRepository :IUserRepository
    {

        List<IUser> Usuarios;

        public UserRepository()
        {
            Usuarios = new List<IUser>();
        }

        public void Add(IUser user)
        {
            Usuarios.Add(user);
        }

        public void Delete(IUser user)
        {
            Usuarios.Remove(user);
        }

        public IUser Find(IUser user)
        {
            foreach(IUser usuario in Usuarios)
            {
                if (usuario == user)
                    return usuario;
            }
            return null;
        }

        public void List()
        {
            foreach(IUser usuario in Usuarios)
            {
                Console.WriteLine( usuario.ToString());
            }
        }
    }
}
