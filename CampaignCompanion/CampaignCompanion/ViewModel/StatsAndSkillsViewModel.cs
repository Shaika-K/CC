using CampaignCompanion.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace CampaignCompanion.ViewModel
{
    public class StatsAndSkillsViewModel : BindableObject
    {
        public ObservableCollection<Skill> Skills { get; set; }        

        public StatsAndSkillsViewModel() {
            Skills = new ObservableCollection<Skill>
            {
                new Skill
                {
                    Name = "Acrobatics",
                    IsProficient = false,
                    Ammount = 5
                },
                new Skill
                {
                    Name = "Animal Handling",
                    IsProficient = false,
                    Ammount = 5
                },
                new Skill
                {
                    Name = "Arcana",
                    IsProficient = false,
                    Ammount = 5
                },
                new Skill
                {
                    Name = "Athletics",
                    IsProficient = false,
                    Ammount = 5
                },
                new Skill
                {
                    Name = "Deception",
                    IsProficient = false,
                    Ammount = 5
                },
                new Skill
                {
                    Name = "History",
                    IsProficient = false,
                    Ammount = 5
                },
                new Skill
                {
                    Name = "Insight",
                    IsProficient = false,
                    Ammount = 5
                },
                new Skill
                {
                    Name = "Intimidation",
                    IsProficient = false,
                    Ammount = 5
                },
                new Skill
                {
                    Name = "Investigation",
                    IsProficient = false,
                    Ammount = 5
                },
                new Skill
                {
                    Name = "Medicine",
                    IsProficient = false,
                    Ammount = 5
                },
                new Skill
                {
                    Name = "Nature",
                    IsProficient = false,
                    Ammount = 5
                },
                new Skill
                {
                    Name = "Perception",
                    IsProficient = false,
                    Ammount = 5
                },
                new Skill
                {
                    Name = "Performance",
                    IsProficient = false,
                    Ammount = 5
                },
                new Skill
                {
                    Name = "Persuasion",
                    IsProficient = false,
                    Ammount = 5
                },
                new Skill
                {
                    Name = "Religion",
                    IsProficient = false,
                    Ammount = 5
                },
                new Skill
                {
                    Name = "Sleight of Hand",
                    IsProficient = false,
                    Ammount = 5
                },
                new Skill
                {
                    Name = "Stealth",
                    IsProficient = false,
                    Ammount = 5
                },
                new Skill
                {
                    Name = "Surival",
                    IsProficient = false,
                    Ammount = 5
                }
            };
        }
    }
}
