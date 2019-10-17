using CampaignCompanion.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace CampaignCompanion.ViewModel
{
    public class SpellsViewModel : BindableObject
    {
        public ObservableCollection<Spell> Spells { get; set; }

        public SpellsViewModel() {
            Spells = new ObservableCollection<Spell>
            {
                new Spell
                {
                    Name = "Eldritch Blast",
                    Description = "hyhohdkjwheuhwur fjdhfuewyruw 2347uhcd iu398o3eo. jkdjeiw jeij32 ijr39c4,.r94 rur932jlrwekjr 3.",
                    Level = 5,
                    CastingTime = "1 min",
                    Range = 5,
                    Components = new List<string> {"V","M" },
                    ClassSpecific = false
                }
            };
        }
    }
}
