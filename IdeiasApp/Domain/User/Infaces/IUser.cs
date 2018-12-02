using System;

namespace IdeiasApp.Domain.Login.Infaces
{
    public interface IUser
    {

        Guid Id { get; set; }

        string Name { get; set; }

        string Email { get; set; }

    }
}
