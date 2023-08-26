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

            switch (itemName)
            {
                //Base: 24, Pri: 74, Duo: 224, Tri: 625, Tet: 2999
                case "Ring of Crescent Guardian":
                case "Serap's Necklace":
                    CronsNeeded = new Dictionary<string, int>
                    {
                        {"Base", 24},
                        {"Pri", 74},
                        {"Duo", 224},
                        {"Tri", 625},
                        {"Tet", 2999}
                    };
                    break;

                //Base: 37, Pri: 112, Duo: 337, Tri: 937, Tet: 4499
                case "Basilisk's Belt":
                case "Eye of the Ruins Ring":
                case "Narc Ear Accessory":
                    CronsNeeded = new Dictionary<string, int>
                    {
                        {"Base", 37},
                        {"Pri", 112},
                        {"Duo", 337},
                        {"Tri", 937},
                        {"Tet", 4499}
                    };
                    break;

                //Base: 37, Pri: 112, Duo: 412, Tri: 1312, Tet: 4499
                case "Centaurus Belt":
                    CronsNeeded = new Dictionary<string, int>
                    {
                        {"Base", 37},
                        {"Pri", 112},
                        {"Duo", 412},
                        {"Tri", 1312},
                        {"Tet", 4499}
                    };
                    break;

                //Base: 47, Pri: 142, Duo: 427, Tri: 1187, Tet: 5699
                case "Orkinrad's Belt":
                case "Valtarra Eclipsed Belt":
                case "Laytenn's Power Stone":
                case "Ogre Ring":
                case "Ethereal Earring":
                case "Tungrad Earring":
                    CronsNeeded = new Dictionary<string, int>
                    {
                        {"Base", 47},
                        {"Pri", 142},
                        {"Duo", 427},
                        {"Tri", 1187},
                        {"Tet", 5699}
                    };
                    break;

                //Base: 62, Pri: 187, Duo: 562, Tri: 1562, Tet: 7499
                case "Tungrad Belt":
                case "Turo's Belt":
                case "Ominous Ring":
                case "Tungrad ring":
                case "Revived Lunar Necklace":
                case "Revived River Necklace":
                case "Tungrad Necklace":
                case "Black Distortion Earring":
                case "Dawn Earring":
                case "Vaha's Dawn":
                    CronsNeeded = new Dictionary<string, int>
                    {
                        {"Base", 62},
                        {"Pri", 187},
                        {"Duo", 562},
                        {"Tri", 1562},
                        {"Tet", 7499}
                    };
                    break;

                //Base: 18, Pri: 56, Duo: 168, Tri: 468, Tet: 2249
                case "Forest Ronaros Ring":
                    CronsNeeded = new Dictionary<string, int>
                    {
                        {"Base", 18},
                        {"Pri", 56},
                        {"Duo", 168},
                        {"Tri", 468},
                        {"Tet", 2249}
                    };
                    break;

                //Base: 24, Pri: 74, Duo: 275, Tri: 874, Tet: 2999
                case "Ring of Cadry Guardian":
                    CronsNeeded = new Dictionary<string, int>
                    {
                        {"Base", 24},
                        {"Pri", 74},
                        {"Duo", 275},
                        {"Tri", 874},
                        {"Tet", 2999}
                    };
                    break;

                //Base: 29, Pri: 89, Duo: 269, Tri: 749, Tet: 3600
                case "Sicil's Necklace":
                    CronsNeeded = new Dictionary<string, int>
                    {
                        {"Base", 29},
                        {"Pri", 89},
                        {"Duo", 269},
                        {"Tri", 749},
                        {"Tet", 3600}
                    };
                    break;

                //Base: 95, Pri: 288, Duo: 865, Tri: 2405, Tet: 11548
                case "Deboreka Necklace":
                case "Deboreka Belt":
                    CronsNeeded = new Dictionary<string, int>
                    {
                        {"Base", 95},
                        {"Pri", 288},
                        {"Duo", 865},
                        {"Tri", 2405},
                        {"Tet", 11548}
                    };
                    break;

                //Base: 0, Pri: 0, Duo: 14, Tri: 42, Tet: 175
                case "Akum/Lemoria":
                    CronsNeeded = new Dictionary<string, int>
                    {
                        {"Base", 0},
                        {"Pri", 0},
                        {"Duo", 14},
                        {"Tri", 42},
                        {"Tet", 175}
                    };
                    break;

                //Base: 0, Pri: 0, Duo: 38, Tri: 114, Tet: 429
                case "Red Nose's Armor":
                case "Bheg's/Leebur's Gloves":
                case "Muskan's Shoes":
                case "Giath's Helmet":
                case "Griffon's Helmet":
                    CronsNeeded = new Dictionary<string, int>
                    {
                        {"Base", 0},
                        {"Pri", 0},
                        {"Duo", 38},
                        {"Tri", 114},
                        {"Tet", 429}
                    };
                    break;

                //Base: 0, Pri: 0, Duo: 43, Tri: 131, Tet: 493
                case "Urugon's Shoes":
                case "Dim Tree Spirit's Armor":
                    CronsNeeded = new Dictionary<string, int>
                    {
                        {"Base", 0},
                        {"Pri", 0},
                        {"Duo", 43},
                        {"Tri", 131},
                        {"Tet", 493}
                    };
                    break;

                //Base: 0, Pri: 0, Duo: 190, Tri: 570, Tet: 980
                case "Blackstar Gloves":
                case "Blackstar Shoes":
                case "Blackstar Helmet":
                    CronsNeeded = new Dictionary<string, int>
                    {
                        {"Base", 0},
                        {"Pri", 0},
                        {"Duo", 190},
                        {"Tri", 570},
                        {"Tet", 980}
                    };
                    break;

                //Base: 0, Pri: 0, Duo: 220, Tri: 680, Tet: 1350
                case "Blackstar Armor":
                    CronsNeeded = new Dictionary<string, int>
                    {
                        {"Base", 0},
                        {"Pri", 0},
                        {"Duo", 220},
                        {"Tri", 680},
                        {"Tet", 1350}
                    };
                    break;

                //Base: 0, Pri: 1500, Duo: 2100, Tri: 2700, Tet: 4000
                case "Fallen God's Armor":
                case "Labreska's Helmet":
                    CronsNeeded = new Dictionary<string, int>
                    {
                        {"Base", 0},
                        {"Pri", 1500},
                        {"Duo", 2100},
                        {"Tri", 2700},
                        {"Tet", 4000}
                    };
                    break;

                //Base: 0, Pri: 0, Duo: 34, Tri: 127, Tet: 531
                case "Kutum/Nouver Sub Weapon":
                case "Dragon Slayer Awakening Weapon":
                case "Kzarka/Offin Tett Main Weapon":
                    CronsNeeded = new Dictionary<string, int>
                    {
                        {"Base", 0},
                        {"Pri", 0},
                        {"Duo", 34},
                        {"Tri", 127},
                        {"Tet", 531}
                    };
                    break;

                //Base: 0, Pri: 0, Duo: 40, Tri: 146, Tet: 611
                case "Dandelion/Artina Sol/Tring/Tute":
                    CronsNeeded = new Dictionary<string, int>
                    {
                        {"Base", 0},
                        {"Pri", 0},
                        {"Duo", 40},
                        {"Tri", 146},
                        {"Tet", 611}
                    };
                    break;

                //Base: 0, Pri: 0, Duo: 620, Tri: 980, Tet: 1820
                case "Godr-Ayed Weapon":
                    CronsNeeded = new Dictionary<string, int>
                    {
                        {"Base", 0},
                        {"Pri", 0},
                        {"Duo", 620},
                        {"Tri", 980},
                        {"Tet", 1820}
                    };
                    break;

                //Base: 0, Pri: 0, Duo: 100, Tri: 591, Tet: 3670
                case "Blackstar Weapon":
                    CronsNeeded = new Dictionary<string, int>
                    {
                        {"Base", 0},
                        {"Pri", 0},
                        {"Duo", 100},
                        {"Tri", 591},
                        {"Tet", 3670}
                    };
                    break;
            }
        }
    }
}