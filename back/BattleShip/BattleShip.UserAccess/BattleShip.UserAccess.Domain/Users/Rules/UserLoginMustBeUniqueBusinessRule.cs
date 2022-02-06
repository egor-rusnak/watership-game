using BattleShip.UserAccess.Domain.Users.Interfaces;
using BuildingBlocks.Domain;

namespace BattleShip.UserAccess.Domain.Users.Rules
{
    public class UserLoginMustBeUniqueBusinessRule : IBusinessRule
    {
        public string _login;

        public IUsersCounter _userCounter;

        public UserLoginMustBeUniqueBusinessRule(IUsersCounter usersCounter, string login)
        {
            _userCounter = usersCounter;
            _login = login;
        }

        public string Message => "User login must be unique (please, suck dick)";

        public bool IsBroken() => _userCounter.GetUniqueLoginCount(_login) > 0;
    }
}
