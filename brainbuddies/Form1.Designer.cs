namespace brainbuddies
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
            this.components = new System.ComponentModel.Container();
            this.numbers = new System.Windows.Forms.Button();
            this.games = new System.Windows.Forms.Button();
            this.brainbuddies = new System.Windows.Forms.Label();
            this.exitbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // numbers
            // 
            this.numbers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.numbers.Font = new System.Drawing.Font("Berlin Sans FB", 40F);
            this.numbers.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.numbers.Location = new System.Drawing.Point(54, 510);
            this.numbers.Name = "numbers";
            this.numbers.Size = new System.Drawing.Size(595, 337);
            this.numbers.TabIndex = 0;
            this.numbers.Text = "NUMBERS";
            this.numbers.UseVisualStyleBackColor = false;
            this.numbers.Click += new System.EventHandler(this.numbers_Click);
            // 
            // games
            // 
            this.games.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.games.Font = new System.Drawing.Font("Berlin Sans FB", 40F);
            this.games.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.games.Location = new System.Drawing.Point(711, 510);
            this.games.Name = "games";
            this.games.Size = new System.Drawing.Size(595, 337);
            this.games.TabIndex = 1;
            this.games.Text = "GAMES";
            this.games.UseVisualStyleBackColor = false;
            this.games.Click += new System.EventHandler(this.games_Click);
            // 
            // brainbuddies
            // 
            this.brainbuddies.AutoSize = true;
            this.brainbuddies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.brainbuddies.Font = new System.Drawing.Font("Berlin Sans FB Demi", 60F, System.Drawing.FontStyle.Bold);
            this.brainbuddies.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.brainbuddies.Location = new System.Drawing.Point(91, 288);
            this.brainbuddies.Name = "brainbuddies";
            this.brainbuddies.Size = new System.Drawing.Size(1242, 181);
            this.brainbuddies.TabIndex = 2;
            this.brainbuddies.Text = "BRAIN BUDDIES";
            // 
            // exitbutton
            // 
            this.exitbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.exitbutton.Font = new System.Drawing.Font("Berlin Sans FB", 20F, System.Drawing.FontStyle.Bold);
            this.exitbutton.Location = new System.Drawing.Point(1141, 22);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(165, 85);
            this.exitbutton.TabIndex = 3;
            this.exitbutton.Text = "EXIT";
            this.exitbutton.UseVisualStyleBackColor = false;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 78F);
            this.label1.ForeColor = System.Drawing.Color.LightPink;
            this.label1.Location = new System.Drawing.Point(-35, -11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 239);
            this.label1.TabIndex = 4;
            this.label1.Text = "🧠\r\n";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::brainbuddies.Properties.Resources._11;
            this.pictureBox1.Location = new System.Drawing.Point(249, -116);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 549);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::brainbuddies.Properties.Resources._12;
            this.pictureBox2.Location = new System.Drawing.Point(644, -11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(599, 444);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1524, 905);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.brainbuddies);
            this.Controls.Add(this.games);
            this.Controls.Add(this.numbers);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BRAIN BUDDIES";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button numbers;
        private System.Windows.Forms.Button games;
        private System.Windows.Forms.Label brainbuddies;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

