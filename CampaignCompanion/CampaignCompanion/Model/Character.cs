using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace CampaignCompanion.Model
{
    public class Character
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public int Level { get; set; }

        public string Race { get; set; }

        public string Class { get; set; }

        public string Background { get; set; }

        public Stat Stats { get; set; }

        //List of spells, cantrips and inovations that inherit type Spell
        public ObservableCollection<Spell> Spells { get; set; }

        public ObservableCollection<Skill> Skills { get; set; }

        //should be a type called Wearable or something
        public ObservableCollection<Entity> Possesions { get; set; }

        public ObservableCollection<Entity> Money { get; set; }

        public Image ProfilePic { get; set; }
    }
}