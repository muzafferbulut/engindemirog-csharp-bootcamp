using GameDemoProject.Abstract;
using GameDemoProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemoProject.Concrete
{
    class UserCheckManager : IUserCheckManager
    {
        public bool CheckIfRealPerson(User user)
        {
            return true;
        }
    }
}
