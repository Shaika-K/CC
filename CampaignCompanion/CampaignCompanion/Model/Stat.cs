using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CampaignCompanion.Model
{
    public class Stat
    {
        public ObservableCollection<Entity> AllAbility { get; set; }

        public ObservableCollection<Entity> AllCharacteristics { get; set; }

        public ObservableCollection<Entity> AllBuffs { get; set; }

        public ObservableCollection<Entity> AllSavingThrows { get; set; }
    }
}
