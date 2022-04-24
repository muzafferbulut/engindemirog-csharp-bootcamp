using GameDemoProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemoProject.Abstract
{
    public interface IUserManager
    {
        void Register(User user);
        void Buy(Game game, User user);
        void Sell(Game game, User user);

    }
}
