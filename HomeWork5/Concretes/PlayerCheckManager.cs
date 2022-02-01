using HomeWork5.Abstract;
using HomeWork5.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5.Concretes
{
    public class PlayerCheckManager : ICheckRealPerson
    {
        public bool CheckIfRealPerson(Player player)
        {
            return true;
        }
    }
}
