using CampaignCompanion.Services;
using CampaignCompanion.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CampaignCompanion.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Profile : ContentPage
    {
        //public Image image;

        public Profile()
        {
            this.BindingContext = new ProfileViewModel();
            InitializeComponent();
            picker.ItemsSource = Constants.AllRaces;
            picker2.ItemsSource = Constants.AllClasses;
            firstName.Text = Constants.DummyCharacter.FirstName;
            lastName.Text = Constants.DummyCharacter.LastName;
            level.Text = Constants.DummyCharacter.Level.ToString();
            picker.SelectedIndex = picker.ItemsSource.IndexOf(Constants.DummyCharacter.Race);
            picker2.SelectedIndex = picker2.ItemsSource.IndexOf(Constants.DummyCharacter.Class);
            age.Text = Constants.DummyCharacter.Age.ToString();
            background.Text = Constants.DummyCharacter.Background;
            //image.ImageSource = Constants.DummyCharacter.LastName;
        }

        async void OnPickPhotoButtonClicked(object sender, EventArgs e)
        {
            (sender as Button).IsEnabled = false;
            //Stream stream = await IPhotoPickerService.GetImageStreamAsync();
            Stream stream = await DependencyService.Get<IPhotoPickerService>().GetImageStreamAsync();
            if (stream != null)
            {
                profile.Source = ImageSource.FromStream(() => stream);
                photoButton.BackgroundColor = Color.Transparent;
                photoButton.BorderColor = Color.Transparent;
                photoButton.Text = "";
            }

            (sender as Button).IsEnabled = true;            

        }
    }
}