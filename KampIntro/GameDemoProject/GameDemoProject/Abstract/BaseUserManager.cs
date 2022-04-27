using GameDemoProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemoProject.Abstract
{
    public abstract class BaseUserManager : IUserManager
    {
        public void Buy(Game game, User user)
        {
            Console.WriteLine(user.FirstName +" bought: "+game.GameName);
        }

        public void Register(User user)
        {
            Console.WriteLine("Approved: "+user.FirstName+" "+user.LastName);
        }

        public void Sell(Game game, User user)
        {
            Console.WriteLine(user.FirstName + " sold: " + game.GameName);
        }
    }
}
