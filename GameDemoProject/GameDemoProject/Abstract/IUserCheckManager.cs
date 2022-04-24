using GameDemoProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemoProject.Abstract
{
    public interface IUserCheckManager
    {
        bool CheckIfRealPerson(User user);
    }
}
