using GamingProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamingProject.Entities
{
    class User 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Id { get; set; }     
        public string IdentityNumber { get; set; }

    }
}
