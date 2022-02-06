using BattleShip.UserAccess.Application.Configuration;
using BattleShip.UserAccess.Domain.Users;
using BattleShip.UserAccess.Domain.Users.Interfaces;
using MediatR;

namespace BattleShip.UserAccess.Application.Users.RegisterNewUser
{
    public class RegisterNewUserCommandHandler : ICommandHandler<RegisterNewUserCommand>
    {
        private readonly IUsersCounter _usersCounter;
        private readonly IUserRepository _userRepository;

        public RegisterNewUserCommandHandler(IUsersCounter usersCounter, IUserRepository userRepository)
        {
            _usersCounter = usersCounter;
            this._userRepository = userRepository;
        }

        public async Task<Unit> Handle(RegisterNewUserCommand request, CancellationToken cancellationToken)
        {
            //TODO: Hash password
            var registeredUser = User.CreateUser(
                request.Login, 
                request.Password, 
                request.Email, 
                request.Name,
                _usersCounter);

            await _userRepository.AddAsync(registeredUser);
            return Unit.Value;
        }
    }
}
