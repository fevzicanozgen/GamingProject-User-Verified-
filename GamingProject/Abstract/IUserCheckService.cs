using GamingProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamingProject.Abstract
{
    interface IUserCheckService
    {
        bool CheckIfRealPerson(User user);

    }
}
