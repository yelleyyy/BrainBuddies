namespace brainbuddies
{
    partial class Games
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
            this.hangman = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tictactoe = new System.Windows.Forms.Button();
            this.home = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // hangman
            // 
            this.hangman.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.hangman.Font = new System.Drawing.Font("Berlin Sans FB Demi", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hangman.Location = new System.Drawing.Point(300, 156);
            this.hangman.Name = "hangman";
            this.hangman.Size = new System.Drawing.Size(805, 307);
            this.hangman.TabIndex = 0;
            this.hangman.Text = "HANGMAN";
            this.hangman.UseVisualStyleBackColor = false;
            this.hangman.Click += new System.EventHandler(this.hangman_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cooper Black", 350F);
            this.label5.ForeColor = System.Drawing.Color.LightPink;
            this.label5.Location = new System.Drawing.Point(-18, -47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1537, 1071);
            this.label5.TabIndex = 15;
            this.label5.Text = "🧠\r\n";
            // 
            // tictactoe
            // 
            this.tictactoe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tictactoe.Font = new System.Drawing.Font("Berlin Sans FB Demi", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tictactoe.Location = new System.Drawing.Point(300, 535);
            this.tictactoe.Name = "tictactoe";
            this.tictactoe.Size = new System.Drawing.Size(805, 307);
            this.tictactoe.TabIndex = 16;
            this.tictactoe.Text = "TIC TAC TOE";
            this.tictactoe.UseVisualStyleBackColor = false;
            this.tictactoe.Click += new System.EventHandler(this.tictactoe_Click);
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.Color.Silver;
            this.home.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Bold);
            this.home.Location = new System.Drawing.Point(23, 23);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(194, 110);
            this.home.TabIndex = 17;
            this.home.Text = "HOME";
            this.home.UseVisualStyleBackColor = false;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::brainbuddies.Properties.Resources._1;
            this.pictureBox1.Location = new System.Drawing.Point(1161, 438);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 288);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::brainbuddies.Properties.Resources._13;
            this.pictureBox2.Location = new System.Drawing.Point(12, 139);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(260, 263);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::brainbuddies.Properties.Resources._7;
            this.pictureBox3.Location = new System.Drawing.Point(14, 634);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(280, 268);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::brainbuddies.Properties.Resources._15;
            this.pictureBox4.Location = new System.Drawing.Point(1111, -32);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(288, 364);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            // 
            // Games
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1455, 976);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.home);
            this.Controls.Add(this.tictactoe);
            this.Controls.Add(this.hangman);
            this.Controls.Add(this.label5);
            this.Name = "Games";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Games";
            this.Load += new System.EventHandler(this.Games_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hangman;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button tictactoe;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}