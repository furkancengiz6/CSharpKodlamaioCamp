using HomeWork5.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5.Entities
{
    internal class Campaign:IEntitiy
    {
        public int Id { get; set; } 
        public string DiscountName { get; set; }
        public int Discount { get; set; }
    }
}
