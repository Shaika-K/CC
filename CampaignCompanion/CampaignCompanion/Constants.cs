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
            "Strength", "Dexterity", "Constitution", "Intelligence", "Wisdom", "Charisma"
        };

        public static ObservableCollection<string> AllCharacteristics = new ObservableCollection<string>
        {
            "Hit Dice", "Hit Points", "Initiative", "Speed", "ArmourClass"
        };

        public static ObservableCollection<string> AllBuffs = new ObservableCollection<string>
        {
            "ProficiencyBonus", "Passive Wisdom", "Inspiration"
        };

        public static ObservableCollection<string> AllSavingThrows = new ObservableCollection<string>
        {
            "Strength", "Dexterity", "Constitution", "Intelligence", "Wisdom", "Charisma"
        };

        public static ObservableCollection<string> AllRaces = new ObservableCollection<string>
        {
            "Dragonborn", "Dwarf", "Eladrin", "Elf", "Gnome", "Half-Elf", "Half-Orc", "Halfling", "Human", "Tiefling"

        };
        public static ObservableCollection<string> AllClasses = new ObservableCollection<string>
        {
            "Barbarian", "Bard", "Cleric", "Druid", "Fighter", "Monk", "Paladin", "Ranger", "Rogue", "Sorcerer", "Warlock", "Wizard"
        };

        public static Character DummyCharacter = new Character
        {
            FirstName = "Helga",
            LastName = "Thunder-Thighs",
            Level = 1,
            Age = new Random().Next(0, 5),
            Race = "Half-Orc",
            Class = "Barbarian",
            Background = "I came a shore on a ship where the rest of the crew died during a pirate raid. I sailed accross the ocean using only my thinghs and the claps of my... er nevermind.\nIm pretty, short, hella stronk though not super smart...\n",
            Stats = InitializeStats(),
            Spells = new ObservableCollection<Spell>(),
            Skills = InitializeSkills(),
            Possesions = new ObservableCollection<Entity>(),
            Money = InitializeMoney()
        };

        public static Character DummyCharacter2 = new Character
        {
            FirstName = "Harold",
            LastName = "Ballitch",
            Level = 3,
            Age = new Random().Next(0, 5),
            Race = "Half-Elf",
            Class = "Cleric",
            Background = "I am a Cleric of the god of chastity, Stifle. Stifle's main thing is chastity for everyone. So I have a ceremonial knife for castrating any man I find, wherever possible ;)",
            Stats = InitializeStats(),
            Spells = new ObservableCollection<Spell>(),
            Skills = InitializeSkills(),
            Possesions = new ObservableCollection<Entity> {
                new Entity { Name = "Knife", Quantity = 1 }, new Entity{ Name = "Mace", Quantity = 1}
            },
            Money = InitializeMoney()
        };

        public static User DummyUser = new User
        {
            ID = 0,
            Username = "Dummy Player 1",
            Email = "player1@dnd.com",
            Password = "123",
            Campaigns = new Dictionary<Campaign, Character>()
        };


        public static User DummyUser2 = new User
        {
            ID = 0,
            Username = "Dummy Player 2",
            Email = "player2@dnd.com",
            Password = "123",
            Campaigns = new Dictionary<Campaign, Character>()
        };

        public static User TheDM = new User
        {
            ID = 0,
            Username = "Dungeon Master",
            Email = "thedm@dnd.com",
            Password = "123",
            Campaigns = new Dictionary<Campaign, Character>()
        };

        public static Campaign DummyCampaign = new Campaign
        {
            ID = 0,
            Name = "Default Campaign",
            DungeonMaster = new User(),
            Group = new Dictionary<User, Character>()
        };

        private static ObservableCollection<Skill> InitializeSkills()
        {
            ObservableCollection<Skill> skills = new ObservableCollection<Skill>();
            foreach (string skill in AllSkills)
            {
                skills.Add(new Skill
                {
                    Name = skill,
                    IsProficient = false,
                    Ammount = new Random().Next(5, 20)
                });
            }
            return skills;
        }

        private static Stat InitializeStats()
        {
            Stat stats = new Stat
            {
                AllAbility = new ObservableCollection<Entity>(),
                AllCharacteristics = new ObservableCollection<Entity>(),
                AllBuffs = new ObservableCollection<Entity>(),
                AllSavingThrows = new ObservableCollection<Entity>()
            };

            stats.AllAbility = new ObservableCollection<Entity>();
            foreach (string stat in AllAbility)
            {
                stats.AllAbility.Add(new Entity { Name = stat, Quantity = new Random().Next(0, 5) });
            }

            stats.AllCharacteristics = new ObservableCollection<Entity>();
            foreach (string stat in AllCharacteristics)
            {
                stats.AllCharacteristics.Add(new Entity { Name = stat, Quantity = new Random().Next(0, 5) });
            }

            stats.AllBuffs = new ObservableCollection<Entity>();
            foreach (string stat in AllBuffs)
            {
                stats.AllBuffs.Add(new Entity { Name = stat, Quantity = new Random().Next(0, 5) });
            }

            stats.AllSavingThrows = new ObservableCollection<Entity>();
            foreach (string stat in AllSavingThrows)
            {
                stats.AllSavingThrows.Add(new Entity { Name = stat, Quantity = new Random().Next(0, 5) });
            }

            return stats;
        }

        private static ObservableCollection<Entity> InitializeMoney()
        {
            ObservableCollection<Entity> money = new ObservableCollection<Entity>();
            foreach (string coin in Currency)
            {
                money.Add(new Entity {Name = coin, Quantity = new Random().Next(0, 5)});
            }
            return money;
        }
    }
}
