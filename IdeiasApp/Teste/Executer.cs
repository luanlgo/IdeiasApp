using IdeiasApp.Domain.Login;
using IdeiasApp.Domain.Login.Infaces;
using IdeiasApp.Repository.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace IdeiasApp.Teste
{
    class Executer
    {

        public static void Main(String[] args)
        {

            IUser Pedro = new User("pedro@gmail.com");
            Pedro.Name = "Pedro";

            UserRepository repository = new UserRepository();
            repository.Add(Pedro);

            repository.List();

            Console.ReadKey();
        }

    }
}
