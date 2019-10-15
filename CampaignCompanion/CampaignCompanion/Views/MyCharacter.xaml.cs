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
    public partial class MyCharacter : TabbedPage
    {
        public MyCharacter()
        {
            this.BindingContext = new MyCharacterViewModel();
            InitializeComponent();
        }
    }
}