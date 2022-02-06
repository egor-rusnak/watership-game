using BuildingBlocks.Domain;

namespace BattleShip.UserAccess.Domain.Users
{
    public class UserId : TypedIdValueBase
    {
        public UserId(Guid value) : base(value) { }
    }
}
