using BattleShip.UserAccess.Application.Contracts;
using MediatR;

namespace BattleShip.UserAccess.Application.Configuration
{
    public interface ICommandHandler<in TCommand>: IRequestHandler<TCommand> where TCommand: ICommand
    {
    }
}