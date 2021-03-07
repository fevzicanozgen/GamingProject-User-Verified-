using GamingProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamingProject.Abstract
{
     interface  ISaleService
    {
        void Add(User user, Game game, Campaign campaign);
        void Update(User user, Game game, Campaign campaign);

        void Delete(User user, Game game, Campaign campaign);


    }
}
