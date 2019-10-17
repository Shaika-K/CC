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
            masterPage.listView.ItemSelected += OnItemSelected;
        }

        void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterPageItem;
            if (item != null)
            {

                switch (item.Title) {
                    case "All NPCs'":
                        Detail = new NavigationPage(new AllNpcs());
                        ((NavigationPage)Detail).BarBackgroundColor = Color.Black;
                        break;
                    case "Story":
                        Detail = new NavigationPage(new Story());
                        ((NavigationPage)Detail).BarBackgroundColor = Color.Black;
                        break;
                    case "Map":
                        Detail = new NavigationPage(new Map());
                        ((NavigationPage)Detail).BarBackgroundColor = Color.Black;
                        break;
                    default:
                        Detail = new NavigationPage(new MyCharacter());
                        ((NavigationPage)Detail).BarBackgroundColor = Color.Black;
                        break;
                }
                masterPage.listView.SelectedItem = null;
                IsPresented = false;
            }

        }
    }
}