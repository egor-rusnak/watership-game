using BuildingBlocks.Domain;

namespace BattleShip.UserAccess.Domain.User
{
    public class UserId : TypedIdValueBase
    {
        public UserId(Guid value) : base(value) { }
    }
}
