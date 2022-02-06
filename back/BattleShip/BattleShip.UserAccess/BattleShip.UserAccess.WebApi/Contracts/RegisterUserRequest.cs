namespace BattleShip.UserAccess.WebApi.Contracts
{
    public class RegisterUserRequest
    {
        public string Login { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public string Name { get; set; }
    }
}
