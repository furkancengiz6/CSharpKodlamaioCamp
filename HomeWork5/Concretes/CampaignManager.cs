using HomeWork5.Abstract;
using HomeWork5.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5.Concretes
{
    internal class CampaignManager : ICampaignService
    {
        public void CampaignAdd(Games games, Player player, Campaign campaignr)
        {
            Console.WriteLine("Kampanya eklendi");
        }

        public void CampaignDelete(Games games, Player player, Campaign campaign)
        {
            Console.WriteLine("Kampanya silindi");
        }

        public void CampaignUpdate(Games games, Player player, Campaign campaign)
        {
            Console.WriteLine("Kampanya güncelendi");
        }
    }
}
