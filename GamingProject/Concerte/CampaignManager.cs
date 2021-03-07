using GamingProject.Abstract;
using GamingProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamingProject.Concerte
{
    class CampaignManager : ICampaignService
    {

     
        public void Add(Campaign campaign, Game game)
        {
                Console.WriteLine("Campaign Added = " + campaign.CampaignName + " " + campaign.CampaignType);

            game.GamePrice = game.GamePrice - game.GamePrice * 70 / 100;
            Console.WriteLine("New Price = "+(game.GamePrice) +"$");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Campaign Deleted");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Campaign Updated");
        }
    }
}
