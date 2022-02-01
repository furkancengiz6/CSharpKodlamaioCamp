using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;

           //Bunu böyle yaparsan mernise bağlısın mernis bozulursa seninde bozulur test amaçlı bişey yapamazsın
           //o yüzden bağlılık enjeksiyonu adaptör yeni klasör 
           //MernisServiceReference.KPSPublicSoapClient client = new MernisServiceReference.KPSPublicSoapClient();
        }
    }
}
