/*
 * TODO: Add CronsNeeded to switch statement
 * TODO: Change Form ItemType ComboBox to match switch Catagories
 * TODO: Add ItemName to combobox based on Catagories
 */



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDO_Enhacement
{
    internal class Item
    {
        public string ItemType { get; private set; }
        public string ItemName { get; private set; }

        public IDictionary<string, int> CronsNeeded { get; private set; }
        public IDictionary<string, int> SoftcapStacks { get; private set; }
        public IDictionary<string, int> HardcapStacks { get; private set; }
        public IDictionary<string, double> BaseRates { get; private set; }


        public Item(string itemType, string itemName)
        {
            //Base: 24, Pri: 74, Duo: 224, Tri: 625, Tet: 2999
            List<string> accessoryCatagory1 = new List<string>()
            {
                "Ring of Crescent Guardian", "Serap's Necklace"
            };

            //Base: 37, Pri: 112, Duo: 337, Tri: 937, Tet: 4499
            List<string> accessoryCatagory2 = new List<string>()
            {
                "Basilisk's Belt", "Eye of the Ruins Ring", "Narc Ear Accessory"
            };

            //Base: 37, Pri: 112, Duo: 412, Tri: 1312, Tet: 4499
            List<string> accessoryCatagory3 = new List<string>()
            {
                "Centaurus Belt"
            };

            //Base: 47, Pri: 142, Duo: 427, Tri: 1187, Tet: 5699
            List<string> accessoryCatagory4 = new List<string>()
            {
                "Orkinrad's Belt", "Valtarra Eclipsed Belt", "Laytenn's Power Stone", "Ogre Ring", "Ethereal Earring", "Tungrad Earring"
            };

            //Base: 62, Pri: 187, Duo: 562, Tri: 1562, Tet: 7499
            List<string> accessoryCatagory5 = new List<string>()
            {
                "Tungrad Belt", "Turo's Belt", "Ominous Ring", "Tungrad ring", "Revived Lunar Necklace", "Revived River Necklace", "Tungrad Necklace", "Black Distortion Earring", "Dawn Earring", "Vaha's Dawn"
            };

            //Base: 18, Pri: 56, Duo: 168, Tri: 468, Tet: 2249
            List<string> accessoryCatagory6 = new List<string>()
            {
                "Forest Ronaros Ring"
            };

            //Base: 24, Pri: 74, Duo: 275, Tri: 874, Tet: 2999
            List<string> accessoryCatagory7 = new List<string>()
            {
                "Ring of Cadry Guardian"
            };

            //Base: 29, Pri: 89, Duo: 269, Tri: 749, Tet: 3600
            List<string> accessoryCatagory8 = new List<string>()
            {
                "Sicil's Necklace"
            };

            //Base: 95, Pri: 288, Duo: 865, Tri: 2405, Tet: 11548
            List<string> accessoryCatagory9 = new List<string>()
            {
                "Deboreka Necklace", "Deboreka Belt"
            };

            //Base: 0, Pri: 0, Duo: 14, Tri: 42, Tet: 175
            List<string> armorCatagory1 = new List<string>()
            {
                "Akum/Lemoria"
            };

            //Base: 0, Pri: 0, Duo: 38, Tri: 114, Tet: 429
            List<string> armorCatagory2 = new List<string>()
            {
                "Red Nose's Armor", "Bheg's/Leebur's Gloves", "Muskan's Shoes", "Giath's Helmet", "Griffon's Helmet"
            };

            //Base: 0, Pri: 0, Duo: 43, Tri: 131, Tet: 493
            List<string> armorCatagory3 = new List<string>()
            {
                "Urugon's Shoes", "Dim Tree Spirit's Armor"
            };

            //Base: 0, Pri: 0, Duo: 190, Tri: 570, Tet: 980
            List<string> armorCatagory4 = new List<string>()
            {
                "Blackstar Gloves", "Blackstar Shoes", "Blackstar Helmet"
            };

            //Base: 0, Pri: 0, Duo: 220, Tri: 680, Tet: 1350
            List<string> armorCatagory5 = new List<string>()
            {
                "Blackstar Armor"
            };

            //Base: 0, Pri: 1500, Duo: 2100, Tri: 2700, Tet: 4000
            List<string> armorCatagory6 = new List<string>()
            {
                "Fallen God's Armor", "Labreska's Helmet"
            };

            //Base: 0, Pri: 0, Duo: 34, Tri: 127, Tet: 531
            List<string> weaponCatagory1 = new List<string>()
            {
                "Kutum/Nouver Sub Weapon", "Dragon Slayer Awakening Weapon", "Kzarka/Offin Tett Main Weapon"
            };

            //Base: 0, Pri: 0, Duo: 40, Tri: 146, Tet: 611
            List<string> weaponCatagory2 = new List<string>()
            {
                "Dandelion/Artina Sol/Tring/Tute"
            };

            //Base: 0, Pri: 0, Duo: 620, Tri: 980, Tet: 1820
            List<string> weaponCatagory3 = new List<string>()
            {
                "Godr-Ayed Weapon"
            };

            //Base: 0, Pri: 0, Duo: 100, Tri: 591, Tet: 3670
            List<string> weaponCatagory4 = new List<string>()
            {
                "Blackstar Weapon"
            };


            ItemType = itemType;
            ItemName = itemName;

            switch(itemType)
            {
                case "Accessory (Green, Blue, Yellow)":
                    BaseRates = new Dictionary<string, double>()
                    {
                        {"Pri", 25},
                        {"Duo", 10},
                        {"Tri", 7.5},
                        {"Tet", 2.5},
                        {"Pen", 0.5}
                    };
                    SoftcapStacks = new Dictionary<string, int>()
                    {
                        {"Pri", 18},
                        {"Duo", 40},
                        {"Tri", 44},
                        {"Tet", 110},
                        {"Pen", 390}
                    };
                    HardcapStacks = new Dictionary<string, int>()
                    {
                        {"Pri", 58},
                        {"Duo", 240},
                        {"Tri", 374},
                        {"Tet", 1310},
                        {"Pen", 7390}
                    };
                    break;
                case "Weapon (Blue, Yellow)":
                    BaseRates = new Dictionary<string, double>()
                    {
                        {"Pri", 11.76},
                        {"Duo", 7.69},
                        {"Tri", 6.25},
                        {"Tet", 2},
                        {"Pen", 0.30}
                    };
                    SoftcapStacks = new Dictionary<string, int>()
                    {
                        {"Pri", 50},
                        {"Duo", 82},
                        {"Tri", 102},
                        {"Tet", 340},
                        {"Pen", 2324}
                    };
                    HardcapStacks = new Dictionary<string, int>()
                    {
                        {"Pri", 133},
                        {"Duo", 208},
                        {"Tri", 262},
                        {"Tet", 840},
                        {"Pen", 5654}
                    };
                    break;
                case "Weapon (Blackstar)":
                    BaseRates = new Dictionary<string, double>()
                    {
                        {"Pri", 13.08},
                        {"Duo", 10.63},
                        {"Tri", 3.4},
                        {"Tet", 0.51},
                        {"Pen", 0.20}
                    };
                    SoftcapStacks = new Dictionary<string, int>()
                    {
                        {"Pri", 44},
                        {"Duo", 56},
                        {"Tri", 196},
                        {"Tet", 1363},
                        {"Pen", 3490}
                    };
                    HardcapStacks = new Dictionary<string, int>()
                    {
                        {"Pri", 119},
                        {"Duo", 150},
                        {"Tri", 490},
                        {"Tet", 3322},
                        {"Pen", 8489}
                    };
                    break;
                case "Weapon (Godr-Ayed)":
                    BaseRates = new Dictionary<string, double>()
                    {
                        {"Pri", 0.9},
                        {"Duo", 0.5},
                        {"Tri", 0.38},
                        {"Tet", 0.25},
                        {"Pen", 0.15}
                    };
                    SoftcapStacks = new Dictionary<string, int>()
                    {
                        {"Pri", 500},
                        {"Duo", 900},
                        {"Tri", 1200},
                        {"Tet", 1363},
                        {"Pen", 3490}
                    };
                    HardcapStacks = new Dictionary<string, int>()
                    {
                        {"Pri", 2950},
                        {"Duo", 5350},
                        {"Tri", 7150},
                        {"Tet", 12497},
                        {"Pen", 15989}
                    };
                    break;
                case "Armor (Blue, Yellow)":
                    BaseRates = new Dictionary<string, double>()
                    {
                        {"Pri", 11.76},
                        {"Duo", 7.69},
                        {"Tri", 6.25},
                        {"Tet", 2},
                        {"Pen", 0.30}
                    };
                    SoftcapStacks = new Dictionary<string, int>()
                    {
                        {"Pri", 50},
                        {"Duo", 82},
                        {"Tri", 102},
                        {"Tet", 340},
                        {"Pen", 2324}
                    };
                    HardcapStacks = new Dictionary<string, int>()
                    {
                        {"Pri", 133},
                        {"Duo", 208},
                        {"Tri", 262},
                        {"Tet", 840},
                        {"Pen", 5654}
                    };
                    break;
                case "Armor (Blackstar)":
                    BaseRates = new Dictionary<string, double>()
                    {
                        {"Pri", 13.08},
                        {"Duo", 10.63},
                        {"Tri", 3.4},
                        {"Tet", 0.51},
                        {"Pen", 0.20}
                    };
                    SoftcapStacks = new Dictionary<string, int>()
                    {
                        {"Pri", 44},
                        {"Duo", 56},
                        {"Tri", 196},
                        {"Tet", 1363},
                        {"Pen", 3490}
                    };
                    HardcapStacks = new Dictionary<string, int>()
                    {
                        {"Pri", 119},
                        {"Duo", 150},
                        {"Tri", 490},
                        {"Tet", 3322},
                        {"Pen", 8489}
                    };
                    break;
                case "Armor (Fallen God's)":
                    BaseRates = new Dictionary<string, double>()
                    {
                        {"Pri", 2},
                        {"Duo", 1},
                        {"Tri", 0.5},
                        {"Tet", 0.2},
                        {"Pen", 0.00}
                    };
                    SoftcapStacks = new Dictionary<string, int>()
                    {
                        {"Pri", 340},
                        {"Duo", 690},
                        {"Tri", 1390},
                        {"Tet", 3490},
                        {"Pen", 279990}
                    };
                    HardcapStacks = new Dictionary<string, int>()
                    {
                        {"Pri", 840},
                        {"Duo", 1690},
                        {"Tri", 3390},
                        {"Tet", 8489},
                        {"Pen", 679890}
                    };
                    break;
            }
        }
    }
}
