using CampaignCompanion.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using System.Linq;

namespace CampaignCompanion.ViewModel
{
    public class StatsAndSkillsViewModel : BindableObject
    {
        public ObservableCollection<Skill> Skills { get; set; }        

        public StatsAndSkillsViewModel() {
            Skills = new ObservableCollection<Skill>();
            foreach (string skill in Constants.AllSkills)
            {
                Skills.Add(new Skill {
                    Name = skill,
                    IsProficient = false,
                    Ammount = 0
                });
            }
        }
    }
}
