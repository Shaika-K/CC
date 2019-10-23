using CampaignCompanion.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CampaignCompanion.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterPage : ContentPage
    {
        public MasterPage()
        {
            InitializeComponent();
            this.BindingContext = new MasterPageViewModel();
        }

        //async void GoToSettings(object sender, EventArgs e)
        //{
        //    await Navigation.PushAsync(new Settings());
        //}
    }
}