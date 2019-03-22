namespace Slot_Machine
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.start_game_btn = new System.Windows.Forms.Button();
            this.options_btn = new System.Windows.Forms.Button();
            this.credits_btn = new System.Windows.Forms.Button();
            this.quit_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // start_game_btn
            // 
            this.start_game_btn.BackColor = System.Drawing.Color.Transparent;
            this.start_game_btn.FlatAppearance.BorderSize = 0;
            this.start_game_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start_game_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_game_btn.Location = new System.Drawing.Point(187, 167);
            this.start_game_btn.Name = "start_game_btn";
            this.start_game_btn.Size = new System.Drawing.Size(145, 33);
            this.start_game_btn.TabIndex = 0;
            this.start_game_btn.Text = "Start Game";
            this.start_game_btn.UseVisualStyleBackColor = false;
            this.start_game_btn.Click += new System.EventHandler(this.start_game_btn_Click);
            // 
            // options_btn
            // 
            this.options_btn.BackColor = System.Drawing.Color.Transparent;
            this.options_btn.FlatAppearance.BorderSize = 0;
            this.options_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.options_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.options_btn.Location = new System.Drawing.Point(200, 206);
            this.options_btn.Name = "options_btn";
            this.options_btn.Size = new System.Drawing.Size(120, 31);
            this.options_btn.TabIndex = 1;
            this.options_btn.Text = "Options";
            this.options_btn.UseVisualStyleBackColor = false;
            this.options_btn.Click += new System.EventHandler(this.options_btn_Click);
            // 
            // credits_btn
            // 
            this.credits_btn.BackColor = System.Drawing.Color.Transparent;
            this.credits_btn.FlatAppearance.BorderSize = 0;
            this.credits_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.credits_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.credits_btn.Location = new System.Drawing.Point(200, 244);
            this.credits_btn.Name = "credits_btn";
            this.credits_btn.Size = new System.Drawing.Size(120, 28);
            this.credits_btn.TabIndex = 2;
            this.credits_btn.Text = "Credits";
            this.credits_btn.UseVisualStyleBackColor = false;
            this.credits_btn.Click += new System.EventHandler(this.credits_btn_Click);
            // 
            // quit_btn
            // 
            this.quit_btn.BackColor = System.Drawing.Color.Transparent;
            this.quit_btn.FlatAppearance.BorderSize = 0;
            this.quit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quit_btn.Location = new System.Drawing.Point(200, 287);
            this.quit_btn.Name = "quit_btn";
            this.quit_btn.Size = new System.Drawing.Size(120, 28);
            this.quit_btn.TabIndex = 3;
            this.quit_btn.Text = "Quit";
            this.quit_btn.UseVisualStyleBackColor = false;
            this.quit_btn.Click += new System.EventHandler(this.quit_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Slot_Machine.Properties.Resources.MainMenuBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(515, 405);
            this.Controls.Add(this.quit_btn);
            this.Controls.Add(this.credits_btn);
            this.Controls.Add(this.options_btn);
            this.Controls.Add(this.start_game_btn);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SlotMachine";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button start_game_btn;
        private System.Windows.Forms.Button options_btn;
        private System.Windows.Forms.Button credits_btn;
        private System.Windows.Forms.Button quit_btn;
    }
}

