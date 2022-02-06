using BattleShip.UserAccess.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip.UserAccess.Domain.Users.Interfaces
{
    public interface IUserRepository
    {
        Task AddAsync(User user);
    }
}
