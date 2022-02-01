using HomeWork5.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5.Entities
{
    public class Player : IEntitiy
    {
        
        public int Id { get; set; }
        //Normalde tc string olması lazım çünkü bu matematiksel bir ifade değildir!!!!!!!!!
        public long NationalityId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }
    }
}