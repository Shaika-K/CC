using CampaignCompanion.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CampaignCompanion
{
    public partial class App : Application
    {
        public App()
        {
            //MainPage = new NavigationPage(new CampaignCompanion.Views.MainPage());   
            MainPage = new CampaignCompanion.Views.MainPage();
            MainPage.SetValue(NavigationPage.BarBackgroundColorProperty, Color.FromHex("161616"));
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}