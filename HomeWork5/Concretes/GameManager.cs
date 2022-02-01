using HomeWork5.Abstract;
using HomeWork5.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5.Concretes
{
    public class GameManager : IGameService
    {
        public void Gamesales(Games game, Player player, Campaign campaign) => Console.WriteLine("Oyun satıldı" + game.GameName + "Kampaynya ismi: "+campaign.DiscountName+"Fiyatı" + game.Price +"Kapmanya Fiyatı"+campaign.Discount+ "Satan Kişi" + player.FirstName);
    }
}
