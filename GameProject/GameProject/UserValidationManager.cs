using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear==1998 && gamer.FirstName == "Muzaffer" && gamer.LastName=="Bulut" && gamer.TcNo==12345678912)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
