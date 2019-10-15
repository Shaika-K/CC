using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace CampaignCompanion.ViewModel
{
    public class MyCharacterViewModel : BindableObject
    {
        public ProfileViewModel ProfileViewTab { set; get; }

        public StatsAndSkillsViewModel StatsAndSkillsViewTab { set; get; }

        public PossesionsViewModel PossesionsViewTab { set; get; }

        public SpellsViewModel SpellsViewTab { set; get; }

        public MyCharacterViewModel()
        {
            ProfileViewTab = new ProfileViewModel();
            StatsAndSkillsViewTab = new StatsAndSkillsViewModel();
            PossesionsViewTab = new PossesionsViewModel();
            SpellsViewTab = new SpellsViewModel();
        }
    }
}