using GamingProject.Abstract;
using GamingProject.Entities;
using MenrisReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamingProject.Adapter
{
    class MernisServiceAdapter : IUserCheckService
    {
        public bool CheckIfRealPerson(User user)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);
         
                return client.TCKimlikNoDogrulaAsync(Convert.ToInt64(user.IdentityNumber), user.FirstName.ToUpper(), user.LastName.ToUpper(), user.DateOfBirth.Year).Result.Body.TCKimlikNoDogrulaResult;
            
        }
    }
}
