using GamingProject.Abstract;
using GamingProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamingProject.Concrete
{
     class UserCheckManager : IUserCheckService
    {
        public bool CheckIfRealPerson(User user)
        {
                return true;

        }
    }
}
