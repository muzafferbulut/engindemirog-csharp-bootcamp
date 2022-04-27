using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class OrderManager : IOrderService
    {
        public void Sell(Campaign campaign)
        {
            Console.WriteLine("Sold with "+campaign.CampaignName);
        }
    }
}
