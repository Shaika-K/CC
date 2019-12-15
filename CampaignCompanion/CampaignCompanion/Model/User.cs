using System;
using System.Collections.Generic;
using System.Text;

namespace CampaignCompanion.Model
{
    public class User
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Dictionary<Campaign, Character> Campaigns { get; set; }

    }
}
