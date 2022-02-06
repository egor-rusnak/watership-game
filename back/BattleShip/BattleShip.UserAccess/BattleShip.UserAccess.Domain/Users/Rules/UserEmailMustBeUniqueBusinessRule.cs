using BattleShip.UserAccess.Domain.Users.Interfaces;
using BuildingBlocks.Domain;

namespace BattleShip.UserAccess.Domain.Users.Rules
{
    public class UserEmailMustBeUniqueBusinessRule : IBusinessRule
    {
        public string _email;

        public IUsersCounter _userCounter;

        public UserEmailMustBeUniqueBusinessRule(IUsersCounter usersCounter, string email)
        {
            _userCounter = usersCounter;
            _email = email;
        }

        public string Message => "User email must be unique (please, suck dick)";

        public bool IsBroken() => _userCounter.GetUniquEmailCount(_email) > 0;
    }
}
