using CampaignCompanion.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace CampaignCompanion
{
    public static class Constants
    {
        // TODO: images, font, colours, lists (currency, skills, ability, race, class)

        // IMAGES
        // Brand
        public static string Brand = "cc.png";
        // My Character
        public static string CharacterWhite = "characterwhite.png";
        public static string CharacterBlack = "characterblack.png";
        // All NPC's
        public static string PeopleWhite = "npcswhite.png";
        public static string PeopleBlack = "npcsblack.png";
        // Story
        public static string StoryWhite = "storywhite.png";
        public static string StoryBlack = "storyblack.png";
        // Map
        public static string MapWhite = "mapwhite.png";
        public static string MapBlack = "mapblack.png";
        // Calendar
        public static string CalendarrWhite = "calendarwhite.png";
        public static string CalendarBlack = "calendarblack.png";
        // Dice
        public static string DiceWhite = "dicewhite.png";
        public static string DiceBlack = "diceblack.png";
        // Settings
        public static string SettingsWhite = "settingswhite.png";
        public static string SettingsBlack = "settingsblack.png";
        // Plus or add
        public static string AddWhite = "addwhite.png";
        public static string AddBlack = "addblack.png";
        // TODO Minus
        // Close
        public static string CloseWhite = "closewhite.png";
        public static string CloseBlack = "closeblack.png";
        // TODO Save
        // Edit
        public static string EditWhite = "editwhite.png";
        public static string EditBlack = "editblack.png";
        // Collapse or Expand

        // FONTS
        // Decor font
        public static string DecorFont = "BerkshireSwash-Regular.ttf#BerskshireSwash";
        // Body font
        public static string BodyFont = "RobotoSlab-Regular.ttf#RobotoSlab";

        // COLOURS        
        // AlmostBlack
        public static Color AlmostBlack = Color.FromHex("161616");
        // DarkGrey
        public static Color DarkGrey = Color.DimGray;
        // Grey
        public static Color Grey = Color.DarkGray;
        // LightGrey
        public static Color LightGrey = Color.LightGray;
        // OffWhite
        public static Color OffWhite = Color.GhostWhite;
        // Yellow
        public static Color Yellow = Color.Goldenrod;
        // Red
        public static Color Red = Color.FromHex("B22222");
        // Green
        public static Color Green = Color.FromHex("2E8B57");

        // LISTS
        public static ObservableCollection<string> AllSkills = new ObservableCollection<string> {
            "Acrobatics", "Animal Handling", "Arcana", "Athletics", "Deception", "History", "Insight", "Intimidation", "Investigation", "Medicine", "Nature", "Perception", "Performance", "Persuasion", "Religion", "Sleight of Hand", "Stealth", "Surival"
        };
        public static ObservableCollection<string> Currency = new ObservableCollection<string>
        {
            "Copper", "Silver", "Electrum", "Gold", "Platinum"
        };
        public static ObservableCollection<string> AllAbility = new ObservableCollection<string>
        {
            "Copper", "Silver", "Electrum", "Gold", "Platinum"
        };
        public static ObservableCollection<string> AllRaces = new ObservableCollection<string>
        {
            "Dragonborn", "Dwarf", "Eladrin", "Elf", "Gnome", "Half-elf", "Half-orc", "Halfling", "Human", "Tiefling"

        };
        public static ObservableCollection<string> AllClasses = new ObservableCollection<string>
        {
            "Barbarian", "Bard", "Cleric", "Druid", "Fighter", "Monk", "Paladin", "Ranger", "Rogue", "Sorcerer", "Warlock", "Wizard"
        };


    }
}
