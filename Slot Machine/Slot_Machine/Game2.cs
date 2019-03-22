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
    public partial class Game2 : Form
    {
        int ImageSelect;
        int CycleCounter = 0;
        int SpinCounter = 0;
        int Wallet = 5000;
        int Bet = 0;

        //Μεταβλητες(Tags) για την συγκριση των εικόνων
        int image1;
        int image2;
        int image3;
        int image4;

        public Game2()
        {
            InitializeComponent();
            Walletbox.Text = Wallet.ToString();
            BetBox.Text = Bet.ToString();
        }

        private void spin_btn_Click(object sender, EventArgs e)
        {
            SpinTimer.Interval = 2000;
            SpinTimer.Start();

            ImageCycleTimer.Start();
            ImageCycleTimer.Interval = 150;

            image1 = -1;
            image2 = -2;
            image3 = -1;
            image4 = -2;

            GifFruit1.Visible = true;
            GifFruit2.Visible = true;
            GifFruit3.Visible = true;
            GifFruit4.Visible = true;
            JackpotPicBox.Visible = false;

            spin_btn.Enabled = false;
            plusBet_btn.Enabled = false;
            minusBet_btn.Enabled = false;
            AllIn_btn.Enabled = false;

        }

        private void SpinTimer_Tick(object sender, EventArgs e)
        {
            if (SpinCounter == 0)
            {
                GifFruit1.Visible = false;
                RandomImageSelection(Options.fruitsQuant, 1);

            }
            else if (SpinCounter == 1)
            {
                GifFruit2.Visible = false;
                RandomImageSelection(Options.fruitsQuant, 2);
            }
            else if (SpinCounter == 2)
            {
                GifFruit3.Visible = false;
                RandomImageSelection(Options.fruitsQuant, 3);
            }
            else if (SpinCounter == 3)
            {
                GifFruit4.Visible = false;
                RandomImageSelection(Options.fruitsQuant, 4);
            }
            SpinCounter++;

            if (SpinCounter == 4)
            {
                SpinTimer.Stop();
                ImageCycleTimer.Stop();
                SpinCounter = 0;
                ImageCycleTimer.Stop();
                spin_btn.Enabled = true;
                plusBet_btn.Enabled = true;
                minusBet_btn.Enabled = true;
                AllIn_btn.Enabled = true;
                Win_Check();
                Credits_check();
            }
        }

        private void ImageCycleTimer_Tick(object sender, EventArgs e)
        {
            if (Options.fruitsQuant == 3)
            {
                if (CycleCounter == 0)
                {
                    GifFruit1.Image = Properties.Resources.Watermelon;
                    GifFruit2.Image = Properties.Resources.Watermelon;
                    GifFruit3.Image = Properties.Resources.Watermelon;
                    GifFruit4.Image = Properties.Resources.Watermelon;
                    CycleCounter++;
                }
                else if (CycleCounter == 1)
                {
                    GifFruit1.Image = Properties.Resources.Cherries;
                    GifFruit2.Image = Properties.Resources.Cherries;
                    GifFruit3.Image = Properties.Resources.Cherries;
                    GifFruit4.Image = Properties.Resources.Cherries;
                    CycleCounter++;
                }
                else
                {
                    GifFruit1.Image = Properties.Resources.Lemons;
                    GifFruit2.Image = Properties.Resources.Lemons;
                    GifFruit3.Image = Properties.Resources.Lemons;
                    GifFruit4.Image = Properties.Resources.Lemons;
                    CycleCounter = 0;
                }
            }
            else if (Options.fruitsQuant == 4)
            {
                if (CycleCounter == 0)
                {
                    GifFruit1.Image = Properties.Resources.Watermelon;
                    GifFruit2.Image = Properties.Resources.Watermelon;
                    GifFruit3.Image = Properties.Resources.Watermelon;
                    GifFruit4.Image = Properties.Resources.Watermelon;
                    CycleCounter++;
                }
                else if (CycleCounter == 1)
                {
                    GifFruit1.Image = Properties.Resources.Cherries;
                    GifFruit2.Image = Properties.Resources.Cherries;
                    GifFruit3.Image = Properties.Resources.Cherries;
                    GifFruit4.Image = Properties.Resources.Cherries;
                    CycleCounter++;
                }
                else if (CycleCounter == 2)
                {
                    GifFruit1.Image = Properties.Resources.Lemons;
                    GifFruit2.Image = Properties.Resources.Lemons;
                    GifFruit3.Image = Properties.Resources.Lemons;
                    GifFruit4.Image = Properties.Resources.Lemons;
                    CycleCounter++;
                }
                else
                {
                    GifFruit1.Image = Properties.Resources.Grapes;
                    GifFruit2.Image = Properties.Resources.Grapes;
                    GifFruit3.Image = Properties.Resources.Grapes;
                    GifFruit4.Image = Properties.Resources.Grapes;
                    CycleCounter = 0;
                }
            }
            else if (Options.fruitsQuant == 5)
            {
                if (CycleCounter == 0)
                {
                    GifFruit1.Image = Properties.Resources.Watermelon;
                    GifFruit2.Image = Properties.Resources.Watermelon;
                    GifFruit3.Image = Properties.Resources.Watermelon;
                    GifFruit4.Image = Properties.Resources.Watermelon;
                    CycleCounter++;
                }
                else if (CycleCounter == 1)
                {
                    GifFruit1.Image = Properties.Resources.Cherries;
                    GifFruit2.Image = Properties.Resources.Cherries;
                    GifFruit3.Image = Properties.Resources.Cherries;
                    GifFruit4.Image = Properties.Resources.Cherries;
                    CycleCounter++;
                }
                else if (CycleCounter == 2)
                {
                    GifFruit1.Image = Properties.Resources.Lemons;
                    GifFruit2.Image = Properties.Resources.Lemons;
                    GifFruit3.Image = Properties.Resources.Lemons;
                    GifFruit4.Image = Properties.Resources.Lemons;
                    CycleCounter++;
                }
                else if (CycleCounter == 3)
                {
                    GifFruit1.Image = Properties.Resources.Grapes;
                    GifFruit2.Image = Properties.Resources.Grapes;
                    GifFruit3.Image = Properties.Resources.Grapes;
                    GifFruit4.Image = Properties.Resources.Grapes;
                    CycleCounter++;
                }
                else
                {
                    GifFruit1.Image = Properties.Resources.Orange;
                    GifFruit2.Image = Properties.Resources.Orange;
                    GifFruit3.Image = Properties.Resources.Orange;
                    GifFruit4.Image = Properties.Resources.Orange;
                    CycleCounter = 0;
                }
            }
            else
            {
                if (CycleCounter == 0)
                {
                    GifFruit1.Image = Properties.Resources.Watermelon;
                    GifFruit2.Image = Properties.Resources.Watermelon;
                    GifFruit3.Image = Properties.Resources.Watermelon;
                    GifFruit4.Image = Properties.Resources.Watermelon;
                    CycleCounter++;
                }
                else if (CycleCounter == 1)
                {
                    GifFruit1.Image = Properties.Resources.Cherries;
                    GifFruit2.Image = Properties.Resources.Cherries;
                    GifFruit3.Image = Properties.Resources.Cherries;
                    GifFruit4.Image = Properties.Resources.Cherries;
                    CycleCounter++;
                }
                else if (CycleCounter == 2)
                {
                    GifFruit1.Image = Properties.Resources.Lemons;
                    GifFruit2.Image = Properties.Resources.Lemons;
                    GifFruit3.Image = Properties.Resources.Lemons;
                    GifFruit4.Image = Properties.Resources.Lemons;
                    CycleCounter++;
                }
                else if (CycleCounter == 3)
                {
                    GifFruit1.Image = Properties.Resources.Grapes;
                    GifFruit2.Image = Properties.Resources.Grapes;
                    GifFruit3.Image = Properties.Resources.Grapes;
                    GifFruit4.Image = Properties.Resources.Grapes;
                    CycleCounter++;
                }
                else if (CycleCounter == 4)
                {
                    GifFruit1.Image = Properties.Resources.Orange;
                    GifFruit2.Image = Properties.Resources.Orange;
                    GifFruit3.Image = Properties.Resources.Orange;
                    GifFruit4.Image = Properties.Resources.Orange;
                    CycleCounter++;
                }
                else
                {
                    GifFruit1.Image = Properties.Resources.Seven;
                    GifFruit2.Image = Properties.Resources.Seven;
                    GifFruit3.Image = Properties.Resources.Seven;
                    GifFruit4.Image = Properties.Resources.Seven;
                    CycleCounter = 0;
                }
            }
        }

        private void RandomImageSelection(int fruits, int slot)
        {
            Random rdm = new Random();

            if (fruits == 3)
            {
                if (slot == 1)
                {
                    ImageSelect = rdm.Next(0, 2);

                    if (ImageSelect == 0)
                    {
                        Fruit1.Image = Properties.Resources.Cherries;
                        image1 = 0;
                    }
                    else if (ImageSelect == 1)
                    {
                        Fruit1.Image = Properties.Resources.Lemons;
                        image1 = 1;
                    }
                    else if (ImageSelect == 2)
                    {
                        Fruit1.Image = Properties.Resources.Watermelon;
                        image1 = 2;
                    }
                }
                else if (slot == 2)
                {
                    ImageSelect = rdm.Next(0, 2);

                    if (ImageSelect == 0)
                    {
                        Fruit2.Image = Properties.Resources.Cherries;
                        image2 = 0;
                    }
                    else if (ImageSelect == 1)
                    {
                        Fruit2.Image = Properties.Resources.Lemons;
                        image2 = 1;
                    }
                    else if (ImageSelect == 2)
                    {
                        Fruit2.Image = Properties.Resources.Watermelon;
                        image2 = 2;
                    }
                }
                else if (slot == 3)
                {
                    ImageSelect = rdm.Next(0, 2);

                    if (ImageSelect == 0)
                    {
                        Fruit3.Image = Properties.Resources.Cherries;
                        image3 = 0;
                    }
                    else if (ImageSelect == 1)
                    {
                        Fruit3.Image = Properties.Resources.Lemons;
                        image3 = 1;
                    }
                    else if (ImageSelect == 2)
                    {
                        Fruit3.Image = Properties.Resources.Watermelon;
                        image3 = 2;
                    }

                }
                else if (slot == 4)
                {
                    ImageSelect = rdm.Next(0, 2);

                    if (ImageSelect == 0)
                    {
                        Fruit4.Image = Properties.Resources.Cherries;
                        image4 = 0;
                    }
                    else if (ImageSelect == 1)
                    {
                        Fruit4.Image = Properties.Resources.Lemons;
                        image4 = 1;
                    }
                    else if (ImageSelect == 2)
                    {
                        Fruit4.Image = Properties.Resources.Watermelon;
                        image4 = 2;
                    }
                }
            }
            else if (fruits == 4)
            {
                if (slot == 1)
                {
                    ImageSelect = rdm.Next(0, 3);

                    if (ImageSelect == 0)
                    {
                        Fruit1.Image = Properties.Resources.Cherries;
                        image1 = 0;
                    }
                    else if (ImageSelect == 1)
                    {
                        Fruit1.Image = Properties.Resources.Lemons;
                        image1 = 1;
                    }
                    else if (ImageSelect == 2)
                    {
                        Fruit1.Image = Properties.Resources.Watermelon;
                        image1 = 2;
                    }
                    else if (ImageSelect == 3)
                    {
                        Fruit1.Image = Properties.Resources.Grapes;
                        image1 = 3;
                    }
                }
                else if (slot == 2)
                {
                    ImageSelect = rdm.Next(0, 3);

                    if (ImageSelect == 0)
                    {
                        Fruit2.Image = Properties.Resources.Cherries;
                        image2 = 0;
                    }
                    else if (ImageSelect == 1)
                    {
                        Fruit2.Image = Properties.Resources.Lemons;
                        image2 = 1;
                    }
                    else if (ImageSelect == 2)
                    {
                        Fruit2.Image = Properties.Resources.Watermelon;
                        image2 = 2;
                    }
                    else if (ImageSelect == 3)
                    {
                        Fruit2.Image = Properties.Resources.Grapes;
                        image2 = 3;
                    }
                }
                else if (slot == 3)
                {
                    ImageSelect = rdm.Next(0, 3);

                    if (ImageSelect == 0)
                    {
                        Fruit3.Image = Properties.Resources.Cherries;
                        image3 = 0;
                    }
                    else if (ImageSelect == 1)
                    {
                        Fruit3.Image = Properties.Resources.Lemons;
                        image3 = 1;
                    }
                    else if (ImageSelect == 2)
                    {
                        Fruit3.Image = Properties.Resources.Watermelon;
                        image3 = 2;
                    }
                    else if (ImageSelect == 3)
                    {
                        Fruit3.Image = Properties.Resources.Grapes;
                        image3 = 3;
                    }
                }
                else if (slot == 4)
                {
                    ImageSelect = rdm.Next(0, 3);

                    if (ImageSelect == 0)
                    {
                        Fruit4.Image = Properties.Resources.Cherries;
                        image4 = 0;
                    }
                    else if (ImageSelect == 1)
                    {
                        Fruit4.Image = Properties.Resources.Lemons;
                        image4 = 1;
                    }
                    else if (ImageSelect == 2)
                    {
                        Fruit4.Image = Properties.Resources.Watermelon;
                        image4 = 2;
                    }
                    else if (ImageSelect == 3)
                    {
                        Fruit4.Image = Properties.Resources.Grapes;
                        image4 = 3;
                    }
                }
            }
            else if (fruits == 5)
            {
                if (slot == 1)
                {
                    ImageSelect = rdm.Next(0, 4);

                    if (ImageSelect == 0)
                    {
                        Fruit1.Image = Properties.Resources.Cherries;
                        image1 = 0;
                    }
                    else if (ImageSelect == 1)
                    {
                        Fruit1.Image = Properties.Resources.Lemons;
                        image1 = 1;
                    }
                    else if (ImageSelect == 2)
                    {
                        Fruit1.Image = Properties.Resources.Watermelon;
                        image1 = 2;
                    }
                    else if (ImageSelect == 3)
                    {
                        Fruit1.Image = Properties.Resources.Grapes;
                        image1 = 3;
                    }
                    else if (ImageSelect == 4)
                    {
                        Fruit1.Image = Properties.Resources.Orange;
                        image1 = 4;
                    }
                }
                else if (slot == 2)
                {
                    ImageSelect = rdm.Next(0, 3);

                    if (ImageSelect == 0)
                    {
                        Fruit2.Image = Properties.Resources.Cherries;
                        image2 = 0;
                    }
                    else if (ImageSelect == 1)
                    {
                        Fruit2.Image = Properties.Resources.Lemons;
                        image2 = 1;
                    }
                    else if (ImageSelect == 2)
                    {
                        Fruit2.Image = Properties.Resources.Watermelon;
                        image2 = 2;
                    }
                    else if (ImageSelect == 3)
                    {
                        Fruit2.Image = Properties.Resources.Grapes;
                        image2 = 3;
                    }
                    else if (ImageSelect == 4)
                    {
                        Fruit2.Image = Properties.Resources.Orange;
                        image2 = 4;
                    }
                }
                else if (slot == 3)
                {
                    ImageSelect = rdm.Next(0, 3);

                    if (ImageSelect == 0)
                    {
                        Fruit3.Image = Properties.Resources.Cherries;
                        image3 = 0;
                    }
                    else if (ImageSelect == 1)
                    {
                        Fruit3.Image = Properties.Resources.Lemons;
                        image3 = 1;
                    }
                    else if (ImageSelect == 2)
                    {
                        Fruit3.Image = Properties.Resources.Watermelon;
                        image3 = 2;
                    }
                    else if (ImageSelect == 3)
                    {
                        Fruit3.Image = Properties.Resources.Grapes;
                        image3 = 3;
                    }
                    else if (ImageSelect == 4)
                    {
                        Fruit3.Image = Properties.Resources.Orange;
                        image3 = 4;
                    }
                }
                else if (slot == 4)
                {
                    ImageSelect = rdm.Next(0, 3);

                    if (ImageSelect == 0)
                    {
                        Fruit4.Image = Properties.Resources.Cherries;
                        image4 = 0;
                    }
                    else if (ImageSelect == 1)
                    {
                        Fruit4.Image = Properties.Resources.Lemons;
                        image4 = 1;
                    }
                    else if (ImageSelect == 2)
                    {
                        Fruit4.Image = Properties.Resources.Watermelon;
                        image4 = 2;
                    }
                    else if (ImageSelect == 3)
                    {
                        Fruit4.Image = Properties.Resources.Grapes;
                        image4 = 3;
                    }
                    else if (ImageSelect == 4)
                    {
                        Fruit4.Image = Properties.Resources.Orange;
                        image4 = 4;
                    }
                }
            }
            else if (fruits == 6)
            {
                if (slot == 1)
                {
                    ImageSelect = rdm.Next(0, 5);

                    if (ImageSelect == 0)
                    {
                        Fruit1.Image = Properties.Resources.Cherries;
                        image1 = 0;
                    }
                    else if (ImageSelect == 1)
                    {
                        Fruit1.Image = Properties.Resources.Lemons;
                        image1 = 1;
                    }
                    else if (ImageSelect == 2)
                    {
                        Fruit1.Image = Properties.Resources.Watermelon;
                        image1 = 2;
                    }
                    else if (ImageSelect == 3)
                    {
                        Fruit1.Image = Properties.Resources.Grapes;
                        image1 = 3;
                    }
                    else if (ImageSelect == 4)
                    {
                        Fruit1.Image = Properties.Resources.Orange;
                        image1 = 4;
                    }
                    else if (ImageSelect == 5)
                    {
                        Fruit1.Image = Properties.Resources.Seven;
                        image1 = 5;
                    }
                }
                else if (slot == 2)
                {
                    ImageSelect = rdm.Next(0, 5);

                    if (ImageSelect == 0)
                    {
                        Fruit2.Image = Properties.Resources.Cherries;
                        image2 = 0;
                    }
                    else if (ImageSelect == 1)
                    {
                        Fruit2.Image = Properties.Resources.Lemons;
                        image2 = 1;
                    }
                    else if (ImageSelect == 2)
                    {
                        Fruit2.Image = Properties.Resources.Watermelon;
                        image2 = 2;
                    }
                    else if (ImageSelect == 3)
                    {
                        Fruit2.Image = Properties.Resources.Grapes;
                        image2 = 3;
                    }
                    else if (ImageSelect == 4)
                    {
                        Fruit2.Image = Properties.Resources.Orange;
                        image2 = 4;
                    }
                    else if (ImageSelect == 5)
                    {
                        Fruit2.Image = Properties.Resources.Seven;
                        image2 = 5;
                    }
                }
                else if (slot == 3)
                {
                    ImageSelect = rdm.Next(0, 5);

                    if (ImageSelect == 0)
                    {
                        Fruit3.Image = Properties.Resources.Cherries;
                        image3 = 0;
                    }
                    else if (ImageSelect == 1)
                    {
                        Fruit3.Image = Properties.Resources.Lemons;
                        image3 = 1;
                    }
                    else if (ImageSelect == 2)
                    {
                        Fruit3.Image = Properties.Resources.Watermelon;
                        image3 = 2;
                    }
                    else if (ImageSelect == 3)
                    {
                        Fruit3.Image = Properties.Resources.Grapes;
                        image3 = 3;
                    }
                    else if (ImageSelect == 4)
                    {
                        Fruit3.Image = Properties.Resources.Orange;
                        image3 = 4;
                    }
                    else if (ImageSelect == 5)
                    {
                        Fruit3.Image = Properties.Resources.Seven;
                        image3 = 5;
                    }
                }
                else if (slot == 4)
                {
                    ImageSelect = rdm.Next(0, 5);

                    if (ImageSelect == 0)
                    {
                        Fruit4.Image = Properties.Resources.Cherries;
                        image4 = 0;
                    }
                    else if (ImageSelect == 1)
                    {
                        Fruit4.Image = Properties.Resources.Lemons;
                        image4 = 1;
                    }
                    else if (ImageSelect == 2)
                    {
                        Fruit4.Image = Properties.Resources.Watermelon;
                        image4 = 2;
                    }
                    else if (ImageSelect == 3)
                    {
                        Fruit4.Image = Properties.Resources.Grapes;
                        image4 = 3;
                    }
                    else if (ImageSelect == 4)
                    {
                        Fruit4.Image = Properties.Resources.Orange;
                        image4 = 4;
                    }
                    else if (ImageSelect == 5)
                    {
                        Fruit4.Image = Properties.Resources.Seven;
                        image4 = 5;
                    }
                }
            }
        }
        private void Win_Check()
        {
            if (image1 == image2 && image2 == image3 && image3 == image4)//Win
            {
                Wallet += Bet;
                Walletbox.Text = Wallet.ToString();
                JackpotPicBox.Visible = true;
                JackpotPicBox.Image = Properties.Resources.jackpot_logo;
            }
            else//Lose
            {
                Wallet -= Bet;
                Walletbox.Text = Wallet.ToString();
            }
        }

        private void Credits_check()
        {
            if (Wallet <= 0)
            {
                spin_btn.Enabled = false;
                plusBet_btn.Enabled = false;
                minusBet_btn.Enabled = false;
                JackpotPicBox.Visible = true;
                JackpotPicBox.Image = Properties.Resources.Youlose;
            }

            if (Wallet - Bet < 0)
            {
                Bet = Wallet;
                BetBox.Text = Bet.ToString();
            }
        }

        private void plusBet_btn_Click(object sender, EventArgs e)
        {
            //ελεγχος για να μην ξεπερασει το Bet τα credits του χρήστη
            if (Bet < Wallet)
            {
                if (Wallet > 100)
                {
                    Bet += 100;
                    BetBox.Text = Bet.ToString();
                }
            }
        }

        private void minusBet_btn_Click(object sender, EventArgs e)
        {
            //ελεγχος για να μην γινει αρνητικο το Bet
            if (Bet > 0)
            {
                if (Wallet > 100)
                {
                    Bet -= 100;
                    BetBox.Text = Bet.ToString();
                }
            }
        }

        private void AllIn_btn_Click(object sender, EventArgs e)
        {
            Bet = Wallet;
            BetBox.Text = Bet.ToString();
        }
    }
}
