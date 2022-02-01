using HomeWork5.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5.Abstract
{
    public interface ICampaignService
    {
        void CampaignAdd(Games games,Player player,Campaign campaign);
        void CampaignDelete(Games games, Player player, Campaign campaign);
        void CampaignUpdate(Games games, Player player, Campaign campaign);
    }
}
