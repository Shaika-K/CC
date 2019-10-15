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
                //TODO Switch statement
                if (item.Title == "My Character")
                {
                    Detail = new NavigationPage(new MyCharacter());
                    masterPage.listView.SelectedItem = null;
                    IsPresented = false;
                }
                else
                {
                    Detail = new NavigationPage(new AllNpcs());
                    masterPage.listView.SelectedItem = null;
                    IsPresented = false;
                }
            }

        }
    }
}