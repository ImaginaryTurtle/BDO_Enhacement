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
            //nothing selected
            if (cmbItemType.SelectedIndex == -1)
            {
                cmbItemName.Items.Clear();
                cmbItemName.Enabled = false;
            }
            //Accessory (Green, Blue, Yellow)
            else if (cmbItemType.SelectedIndex == 0)
            {
                List<string> newItems = new List<string>()
                {
                    "",
                };

                cmbItemName.Items.Clear();
                foreach (string item in newItems)
                {
                    cmbItemName.Items.Add(item);
                }
                cmbItemName.Enabled = true;
            }
            //Weapon(Green)
            else if (cmbItemType.SelectedIndex == 1)
            {
                List<string> newItems = new List<string>()
                {
                    "",
                };

                cmbItemName.Items.Clear();
                foreach (string item in newItems)
                {
                    cmbItemName.Items.Add(item);
                }
                cmbItemName.Enabled = true;
            }
            //Weapon (Blue, Yellow)
            else if (cmbItemType.SelectedIndex == 2)
            {
                List<string> newItems = new List<string>()
                {
                    "",
                };

                cmbItemName.Items.Clear();
                foreach (string item in newItems)
                {
                    cmbItemName.Items.Add(item);
                }
                cmbItemName.Enabled = true;
            }
            //Weapon (Blackstar)
            else if (cmbItemType.SelectedIndex == 3)
            {
                List<string> newItems = new List<string>()
                {
                    "",
                };

                cmbItemName.Items.Clear();
                foreach (string item in newItems)
                {
                    cmbItemName.Items.Add(item);
                }
                cmbItemName.Enabled = true;
            }
            //Armor (Green)
            else if (cmbItemType.SelectedIndex == 4)
            {
                List<string> newItems = new List<string>()
                {
                    "",
                };

                cmbItemName.Items.Clear();
                foreach (string item in newItems)
                {
                    cmbItemName.Items.Add(item);
                }
                cmbItemName.Enabled = true;
            }
            //Armor (Blue, Yellow)
            else if (cmbItemType.SelectedIndex == 5)
            {
                List<string> newItems = new List<string>()
                {
                    "",
                };

                cmbItemName.Items.Clear();
                foreach (string item in newItems)
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
                    "",
                };

                cmbItemName.Items.Clear();
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
                    "",
                };

                cmbItemName.Items.Clear();
                foreach (string item in newItems)
                {
                    cmbItemName.Items.Add(item);
                }
                cmbItemName.Enabled = true;
            }
        }
    }
}
