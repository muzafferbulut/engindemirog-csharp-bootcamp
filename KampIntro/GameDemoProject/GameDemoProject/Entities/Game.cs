using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameDemoProject.Abstract;

namespace GameDemoProject.Entities
{
    public class Game:IEntity
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
    }
}
