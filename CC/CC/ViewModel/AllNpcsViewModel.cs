using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CC.ViewModel
{
    class AllNpcsViewModel : ContentPage
    {
        public AllNpcsViewModel()
        {
            Title = "Contacts Page";
            Content = new StackLayout
            {
                Children = {
                    new Label {
                        Text = "Contacts data goes here",
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.CenterAndExpand
                    }
                }
            };
        }
    }
}
