using System;
using System.Collections.Generic;
using System.Text;

namespace CampaignCompanion.Model
{
    public class Skill
    {
        public string Name { get; set; }

        public Boolean IsProficient { get; set; }

        public int Ammount { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
