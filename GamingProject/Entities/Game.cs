using GamingProject.Abstract;
using GamingProject.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamingProject.Entities
{
    class Game : GameManager
    {
       

        public int Id { get; set; }
        public string GameName { get; set; }
        public int GamePrice { get; set; }
    }
}
