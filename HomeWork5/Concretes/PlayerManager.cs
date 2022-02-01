using HomeWork5.Abstract;
using HomeWork5.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HomeWork5.Concretes
{
    public class PlayerManager : IPlayerService
    {

        ICheckRealPerson _checkRealPerson;

        public PlayerManager(ICheckRealPerson checkRealPerson)
        {
            _checkRealPerson = checkRealPerson;
        }

        public void Register(Player player)
        {

            if (_checkRealPerson.CheckIfRealPerson(player)){
                Console.WriteLine("Kayıt edildi");
            }
            else {
                throw new Exception("Not a valid player");
            }       
        }

        public void Unregister(Player player)
        {
            Console.WriteLine("Kayıt silindi");
        }

        public void Update(Player player)
        {
            Console.WriteLine("Kayıt güncellendi");
        }
    }
}
