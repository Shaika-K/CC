using System;
using System.Collections.Generic;
using System.Text;

namespace CampaignCompanion.Model
{
    public class Spell
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int Level { get; set; }

        public string CastingTime { get; set; }

        public int Range { get; set; }

        public string Duration { get; set; }
        
        //(V)erbal, (S)omatic, (M)aterial, (F)ocus, (DF) Devine Focus, (XP)experience
        public List<string> Components { get; set; }

        public List<string> ClassSpecific { get; set; }
    }
}
