using GamingProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamingProject.Abstract
{
     interface IUserService 
    {
        void Save(User user);
        void Delete(User user);
        void Update(User user);
    }
}
