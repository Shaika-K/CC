using System;
using System.Collections.Generic;
using System.Text;

namespace CampaignCompanion.Model
{
    public class Campaign
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public User DungeonMaster { get; set; }
        public Dictionary<User, Character> Group { get; set; }
        //public string Map { get; set; }
    }
}
