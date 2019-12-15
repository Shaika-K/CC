using CampaignCompanion.Model;
using CampaignCompanion.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace CampaignCompanion.ViewModel
{
    public class MasterPageViewModel : BindableObject
    {
        public ObservableCollection<MasterPageItem> ListView { get; private set; }

        ListView listView;

        public string MyImageSource;

        Button SettingsButton;

        public MasterPageViewModel()
        {
            MyImageSource = "cc.png";            

            ListView = new ObservableCollection<MasterPageItem>();
            ListView.Add(new MasterPageItem
            {
                Title = "My Character",
                IconSource = "characterwhite.png",
                TargetType = typeof(MyCharacterViewModel)
            });
            ListView.Add(new MasterPageItem
            {
                Title = "All Story Characters",
                IconSource = "npcswhite.png",
                TargetType = typeof(AllNpcsViewModel)
            });
            ListView.Add(new MasterPageItem
            {
                Title = "Story",
                IconSource = "storywhite.png",
                TargetType = typeof(StoryViewModel)
            });
            ListView.Add(new MasterPageItem
            {
                Title = "Map",
                IconSource = "mapwhite.png",
                TargetType = typeof(MapViewModel)
            });
            //TODO chnage to appropriate vm
            ListView.Add(new MasterPageItem
            {
                Title = "Calendar",
                IconSource = "calendarwhite.png",
                TargetType = typeof(MapViewModel)
            });
            ListView.Add(new MasterPageItem
            {
                Title = "Dice",
                IconSource = "dicewhite.png",
                TargetType = typeof(MapViewModel)
            });
        }
        
    }
}