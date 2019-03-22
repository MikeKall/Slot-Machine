namespace Slot_Machine
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.Walletbox = new System.Windows.Forms.TextBox();
            this.SpinTimer = new System.Windows.Forms.Timer(this.components);
            this.ImageCycleTimer = new System.Windows.Forms.Timer(this.components);
            this.BetBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.JackpotPicBox = new System.Windows.Forms.PictureBox();
            this.AllIn_btn = new System.Windows.Forms.Button();
            this.GifFruit3 = new System.Windows.Forms.PictureBox();
            this.GifFruit2 = new System.Windows.Forms.PictureBox();
            this.GifFruit1 = new System.Windows.Forms.PictureBox();
            this.minusBet_btn = new System.Windows.Forms.Button();
            this.plusBet_btn = new System.Windows.Forms.Button();
            this.spin_btn = new System.Windows.Forms.Button();
            this.Fruit3 = new System.Windows.Forms.PictureBox();
            this.Fruit2 = new System.Windows.Forms.PictureBox();
            this.Fruit1 = new System.Windows.Forms.PictureBox();
            this.Machine1PicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.JackpotPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GifFruit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GifFruit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GifFruit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fruit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fruit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fruit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Machine1PicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Walletbox
            // 
            this.Walletbox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Walletbox.Location = new System.Drawing.Point(89, 355);
            this.Walletbox.Multiline = true;
            this.Walletbox.Name = "Walletbox";
            this.Walletbox.ReadOnly = true;
            this.Walletbox.Size = new System.Drawing.Size(140, 50);
            this.Walletbox.TabIndex = 7;
            this.Walletbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SpinTimer
            // 
            this.SpinTimer.Tick += new System.EventHandler(this.SpinTimer_Tick);
            // 
            // ImageCycleTimer
            // 
            this.ImageCycleTimer.Tick += new System.EventHandler(this.ImageCycleTimer_Tick);
            // 
            // BetBox
            // 
            this.BetBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.BetBox.Location = new System.Drawing.Point(288, 354);
            this.BetBox.Multiline = true;
            this.BetBox.Name = "BetBox";
            this.BetBox.ReadOnly = true;
            this.BetBox.Size = new System.Drawing.Size(110, 50);
            this.BetBox.TabIndex = 13;
            this.BetBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 332);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Credits:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(285, 332);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Bet:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // JackpotPicBox
            // 
            this.JackpotPicBox.BackColor = System.Drawing.Color.Silver;
            this.JackpotPicBox.Location = new System.Drawing.Point(185, 38);
            this.JackpotPicBox.Name = "JackpotPicBox";
            this.JackpotPicBox.Size = new System.Drawing.Size(322, 70);
            this.JackpotPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.JackpotPicBox.TabIndex = 12;
            this.JackpotPicBox.TabStop = false;
            this.JackpotPicBox.Visible = false;
            // 
            // AllIn_btn
            // 
            this.AllIn_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AllIn_btn.BackgroundImage")));
            this.AllIn_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AllIn_btn.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.AllIn_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.AllIn_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.AllIn_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AllIn_btn.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllIn_btn.Location = new System.Drawing.Point(302, 410);
            this.AllIn_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AllIn_btn.Name = "AllIn_btn";
            this.AllIn_btn.Size = new System.Drawing.Size(81, 27);
            this.AllIn_btn.TabIndex = 14;
            this.AllIn_btn.Text = "All-In";
            this.AllIn_btn.UseVisualStyleBackColor = true;
            this.AllIn_btn.Click += new System.EventHandler(this.AllIn_btn_Click);
            // 
            // GifFruit3
            // 
            this.GifFruit3.Image = global::Slot_Machine.Properties.Resources.Lemons;
            this.GifFruit3.Location = new System.Drawing.Point(447, 135);
            this.GifFruit3.Name = "GifFruit3";
            this.GifFruit3.Size = new System.Drawing.Size(140, 176);
            this.GifFruit3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GifFruit3.TabIndex = 10;
            this.GifFruit3.TabStop = false;
            // 
            // GifFruit2
            // 
            this.GifFruit2.Image = global::Slot_Machine.Properties.Resources.Cherries;
            this.GifFruit2.Location = new System.Drawing.Point(274, 136);
            this.GifFruit2.Name = "GifFruit2";
            this.GifFruit2.Size = new System.Drawing.Size(140, 176);
            this.GifFruit2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GifFruit2.TabIndex = 9;
            this.GifFruit2.TabStop = false;
            // 
            // GifFruit1
            // 
            this.GifFruit1.Image = global::Slot_Machine.Properties.Resources.Watermelon;
            this.GifFruit1.Location = new System.Drawing.Point(100, 135);
            this.GifFruit1.Name = "GifFruit1";
            this.GifFruit1.Size = new System.Drawing.Size(141, 176);
            this.GifFruit1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GifFruit1.TabIndex = 8;
            this.GifFruit1.TabStop = false;
            // 
            // minusBet_btn
            // 
            this.minusBet_btn.BackColor = System.Drawing.SystemColors.Control;
            this.minusBet_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minusBet_btn.BackgroundImage")));
            this.minusBet_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minusBet_btn.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.minusBet_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.minusBet_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.minusBet_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minusBet_btn.Location = new System.Drawing.Point(404, 378);
            this.minusBet_btn.Name = "minusBet_btn";
            this.minusBet_btn.Size = new System.Drawing.Size(35, 27);
            this.minusBet_btn.TabIndex = 6;
            this.minusBet_btn.Text = "-";
            this.minusBet_btn.UseVisualStyleBackColor = false;
            this.minusBet_btn.Click += new System.EventHandler(this.minusBet_btn_Click);
            // 
            // plusBet_btn
            // 
            this.plusBet_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("plusBet_btn.BackgroundImage")));
            this.plusBet_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.plusBet_btn.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.plusBet_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.plusBet_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.plusBet_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plusBet_btn.Location = new System.Drawing.Point(404, 354);
            this.plusBet_btn.Name = "plusBet_btn";
            this.plusBet_btn.Size = new System.Drawing.Size(35, 25);
            this.plusBet_btn.TabIndex = 5;
            this.plusBet_btn.Text = "+";
            this.plusBet_btn.UseVisualStyleBackColor = true;
            this.plusBet_btn.Click += new System.EventHandler(this.plusBet_btn_Click);
            // 
            // spin_btn
            // 
            this.spin_btn.BackColor = System.Drawing.Color.Transparent;
            this.spin_btn.BackgroundImage = global::Slot_Machine.Properties.Resources.Spinbtn;
            this.spin_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.spin_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.spin_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spin_btn.ForeColor = System.Drawing.Color.White;
            this.spin_btn.Location = new System.Drawing.Point(497, 349);
            this.spin_btn.Name = "spin_btn";
            this.spin_btn.Size = new System.Drawing.Size(90, 55);
            this.spin_btn.TabIndex = 3;
            this.spin_btn.Text = "Spin";
            this.spin_btn.UseVisualStyleBackColor = false;
            this.spin_btn.Click += new System.EventHandler(this.spin_btn_Click);
            // 
            // Fruit3
            // 
            this.Fruit3.Location = new System.Drawing.Point(447, 136);
            this.Fruit3.Name = "Fruit3";
            this.Fruit3.Size = new System.Drawing.Size(140, 175);
            this.Fruit3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Fruit3.TabIndex = 2;
            this.Fruit3.TabStop = false;
            // 
            // Fruit2
            // 
            this.Fruit2.Location = new System.Drawing.Point(274, 136);
            this.Fruit2.Name = "Fruit2";
            this.Fruit2.Size = new System.Drawing.Size(140, 175);
            this.Fruit2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Fruit2.TabIndex = 1;
            this.Fruit2.TabStop = false;
            // 
            // Fruit1
            // 
            this.Fruit1.Location = new System.Drawing.Point(100, 136);
            this.Fruit1.Name = "Fruit1";
            this.Fruit1.Size = new System.Drawing.Size(140, 175);
            this.Fruit1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Fruit1.TabIndex = 0;
            this.Fruit1.TabStop = false;
            // 
            // Machine1PicBox
            // 
            this.Machine1PicBox.BackColor = System.Drawing.Color.Transparent;
            this.Machine1PicBox.BackgroundImage = global::Slot_Machine.Properties.Resources.Machine1;
            this.Machine1PicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Machine1PicBox.Location = new System.Drawing.Point(44, 11);
            this.Machine1PicBox.Name = "Machine1PicBox";
            this.Machine1PicBox.Size = new System.Drawing.Size(592, 452);
            this.Machine1PicBox.TabIndex = 11;
            this.Machine1PicBox.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(682, 480);
            this.Controls.Add(this.JackpotPicBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AllIn_btn);
            this.Controls.Add(this.BetBox);
            this.Controls.Add(this.GifFruit3);
            this.Controls.Add(this.GifFruit2);
            this.Controls.Add(this.GifFruit1);
            this.Controls.Add(this.Walletbox);
            this.Controls.Add(this.minusBet_btn);
            this.Controls.Add(this.plusBet_btn);
            this.Controls.Add(this.spin_btn);
            this.Controls.Add(this.Fruit3);
            this.Controls.Add(this.Fruit2);
            this.Controls.Add(this.Fruit1);
            this.Controls.Add(this.Machine1PicBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(698, 495);
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Slot Machine";
            ((System.ComponentModel.ISupportInitialize)(this.JackpotPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GifFruit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GifFruit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GifFruit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fruit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fruit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fruit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Machine1PicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Fruit1;
        private System.Windows.Forms.PictureBox Fruit2;
        private System.Windows.Forms.PictureBox Fruit3;
        private System.Windows.Forms.Button spin_btn;
        private System.Windows.Forms.Button plusBet_btn;
        private System.Windows.Forms.Button minusBet_btn;
        private System.Windows.Forms.TextBox Walletbox;
        private System.Windows.Forms.PictureBox GifFruit1;
        private System.Windows.Forms.PictureBox GifFruit2;
        private System.Windows.Forms.PictureBox GifFruit3;
        private System.Windows.Forms.Timer SpinTimer;
        private System.Windows.Forms.PictureBox Machine1PicBox;
        private System.Windows.Forms.PictureBox JackpotPicBox;
        private System.Windows.Forms.Timer ImageCycleTimer;
        private System.Windows.Forms.TextBox BetBox;
        private System.Windows.Forms.Button AllIn_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}