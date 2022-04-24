using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameDemoProject.Abstract;

namespace GameDemoProject.Entities
{
    public class Campaign:IEntity
    {
        public int Id { get; set; }
        public string CampaignName { get; set; }
        public string Description { get; set; }
        public DateTime DeadLine { get; set; }
    }
}
