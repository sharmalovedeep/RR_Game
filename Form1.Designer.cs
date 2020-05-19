namespace RR_Game
{
    partial class RRGame
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
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_spin = new System.Windows.Forms.Button();
            this.btn_shoot = new System.Windows.Forms.Button();
            this.btn_shootAway = new System.Windows.Forms.Button();
            this.pic_change_box = new System.Windows.Forms.PictureBox();
            this.lbl_headline = new System.Windows.Forms.Label();
            this.btn_playAgain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_change_box)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_load
            // 
            this.btn_load.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_load.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_load.Location = new System.Drawing.Point(295, 100);
            this.btn_load.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(131, 39);
            this.btn_load.TabIndex = 0;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = false;
            this.btn_load.Click += new System.EventHandler(this.Btn_laod_Click);
            // 
            // btn_spin
            // 
            this.btn_spin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_spin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_spin.Location = new System.Drawing.Point(295, 161);
            this.btn_spin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_spin.Name = "btn_spin";
            this.btn_spin.Size = new System.Drawing.Size(131, 39);
            this.btn_spin.TabIndex = 1;
            this.btn_spin.Text = "Spin";
            this.btn_spin.UseVisualStyleBackColor = false;
            this.btn_spin.Click += new System.EventHandler(this.Btn_spin_Click);
            // 
            // btn_shoot
            // 
            this.btn_shoot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_shoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_shoot.Location = new System.Drawing.Point(295, 220);
            this.btn_shoot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_shoot.Name = "btn_shoot";
            this.btn_shoot.Size = new System.Drawing.Size(131, 42);
            this.btn_shoot.TabIndex = 2;
            this.btn_shoot.Text = "Shoot";
            this.btn_shoot.UseVisualStyleBackColor = false;
            this.btn_shoot.Click += new System.EventHandler(this.Btn_shoot_Click);
            // 
            // btn_shootAway
            // 
            this.btn_shootAway.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_shootAway.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_shootAway.Location = new System.Drawing.Point(295, 290);
            this.btn_shootAway.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_shootAway.Name = "btn_shootAway";
            this.btn_shootAway.Size = new System.Drawing.Size(131, 39);
            this.btn_shootAway.TabIndex = 3;
            this.btn_shootAway.Text = "Shoot Away";
            this.btn_shootAway.UseVisualStyleBackColor = false;
            this.btn_shootAway.Click += new System.EventHandler(this.Btn_shootAway_Click);
            // 
            // pic_change_box
            // 
            this.pic_change_box.Image = global::RR_Game.Resource1.start_game;
            this.pic_change_box.Location = new System.Drawing.Point(32, 98);
            this.pic_change_box.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pic_change_box.Name = "pic_change_box";
            this.pic_change_box.Size = new System.Drawing.Size(244, 290);
            this.pic_change_box.TabIndex = 5;
            this.pic_change_box.TabStop = false;
            this.pic_change_box.Click += new System.EventHandler(this.Pic_change_box_Click);
            // 
            // lbl_headline
            // 
            this.lbl_headline.AutoSize = true;
            this.lbl_headline.BackColor = System.Drawing.Color.White;
            this.lbl_headline.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_headline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_headline.Location = new System.Drawing.Point(32, 32);
            this.lbl_headline.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_headline.Name = "lbl_headline";
            this.lbl_headline.Size = new System.Drawing.Size(350, 36);
            this.lbl_headline.TabIndex = 6;
            this.lbl_headline.Text = "Russian Roulette Game";
            // 
            // btn_playAgain
            // 
            this.btn_playAgain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_playAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_playAgain.Location = new System.Drawing.Point(295, 348);
            this.btn_playAgain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_playAgain.Name = "btn_playAgain";
            this.btn_playAgain.Size = new System.Drawing.Size(131, 42);
            this.btn_playAgain.TabIndex = 4;
            this.btn_playAgain.Text = "Play Again";
            this.btn_playAgain.UseVisualStyleBackColor = false;
            this.btn_playAgain.Click += new System.EventHandler(this.Btn_playAgain_Click);
            // 
            // RRGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(463, 430);
            this.Controls.Add(this.lbl_headline);
            this.Controls.Add(this.pic_change_box);
            this.Controls.Add(this.btn_playAgain);
            this.Controls.Add(this.btn_shootAway);
            this.Controls.Add(this.btn_shoot);
            this.Controls.Add(this.btn_spin);
            this.Controls.Add(this.btn_load);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RRGame";
            this.Text = "Russian Roulette Game";
            ((System.ComponentModel.ISupportInitialize)(this.pic_change_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button btn_spin;
        private System.Windows.Forms.Button btn_shoot;
        private System.Windows.Forms.Button btn_shootAway;
        private System.Windows.Forms.PictureBox pic_change_box;
        private System.Windows.Forms.Label lbl_headline;
        private System.Windows.Forms.Button btn_playAgain;
    }
}

