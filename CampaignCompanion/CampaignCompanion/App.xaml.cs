using CampaignCompanion.Model;
using CampaignCompanion.Views;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CampaignCompanion
{
    public partial class App : Application
    {
        public Campaign TheCampaign;
        public User CurrentUser;
        public User DM;
        public bool IsLoggedIn;

        public App()
        {
            //MainPage = new NavigationPage(new CampaignCompanion.Views.MainPage());   
            MainPage = new CampaignCompanion.Views.MainPage();
            MainPage.SetValue(NavigationPage.BarBackgroundColorProperty, Color.FromHex("161616"));            

            //Initialise
            Constants.DummyUser.Campaigns = new Dictionary<Campaign, Character>{
                {Constants.DummyCampaign, Constants.DummyCharacter}
            };

            Constants.DummyCampaign.Group = new Dictionary<User, Character> {
                {Constants.DummyUser, Constants.DummyCharacter }
            };

            Constants.TheDM.Campaigns = new Dictionary<Campaign, Character>{
                {Constants.DummyCampaign, null}
            };

            Constants.DummyCampaign.DungeonMaster = Constants.TheDM;

            TheCampaign = Constants.DummyCampaign;
            CurrentUser = Constants.DummyUser;
            DM = Constants.TheDM;
            IsLoggedIn = true;
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