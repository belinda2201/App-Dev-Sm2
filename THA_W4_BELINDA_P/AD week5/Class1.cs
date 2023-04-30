using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD_week5
{
    public class Team
    {
        public string teamName { get; set; }
        public string teamCountry { get; set; }
        public string teamCity { get; set; }
        public List<Player> Players = new List<Player>();
    }

    public class Player 
    {
        public string playerName { get; set; }
        public string playerNum { get; set; }
        public  string playerPos { get; set; }
    }
}
