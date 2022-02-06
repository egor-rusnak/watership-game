namespace BattleShip.UserAccess.Domain.Users.Interfaces
{
    public interface IUsersCounter
    {
        int GetUniqueLoginCount(string login);

        int GetUniquEmailCount(string email);
    }
}
