using IdeiasApp.Domain.Login.Infaces;
using System;

namespace IdeiasApp.Domain.Login
{
    public class User : IUser
    {

        public User(string Email)
        {
            this.Id = new Guid();
            this.Email = Email;
        }

        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public override string ToString()
        {
            return Id + " " + Email + " " + Name;
        }

    }

}
