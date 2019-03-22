namespace Slot_Machine
{
    partial class Game3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game3));
            this.spin_btn = new System.Windows.Forms.Button();
            this.BetBox = new System.Windows.Forms.TextBox();
            this.plusBet_btn = new System.Windows.Forms.Button();
            this.minusBet_btn = new System.Windows.Forms.Button();
            this.Walletbox = new System.Windows.Forms.TextBox();
            this.SpinTimer = new System.Windows.Forms.Timer(this.components);
            this.ImageCycleTimer = new System.Windows.Forms.Timer(this.components);
            this.AllIn_btn = new System.Windows.Forms.Button();
            this.GifFruit5 = new System.Windows.Forms.PictureBox();
            this.GifFruit4 = new System.Windows.Forms.PictureBox();
            this.GifFruit3 = new System.Windows.Forms.PictureBox();
            this.GifFruit2 = new System.Windows.Forms.PictureBox();
            this.GifFruit1 = new System.Windows.Forms.PictureBox();
            this.Fruit5 = new System.Windows.Forms.PictureBox();
            this.Fruit4 = new System.Windows.Forms.PictureBox();
            this.Fruit3 = new System.Windows.Forms.PictureBox();
            this.Fruit2 = new System.Windows.Forms.PictureBox();
            this.Fruit1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.JackpotPicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GifFruit5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GifFruit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GifFruit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GifFruit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GifFruit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fruit5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fruit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fruit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fruit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fruit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JackpotPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // spin_btn
            // 
            this.spin_btn.BackgroundImage = global::Slot_Machine.Properties.Resources.Spinbtn;
            this.spin_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.spin_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.spin_btn.Font = new System.Drawing.Font("Franklin Gothic Heavy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spin_btn.ForeColor = System.Drawing.Color.White;
            this.spin_btn.Location = new System.Drawing.Point(1064, 429);
            this.spin_btn.Name = "spin_btn";
            this.spin_btn.Size = new System.Drawing.Size(130, 75);
            this.spin_btn.TabIndex = 5;
            this.spin_btn.Text = "Spin";
            this.spin_btn.UseVisualStyleBackColor = true;
            this.spin_btn.Click += new System.EventHandler(this.spin_btn_Click);
            // 
            // BetBox
            // 
            this.BetBox.BackColor = System.Drawing.SystemColors.Control;
            this.BetBox.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BetBox.Location = new System.Drawing.Point(553, 429);
            this.BetBox.Multiline = true;
            this.BetBox.Name = "BetBox";
            this.BetBox.ReadOnly = true;
            this.BetBox.Size = new System.Drawing.Size(187, 75);
            this.BetBox.TabIndex = 6;
            this.BetBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // plusBet_btn
            // 
            this.plusBet_btn.BackgroundImage = global::Slot_Machine.Properties.Resources.GenericBtn;
            this.plusBet_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.plusBet_btn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.plusBet_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plusBet_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusBet_btn.Location = new System.Drawing.Point(746, 448);
            this.plusBet_btn.Name = "plusBet_btn";
            this.plusBet_btn.Size = new System.Drawing.Size(47, 37);
            this.plusBet_btn.TabIndex = 12;
            this.plusBet_btn.Text = "+";
            this.plusBet_btn.UseVisualStyleBackColor = true;
            this.plusBet_btn.Click += new System.EventHandler(this.plusBet_btn_Click);
            // 
            // minusBet_btn
            // 
            this.minusBet_btn.BackgroundImage = global::Slot_Machine.Properties.Resources.GenericBtn;
            this.minusBet_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minusBet_btn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.minusBet_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minusBet_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusBet_btn.Location = new System.Drawing.Point(500, 448);
            this.minusBet_btn.Name = "minusBet_btn";
            this.minusBet_btn.Size = new System.Drawing.Size(47, 37);
            this.minusBet_btn.TabIndex = 13;
            this.minusBet_btn.Text = "-";
            this.minusBet_btn.UseVisualStyleBackColor = true;
            this.minusBet_btn.Click += new System.EventHandler(this.minusBet_btn_Click);
            // 
            // Walletbox
            // 
            this.Walletbox.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Walletbox.Location = new System.Drawing.Point(93, 429);
            this.Walletbox.Multiline = true;
            this.Walletbox.Name = "Walletbox";
            this.Walletbox.ReadOnly = true;
            this.Walletbox.Size = new System.Drawing.Size(175, 75);
            this.Walletbox.TabIndex = 14;
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
            // AllIn_btn
            // 
            this.AllIn_btn.BackgroundImage = global::Slot_Machine.Properties.Resources.GenericBtn;
            this.AllIn_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AllIn_btn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.AllIn_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AllIn_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllIn_btn.Location = new System.Drawing.Point(585, 510);
            this.AllIn_btn.Name = "AllIn_btn";
            this.AllIn_btn.Size = new System.Drawing.Size(125, 35);
            this.AllIn_btn.TabIndex = 15;
            this.AllIn_btn.Text = "All-In";
            this.AllIn_btn.UseVisualStyleBackColor = true;
            this.AllIn_btn.Click += new System.EventHandler(this.AllIn_btn_Click);
            // 
            // GifFruit5
            // 
            this.GifFruit5.Image = global::Slot_Machine.Properties.Resources.Watermelon;
            this.GifFruit5.Location = new System.Drawing.Point(1007, 141);
            this.GifFruit5.Name = "GifFruit5";
            this.GifFruit5.Size = new System.Drawing.Size(187, 215);
            this.GifFruit5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GifFruit5.TabIndex = 11;
            this.GifFruit5.TabStop = false;
            // 
            // GifFruit4
            // 
            this.GifFruit4.Image = global::Slot_Machine.Properties.Resources.Lemons;
            this.GifFruit4.Location = new System.Drawing.Point(783, 141);
            this.GifFruit4.Name = "GifFruit4";
            this.GifFruit4.Size = new System.Drawing.Size(187, 215);
            this.GifFruit4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GifFruit4.TabIndex = 10;
            this.GifFruit4.TabStop = false;
            // 
            // GifFruit3
            // 
            this.GifFruit3.Image = global::Slot_Machine.Properties.Resources.Watermelon;
            this.GifFruit3.Location = new System.Drawing.Point(553, 141);
            this.GifFruit3.Name = "GifFruit3";
            this.GifFruit3.Size = new System.Drawing.Size(187, 215);
            this.GifFruit3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GifFruit3.TabIndex = 9;
            this.GifFruit3.TabStop = false;
            // 
            // GifFruit2
            // 
            this.GifFruit2.Image = global::Slot_Machine.Properties.Resources.Cherries;
            this.GifFruit2.Location = new System.Drawing.Point(326, 141);
            this.GifFruit2.Name = "GifFruit2";
            this.GifFruit2.Size = new System.Drawing.Size(187, 215);
            this.GifFruit2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GifFruit2.TabIndex = 8;
            this.GifFruit2.TabStop = false;
            // 
            // GifFruit1
            // 
            this.GifFruit1.Image = global::Slot_Machine.Properties.Resources.Cherries;
            this.GifFruit1.Location = new System.Drawing.Point(97, 141);
            this.GifFruit1.Name = "GifFruit1";
            this.GifFruit1.Size = new System.Drawing.Size(187, 215);
            this.GifFruit1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GifFruit1.TabIndex = 7;
            this.GifFruit1.TabStop = false;
            // 
            // Fruit5
            // 
            this.Fruit5.Location = new System.Drawing.Point(1007, 141);
            this.Fruit5.Name = "Fruit5";
            this.Fruit5.Size = new System.Drawing.Size(187, 215);
            this.Fruit5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Fruit5.TabIndex = 4;
            this.Fruit5.TabStop = false;
            // 
            // Fruit4
            // 
            this.Fruit4.Location = new System.Drawing.Point(783, 141);
            this.Fruit4.Name = "Fruit4";
            this.Fruit4.Size = new System.Drawing.Size(187, 215);
            this.Fruit4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Fruit4.TabIndex = 3;
            this.Fruit4.TabStop = false;
            // 
            // Fruit3
            // 
            this.Fruit3.Location = new System.Drawing.Point(553, 141);
            this.Fruit3.Name = "Fruit3";
            this.Fruit3.Size = new System.Drawing.Size(187, 215);
            this.Fruit3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Fruit3.TabIndex = 2;
            this.Fruit3.TabStop = false;
            // 
            // Fruit2
            // 
            this.Fruit2.Location = new System.Drawing.Point(326, 141);
            this.Fruit2.Name = "Fruit2";
            this.Fruit2.Size = new System.Drawing.Size(187, 215);
            this.Fruit2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Fruit2.TabIndex = 1;
            this.Fruit2.TabStop = false;
            // 
            // Fruit1
            // 
            this.Fruit1.Location = new System.Drawing.Point(97, 141);
            this.Fruit1.Name = "Fruit1";
            this.Fruit1.Size = new System.Drawing.Size(187, 215);
            this.Fruit1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Fruit1.TabIndex = 0;
            this.Fruit1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Slot_Machine.Properties.Resources.Machine3;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(50, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1205, 539);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Credits:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(553, 402);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "Bet:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // JackpotPicBox
            // 
            this.JackpotPicBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.JackpotPicBox.Location = new System.Drawing.Point(477, 45);
            this.JackpotPicBox.Name = "JackpotPicBox";
            this.JackpotPicBox.Size = new System.Drawing.Size(358, 67);
            this.JackpotPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.JackpotPicBox.TabIndex = 19;
            this.JackpotPicBox.TabStop = false;
            // 
            // Game3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1284, 590);
            this.Controls.Add(this.JackpotPicBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AllIn_btn);
            this.Controls.Add(this.Walletbox);
            this.Controls.Add(this.minusBet_btn);
            this.Controls.Add(this.plusBet_btn);
            this.Controls.Add(this.GifFruit5);
            this.Controls.Add(this.GifFruit4);
            this.Controls.Add(this.GifFruit3);
            this.Controls.Add(this.GifFruit2);
            this.Controls.Add(this.GifFruit1);
            this.Controls.Add(this.BetBox);
            this.Controls.Add(this.spin_btn);
            this.Controls.Add(this.Fruit5);
            this.Controls.Add(this.Fruit4);
            this.Controls.Add(this.Fruit3);
            this.Controls.Add(this.Fruit2);
            this.Controls.Add(this.Fruit1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1278, 615);
            this.Name = "Game3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Slot Machine";
            ((System.ComponentModel.ISupportInitialize)(this.GifFruit5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GifFruit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GifFruit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GifFruit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GifFruit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fruit5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fruit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fruit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fruit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fruit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JackpotPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Fruit1;
        private System.Windows.Forms.PictureBox Fruit2;
        private System.Windows.Forms.PictureBox Fruit3;
        private System.Windows.Forms.PictureBox Fruit4;
        private System.Windows.Forms.PictureBox Fruit5;
        private System.Windows.Forms.Button spin_btn;
        private System.Windows.Forms.TextBox BetBox;
        private System.Windows.Forms.PictureBox GifFruit1;
        private System.Windows.Forms.PictureBox GifFruit2;
        private System.Windows.Forms.PictureBox GifFruit3;
        private System.Windows.Forms.PictureBox GifFruit4;
        private System.Windows.Forms.PictureBox GifFruit5;
        private System.Windows.Forms.Button plusBet_btn;
        private System.Windows.Forms.Button minusBet_btn;
        private System.Windows.Forms.TextBox Walletbox;
        private System.Windows.Forms.Timer SpinTimer;
        private System.Windows.Forms.Timer ImageCycleTimer;
        private System.Windows.Forms.Button AllIn_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox JackpotPicBox;
    }
}