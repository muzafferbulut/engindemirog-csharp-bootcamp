using GameDemoProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemoProject.Concrete
{
    public class CampaignManager
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Added: "+campaign.CampaignName);
        }
        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Deleted: "+campaign.CampaignName);
        }
    }
}
