using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDO_Enhacement
{
    public partial class EnhancementCalculatorMainForm : Form
    {
        public EnhancementCalculatorMainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Exit?", "Exit Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if(result == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void cmbItemType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbItemName.Items.Clear();
            cmbItemName.ResetText();

            //nothing selected
            if (cmbItemType.SelectedIndex == -1)
            {
                cmbItemName.Enabled = false;
            }
            //Accessory (Green, Blue, Yellow)
            else if (cmbItemType.SelectedIndex == 0)
            {
                List<string> yellowGradeItems = new List<string>()
                {
                    "Basilisk's Belt", "Black Distortion Earring", "Centaurus Belt", "Dawn Earring", "Deboreka Belt", "Deboreka Necklace", "Ethereal Earring", 
                    "Eye of the Ruins Ring", "Forest Ronaros Ring", "Laytenn's Power Stone", "Narc Ear Accessory", "Ogre Ring", "Ominous Ring", "Orkinrad's Belt", 
                    "Revived Lunar Necklace", "Revived River Necklace", "Ring of Cadry Guardian", "Ring of Crescent Guardian", "Serap's Necklace", 
                    "Sicil's Necklace", "Tungrad Belt", "Tungrad Earring", "Tungrad Necklace", "Tungrad Ring", "Turo's Belt", "Valtarra Eclipsed Belt", "Vaha's Dawn"
                };

                /* TODO: add blue and green grade (green should all be the same)
                List<string> blueGradeItems = new List<string>()
                {

                };
                */
                foreach (string item in yellowGradeItems)
                {
                    cmbItemName.Items.Add(item);
                }
                

                cmbItemName.Enabled = true;
            }
            //Weapon(Green)
            //TODO: Add green grade items (also needs to be added to Item.cs)
            else if (cmbItemType.SelectedIndex == 1)
            {
                List<string> newItems = new List<string>()
                {
                    "",
                };

                foreach (string item in newItems)
                {
                    cmbItemName.Items.Add(item);
                }
                cmbItemName.Enabled = true;
            }
            //Weapon (Blue, Yellow)
            else if (cmbItemType.SelectedIndex == 2)
            {
                List<string> yellowItems = new List<string>()
                {
                    "Kutum/Nouver Sub Weapon", "Dragon Slayer Awakening Weapon", "Kzarka/Offin Tett Main Weapon", "Dandelion/Artina Sol/Tring/Tute"
                };

                foreach (string item in yellowItems)
                {
                    cmbItemName.Items.Add(item);
                }
                cmbItemName.Enabled = true;
            }
            //Weapon (Blackstar)
            else if (cmbItemType.SelectedIndex == 3)
            {

                cmbItemName.Items.Add("Blackstar Weapon");
                cmbItemName.Items.Add("Godr-Ayed Weapon");

                cmbItemName.Enabled = true;
            }
            //Armor (Green)
            else if (cmbItemType.SelectedIndex == 4)
            {
                List<string> newItems = new List<string>()
                {
                    "",
                };

                foreach (string item in newItems)
                {
                    cmbItemName.Items.Add(item);
                }
                cmbItemName.Enabled = true;
            }
            //Armor (Blue, Yellow)
            else if (cmbItemType.SelectedIndex == 5)
            {
                List<string> yellowItems = new List<string>()
                {
                    "Red Nose's Armor", "Bheg's/Leebur's Gloves", "Muskan's Shoes", "Giath's Helmet", "Griffon's Helmet",
                    "Urugon's Shoes", "Dim Tree Spirit's Armor"
                };


                //add blue grade
                cmbItemName.Items.Add("Akum/Lemoria");
                //add yellow grade
                foreach (string item in yellowItems)
                {
                    cmbItemName.Items.Add(item);
                }
                cmbItemName.Enabled = true;
            }
            //Armor (Blackstar)
            else if (cmbItemType.SelectedIndex == 6)
            {
                List<string> newItems = new List<string>()
                {
                    "Blackstar Gloves", "Blackstar Shoes", "Blackstar Helmet", "Blackstar Armor"
                };

                foreach (string item in newItems)
                {
                    cmbItemName.Items.Add(item);
                }
                cmbItemName.Enabled = true;
            }
            //Armor (Fallen God's)
            else if (cmbItemType.SelectedIndex == 7)
            {
                List<string> newItems = new List<string>()
                {
                    "Fallen God's Armor", "Labreska's Helmet"
                };

                foreach (string item in newItems)
                {
                    cmbItemName.Items.Add(item);
                }
                cmbItemName.Enabled = true;
            }
        }

        private void cmbItemName_SelectedIndexChanged(object sender, EventArgs e)
        {
            Item item = new Item(cmbItemType.Text, cmbItemName.Text);

            lblPriSoftcapStack.Text = $"({item.SoftcapStacks["Pri"].ToString()})";
            lblDuoSoftcapStack.Text = $"({item.SoftcapStacks["Duo"].ToString()})";
            lblTriSoftcapStack.Text = $"({item.SoftcapStacks["Tri"].ToString()})";
            lblTetSoftcapStack.Text = $"({item.SoftcapStacks["Tet"].ToString()})";
            lblPenSoftcapStack.Text = $"({item.SoftcapStacks["Pen"].ToString()})";

            lblPriCronsNeeded.Text = $"({item.CronsNeeded["Base"]})";
            lblDuoCronsNeeded.Text = $"({item.CronsNeeded["Pri"]})";
            lblTriCronsNeeded.Text = $"({item.CronsNeeded["Duo"]})";
            lblTetCronsNeeded.Text = $"({item.CronsNeeded["Tri"]})";
            lblPenCronsNeeded.Text = $"({item.CronsNeeded["Tet"]})";
        }
    }
}
