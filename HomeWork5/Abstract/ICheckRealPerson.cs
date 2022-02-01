using HomeWork5.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5.Abstract
{
    public interface ICheckRealPerson
    {
        bool CheckIfRealPerson(Player player);
    }
}
