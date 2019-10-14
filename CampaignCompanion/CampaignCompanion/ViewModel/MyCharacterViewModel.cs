using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace CampaignCompanion.ViewModel
{
    public class MyCharacterViewModel : ContentPage
    {
        public MyCharacterViewModel()
        {
            Title = "My Character Page";
            Content = new StackLayout
            {
                Children = {
                    new Label {
                        Text = "My Character",
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.CenterAndExpand
                    }
                }
            };
        }
    }
}