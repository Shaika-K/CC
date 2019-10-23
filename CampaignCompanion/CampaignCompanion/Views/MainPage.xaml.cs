using CampaignCompanion.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CampaignCompanion.Views
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            //NavigationPage.SetHasNavigationBar(this, false);
            masterPage.listView.ItemSelected += OnItemSelected;
            masterPage.SettingsButton.Clicked += OnSettingsButtonClicked;
        }

        void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterPageItem;
            if (item != null)
            {

                switch (item.Title) {
                    case "All Story Characters":
                        Detail = new NavigationPage(new AllNpcs());
                        break;
                    case "Story":
                        Detail = new NavigationPage(new Story());
                        break;
                    case "Map":
                        Detail = new NavigationPage(new Map());
                        break;
                        //TODO chnage the dice and calendar
                    case "Calendar":
                        Detail = new NavigationPage(new Map());
                        break;
                    case "Dice":
                        Detail = new NavigationPage(new Map());
                        break;
                    default:
                        Detail = new NavigationPage(new MyCharacter());
                        break;
                }
                ((NavigationPage)Detail).BarBackgroundColor = Color.FromHex("161616");
                masterPage.listView.SelectedItem = null;
                IsPresented = false;
            }

        }

        void OnSettingsButtonClicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Settings());
            ((NavigationPage)Detail).BarBackgroundColor = Color.FromHex("161616");
            masterPage.listView.SelectedItem = null;
            IsPresented = false;
        }
    }
}