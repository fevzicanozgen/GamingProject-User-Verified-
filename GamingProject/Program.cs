using GamingProject.Adapter;
using GamingProject.Concerte;
using GamingProject.Entities;
using System;

namespace GamingProject
{
    class Program
    {
        static void Main(string[] args)
        {
           
                UserManager usermanager = new UserManager(new MernisServiceAdapter());
                User user = new User
                {
                    FirstName = "Fevzican",
                    LastName = "Hepkasar",
                    DateOfBirth = new DateTime(1995, 6, 5),
                    Id = 1,
                    IdentityNumber = "Pls Write Identity Number"
                };

                usermanager.Save(user);
                GameManager gameManager1 = new GameManager();
                Game game1 = new Game { Id = 1, GameName = "League Of Legends", GamePrice = 150 };
            if (user.FirstName == "Fevzican" && user.LastName == "Hepkasar" && user.DateOfBirth.Year == 1995 && user.IdentityNumber== "Pls Write Identity Number")
            {
                gameManager1.Add(game1);

                CampaignManager campaignManager = new CampaignManager();
                Campaign campaign = new Campaign
                {
                    Id = 1,
                    CampaignName = "Black Friday",
                    CampaignType = "%70 discount!!!"
                };
                campaignManager.Add(campaign, game1);

            }
          

        }
    }
}
