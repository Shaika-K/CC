using CC.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CC.ViewModel
{
    class MainPageViewModel : MasterDetailPage
    {
        MasterPageViewModel masterPage;

        public MainPageViewModel()
        {
            masterPage = new MasterPageViewModel();
            Master = masterPage;
            Detail = new NavigationPage(new MyCharacterViewModel());

            masterPage.ListView.ItemSelected += OnItemSelected;         
        }

        void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterPageItem;
            if (item != null)
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
                masterPage.ListView.SelectedItem = null;
                IsPresented = false;
            }
        }
    }
}
