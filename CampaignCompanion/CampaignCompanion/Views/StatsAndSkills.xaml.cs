using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CampaignCompanion.ViewModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CampaignCompanion.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StatsAndSkills : ContentPage
    {
        public StatsAndSkills()
        {
            this.BindingContext = new StatsAndSkillsViewModel();
            InitializeComponent();
        }
    }
}