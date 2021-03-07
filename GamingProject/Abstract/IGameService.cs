using GamingProject.Concrete;
using GamingProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamingProject.Abstract
{
     interface IGameService
    {
        void Add(Game game);
        void Update(Game game);
      

    }
}
