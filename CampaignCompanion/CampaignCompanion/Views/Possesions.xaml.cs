using CampaignCompanion.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CampaignCompanion.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Possesions : ContentPage
    {
        public ObservableCollection<string> Armour { get; private set; }
        public ObservableCollection<string> Weapon { get; private set; }
        public ObservableCollection<string> Money { get; private set; }
        public ObservableCollection<string> PetsAndVehicles { get; private set; }
        public ObservableCollection<string> Potions { get; private set; }
        public ObservableCollection<string> Artifacts { get; private set; }

        public Possesions()
        {
            this.BindingContext = new PossesionsViewModel();
            InitializeComponent();
            Money = new ObservableCollection<string>();
        }
    }
}