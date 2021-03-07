using GamingProject.Abstract;
using GamingProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamingProject.Concerte
{
    class SaleManager : ISaleService
    {
        public void Add(User user, Game game, Campaign campaign)
        {
            Console.WriteLine("Game Added =  " + game.GameName  +user.FirstName + user.LastName + campaign.CampaignType);           
                }

        public void Delete(User user, Game game, Campaign campaign)
        {
            Console.WriteLine("Game Deleted =  " + game.GameName + user.FirstName + user.LastName + campaign.CampaignType);
        }

        public void Update(User user, Game game, Campaign campaign)
        {
            Console.WriteLine("Game Updated =  " + game.GameName + user.FirstName + user.LastName + campaign.CampaignType);
        }
    }
}
