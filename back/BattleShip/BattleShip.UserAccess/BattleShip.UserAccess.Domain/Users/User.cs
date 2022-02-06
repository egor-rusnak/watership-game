using BuildingBlocks.Domain;
using BattleShip.UserAccess.Domain.Users.Rules;
using BattleShip.UserAccess.Domain.Users.Interfaces;

namespace BattleShip.UserAccess.Domain.Users
{
    public class User : Entity
    {
        public UserId Id { get; private set; }

        private string _login;

        private string _password;

        private string _email;

        private string _name;

        private User() { }

        public static User CreateUser(string login, string password, string email, string name, IUsersCounter usersCounter)
        {
            return new User(login, password, email, name, usersCounter);
        }

        private User(string login, string password, string email, string name, IUsersCounter usersCounter)
        {
            CheckRule(new UserEmailMustBeUniqueBusinessRule(usersCounter, email));
            CheckRule(new UserLoginMustBeUniqueBusinessRule(usersCounter, login));

            Id = new UserId(Guid.NewGuid());
            _login = login;
            _password = password;
            _email = email;
            _name = name;
        }
    }
}
