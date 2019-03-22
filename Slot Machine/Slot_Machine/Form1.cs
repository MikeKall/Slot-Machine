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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void start_game_btn_Click(object sender, EventArgs e)
        {
            if (Options.slotsQuant == 3)
            {
                Game game1 = new Game();
                game1.Show();
            }
            else if (Options.slotsQuant == 4)
            {
                Game2 game2 = new Game2();
                game2.Show();
            }
            else
            {
                Game3 game3 = new Game3();
                game3.Show();
            }
        }

        private void options_btn_Click(object sender, EventArgs e)
        {
            Options form2 = new Options();
            form2.Show();
        }

        private void quit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void credits_btn_Click(object sender, EventArgs e)
        {
            Credits missisipi = new Credits();
            missisipi.Show();
        }
    }
}
