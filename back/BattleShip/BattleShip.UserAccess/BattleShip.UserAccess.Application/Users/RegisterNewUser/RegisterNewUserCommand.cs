using BattleShip.UserAccess.Application.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip.UserAccess.Application.Users.RegisterNewUser
{
	public class RegisterNewUserCommand: ICommand
	{
        public RegisterNewUserCommand(
            string login,
            string password,
            string email,
            string name)
        {
            Login = login;
            Password = password;
            Email = email;
            Name = name;
        }

        public string Login { get; }
        public string Password { get; }
        public string Email { get; }
        public string Name { get; }
    }
}
