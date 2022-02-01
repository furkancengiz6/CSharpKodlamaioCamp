using HomeWork5.Abstract;
using HomeWork5.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork5.MernisService;
namespace HomeWork5.Adaters
{
    public class MernisServiceAdaper : ICheckRealPerson
    {
        public bool CheckIfRealPerson(Player player)
        {
            KPSPublicSoapClient kPSPublicSoapClient = new KPSPublicSoapClient();
            return kPSPublicSoapClient.TCKimlikNoDogrula(player.NationalityId,player.FirstName.ToUpper(),player.LastName.ToUpper(),player.BirthYear);
        }
    }

}