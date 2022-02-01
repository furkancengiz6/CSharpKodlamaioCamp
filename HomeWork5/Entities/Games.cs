using HomeWork5.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5.Entities
{
    public class Games:IEntitiy
    {

        public int Id { get; set; }
        public string GameName { get; set; }
        public int Price { get; set; }
    }
}
