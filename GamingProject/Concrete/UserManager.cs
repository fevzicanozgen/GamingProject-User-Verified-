using GamingProject.Abstract;
using GamingProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamingProject.Concrete
{
    class UserManager : IUserService
    {
        private IUserCheckService _userCheckService;

        public UserManager(IUserCheckService userCheckService)
        {
            _userCheckService = userCheckService;
        }

        public void Delete(User user)
        {
            Console.WriteLine("Deleted");
                }

        public void Save(User user)
        {
            if ( _userCheckService.CheckIfRealPerson(user))
            {
                Console.WriteLine("User verified.");
                Console.WriteLine("User = "+user.FirstName.ToUpper() + " " + user.LastName.ToUpper());
            }
            else
            {
                Console.WriteLine("User not verified. Pls Try Again");
            }
        }

        public void Update(User user)
        {
            Console.WriteLine("Updated");
        }
    }
}
