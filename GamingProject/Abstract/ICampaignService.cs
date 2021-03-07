using GamingProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamingProject.Abstract
{
     interface ICampaignService
    {
        void Add(Campaign campaign , Game game);
        void Delete(Campaign campaign);
        void Update(Campaign campaign);

    }
}
