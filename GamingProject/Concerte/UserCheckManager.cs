using GamingProject.Abstract;
using GamingProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamingProject.Concerte
{
     class UserCheckManager : IUserCheckService
    {
        public bool CheckIfRealPerson(User user)
        {
                return true;

        }
    }
}
