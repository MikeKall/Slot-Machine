using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slot_Machine
{
    public partial class Options : Form
    {
        public static int fruitsQuant = 4;
        public static int slotsQuant = 3;

        public Options()
        {
            InitializeComponent();
            FruitQuantityLabel.Text = fruitsQuant.ToString();
            SlotsQuantityLabel.Text = slotsQuant.ToString();
            MachineReview();
        }

        

        private void Save_btn_Click(object sender, EventArgs e)
        {
            this.Close();           
        }

        private void opt_plus_btn_items_Click(object sender, EventArgs e)
        {
            if (fruitsQuant < 6)
            {
                fruitsQuant++;
                FruitQuantityLabel.Text = fruitsQuant.ToString();
            }          
        }

        private void opt_minus_btn_items_Click(object sender, EventArgs e)
        {
            if (fruitsQuant > 3)
            {
                fruitsQuant--;
                FruitQuantityLabel.Text = fruitsQuant.ToString();
            }
        }

        private void opt_minus_btn_slots_Click(object sender, EventArgs e)
        {
            if (slotsQuant > 3)
            {
                slotsQuant--;
                SlotsQuantityLabel.Text = slotsQuant.ToString();
            }
            MachineReview();
        }

        private void opt_plus_btn_slots_Click(object sender, EventArgs e)
        {
            if (slotsQuant < 5)
            {
                slotsQuant++;
                SlotsQuantityLabel.Text = slotsQuant.ToString();
            }
            MachineReview();
        }

        private void MachineReview()
        {
            if (slotsQuant == 3)
            {
                MachineReviewBox.Image = Properties.Resources.Machine1Review;
            }
            else if (slotsQuant == 4)
            {
                MachineReviewBox.Image = Properties.Resources.Machine2Review;
            }
            else
            {
                MachineReviewBox.Image = Properties.Resources.Machine3Review;
            }
        }
    }
}
