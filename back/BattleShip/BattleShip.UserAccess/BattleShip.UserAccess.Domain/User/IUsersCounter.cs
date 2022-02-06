namespace BattleShip.UserAccess.Domain.User
{
    public interface IUsersCounter
    {
        int GetUniqueLoginCount(string login);

        int GetUniquEmailCount(string email);
    }
}
