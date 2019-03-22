namespace Slot_Machine
{
    partial class Game2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game2));
            this.GifFruit1 = new System.Windows.Forms.PictureBox();
            this.GifFruit2 = new System.Windows.Forms.PictureBox();
            this.GifFruit3 = new System.Windows.Forms.PictureBox();
            this.GifFruit4 = new System.Windows.Forms.PictureBox();
            this.spin_btn = new System.Windows.Forms.Button();
            this.plusBet_btn = new System.Windows.Forms.Button();
            this.minusBet_btn = new System.Windows.Forms.Button();
            this.BetBox = new System.Windows.Forms.TextBox();
            this.Walletbox = new System.Windows.Forms.TextBox();
            this.Fruit1 = new System.Windows.Forms.PictureBox();
            this.Fruit2 = new System.Windows.Forms.PictureBox();
            this.Fruit3 = new System.Windows.Forms.PictureBox();
            this.Fruit4 = new System.Windows.Forms.PictureBox();
            this.SpinTimer = new System.Windows.Forms.Timer(this.components);
            this.ImageCycleTimer = new System.Windows.Forms.Timer(this.components);
            this.AllIn_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.JackpotPicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GifFruit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GifFruit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GifFruit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GifFruit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fruit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fruit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fruit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fruit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JackpotPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // GifFruit1
            // 
            this.GifFruit1.Image = global::Slot_Machine.Properties.Resources.Watermelon;
            this.GifFruit1.Location = new System.Drawing.Point(82, 158);
            this.GifFruit1.Name = "GifFruit1";
            this.GifFruit1.Size = new System.Drawing.Size(140, 175);
            this.GifFruit1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GifFruit1.TabIndex = 0;
            this.GifFruit1.TabStop = false;
            // 
            // GifFruit2
            // 
            this.GifFruit2.Image = ((System.Drawing.Image)(resources.GetObject("GifFruit2.Image")));
            this.GifFruit2.Location = new System.Drawing.Point(247, 158);
            this.GifFruit2.Name = "GifFruit2";
            this.GifFruit2.Size = new System.Drawing.Size(140, 175);
            this.GifFruit2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GifFruit2.TabIndex = 1;
            this.GifFruit2.TabStop = false;
            // 
            // GifFruit3
            // 
            this.GifFruit3.Image = ((System.Drawing.Image)(resources.GetObject("GifFruit3.Image")));
            this.GifFruit3.Location = new System.Drawing.Point(420, 158);
            this.GifFruit3.Name = "GifFruit3";
            this.GifFruit3.Size = new System.Drawing.Size(140, 175);
            this.GifFruit3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GifFruit3.TabIndex = 2;
            this.GifFruit3.TabStop = false;
            // 
            // GifFruit4
            // 
            this.GifFruit4.Image = ((System.Drawing.Image)(resources.GetObject("GifFruit4.Image")));
            this.GifFruit4.Location = new System.Drawing.Point(585, 158);
            this.GifFruit4.Name = "GifFruit4";
            this.GifFruit4.Size = new System.Drawing.Size(140, 175);
            this.GifFruit4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GifFruit4.TabIndex = 3;
            this.GifFruit4.TabStop = false;
            // 
            // spin_btn
            // 
            this.spin_btn.BackgroundImage = global::Slot_Machine.Properties.Resources.Spinbtn;
            this.spin_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.spin_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.spin_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spin_btn.ForeColor = System.Drawing.Color.White;
            this.spin_btn.Location = new System.Drawing.Point(628, 371);
            this.spin_btn.Name = "spin_btn";
            this.spin_btn.Size = new System.Drawing.Size(98, 61);
            this.spin_btn.TabIndex = 4;
            this.spin_btn.Text = "Spin";
            this.spin_btn.UseVisualStyleBackColor = true;
            this.spin_btn.Click += new System.EventHandler(this.spin_btn_Click);
            // 
            // plusBet_btn
            // 
            this.plusBet_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("plusBet_btn.BackgroundImage")));
            this.plusBet_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.plusBet_btn.FlatAppearance.BorderSize = 0;
            this.plusBet_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plusBet_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusBet_btn.Location = new System.Drawing.Point(482, 386);
            this.plusBet_btn.Name = "plusBet_btn";
            this.plusBet_btn.Size = new System.Drawing.Size(40, 30);
            this.plusBet_btn.TabIndex = 5;
            this.plusBet_btn.Text = "+";
            this.plusBet_btn.UseVisualStyleBackColor = true;
            this.plusBet_btn.Click += new System.EventHandler(this.plusBet_btn_Click);
            // 
            // minusBet_btn
            // 
            this.minusBet_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minusBet_btn.BackgroundImage")));
            this.minusBet_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minusBet_btn.FlatAppearance.BorderSize = 0;
            this.minusBet_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minusBet_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusBet_btn.Location = new System.Drawing.Point(299, 386);
            this.minusBet_btn.Name = "minusBet_btn";
            this.minusBet_btn.Size = new System.Drawing.Size(40, 31);
            this.minusBet_btn.TabIndex = 6;
            this.minusBet_btn.Text = "-";
            this.minusBet_btn.UseVisualStyleBackColor = true;
            this.minusBet_btn.Click += new System.EventHandler(this.minusBet_btn_Click);
            // 
            // BetBox
            // 
            this.BetBox.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BetBox.Location = new System.Drawing.Point(345, 371);
            this.BetBox.Multiline = true;
            this.BetBox.Name = "BetBox";
            this.BetBox.ReadOnly = true;
            this.BetBox.Size = new System.Drawing.Size(132, 62);
            this.BetBox.TabIndex = 7;
            this.BetBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Walletbox
            // 
            this.Walletbox.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Walletbox.Location = new System.Drawing.Point(77, 374);
            this.Walletbox.Multiline = true;
            this.Walletbox.Name = "Walletbox";
            this.Walletbox.ReadOnly = true;
            this.Walletbox.Size = new System.Drawing.Size(140, 62);
            this.Walletbox.TabIndex = 8;
            this.Walletbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Fruit1
            // 
            this.Fruit1.Location = new System.Drawing.Point(82, 158);
            this.Fruit1.Name = "Fruit1";
            this.Fruit1.Size = new System.Drawing.Size(140, 175);
            this.Fruit1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Fruit1.TabIndex = 9;
            this.Fruit1.TabStop = false;
            // 
            // Fruit2
            // 
            this.Fruit2.Location = new System.Drawing.Point(247, 158);
            this.Fruit2.Name = "Fruit2";
            this.Fruit2.Size = new System.Drawing.Size(140, 175);
            this.Fruit2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Fruit2.TabIndex = 10;
            this.Fruit2.TabStop = false;
            // 
            // Fruit3
            // 
            this.Fruit3.Location = new System.Drawing.Point(420, 158);
            this.Fruit3.Name = "Fruit3";
            this.Fruit3.Size = new System.Drawing.Size(140, 175);
            this.Fruit3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Fruit3.TabIndex = 11;
            this.Fruit3.TabStop = false;
            // 
            // Fruit4
            // 
            this.Fruit4.Location = new System.Drawing.Point(585, 158);
            this.Fruit4.Name = "Fruit4";
            this.Fruit4.Size = new System.Drawing.Size(140, 175);
            this.Fruit4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Fruit4.TabIndex = 12;
            this.Fruit4.TabStop = false;
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
            this.AllIn_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AllIn_btn.BackgroundImage")));
            this.AllIn_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AllIn_btn.FlatAppearance.BorderSize = 0;
            this.AllIn_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AllIn_btn.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllIn_btn.Location = new System.Drawing.Point(362, 438);
            this.AllIn_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AllIn_btn.Name = "AllIn_btn";
            this.AllIn_btn.Size = new System.Drawing.Size(94, 28);
            this.AllIn_btn.TabIndex = 13;
            this.AllIn_btn.Text = "All-In";
            this.AllIn_btn.UseVisualStyleBackColor = true;
            this.AllIn_btn.Click += new System.EventHandler(this.AllIn_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(44, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(719, 450);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(719, 458);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(345, 354);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Bet:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 354);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Credits:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // JackpotPicBox
            // 
            this.JackpotPicBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.JackpotPicBox.Location = new System.Drawing.Point(247, 50);
            this.JackpotPicBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.JackpotPicBox.Name = "JackpotPicBox";
            this.JackpotPicBox.Size = new System.Drawing.Size(314, 70);
            this.JackpotPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.JackpotPicBox.TabIndex = 17;
            this.JackpotPicBox.TabStop = false;
            // 
            // Game2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(813, 531);
            this.Controls.Add(this.JackpotPicBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AllIn_btn);
            this.Controls.Add(this.Walletbox);
            this.Controls.Add(this.BetBox);
            this.Controls.Add(this.minusBet_btn);
            this.Controls.Add(this.plusBet_btn);
            this.Controls.Add(this.spin_btn);
            this.Controls.Add(this.GifFruit4);
            this.Controls.Add(this.GifFruit3);
            this.Controls.Add(this.GifFruit2);
            this.Controls.Add(this.GifFruit1);
            this.Controls.Add(this.Fruit1);
            this.Controls.Add(this.Fruit2);
            this.Controls.Add(this.Fruit3);
            this.Controls.Add(this.Fruit4);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(829, 507);
            this.Name = "Game2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Slot Machine";
            ((System.ComponentModel.ISupportInitialize)(this.GifFruit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GifFruit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GifFruit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GifFruit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fruit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fruit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fruit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fruit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JackpotPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox GifFruit1;
        private System.Windows.Forms.PictureBox GifFruit2;
        private System.Windows.Forms.PictureBox GifFruit3;
        private System.Windows.Forms.PictureBox GifFruit4;
        private System.Windows.Forms.Button spin_btn;
        private System.Windows.Forms.Button plusBet_btn;
        private System.Windows.Forms.Button minusBet_btn;
        private System.Windows.Forms.TextBox BetBox;
        private System.Windows.Forms.TextBox Walletbox;
        private System.Windows.Forms.PictureBox Fruit1;
        private System.Windows.Forms.PictureBox Fruit2;
        private System.Windows.Forms.PictureBox Fruit3;
        private System.Windows.Forms.PictureBox Fruit4;
        private System.Windows.Forms.Timer SpinTimer;
        private System.Windows.Forms.Timer ImageCycleTimer;
        private System.Windows.Forms.Button AllIn_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox JackpotPicBox;
    }
}