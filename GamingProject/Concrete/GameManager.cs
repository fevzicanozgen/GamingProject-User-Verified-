using GamingProject.Abstract;
using GamingProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamingProject.Concrete
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {

            Console.WriteLine("The Game has been Purchased. = "+ game.GameName );
            Console.WriteLine("Game Price = " + game.GamePrice+"$");

        }

        public void Update(Game game)
        {
            Console.WriteLine("Game Deleted" +game.GameName);
        }
    }
}
