using CampaignCompanion.Model;
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

        public MasterPageViewModel()
        {
            ListView = new ObservableCollection<MasterPageItem>();
            ListView.Add(new MasterPageItem
            {
                Title = "My Character",
                IconSource = "contacts.png",
                TargetType = typeof(MyCharacterViewModel)
            });
            ListView.Add(new MasterPageItem
            {
                Title = "All NPCs'",
                IconSource = "todo.png",
                TargetType = typeof(AllNpcsViewModel)
            });
            ListView.Add(new MasterPageItem
            {
                Title = "Story",
                IconSource = "todo.png",
                TargetType = typeof(StoryViewModel)
            });
            ListView.Add(new MasterPageItem
            {
                Title = "Map",
                IconSource = "todo.png",
                TargetType = typeof(MapViewModel)
            });
        }
    }
}