namespace brainbuddies
{
    partial class Hangman
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
            this.buttonGuess = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.textBoxGuess = new System.Windows.Forms.TextBox();
            this.brainbuddies = new System.Windows.Forms.Label();
            this.home = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.guessedLetterLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonGuess
            // 
            this.buttonGuess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonGuess.Font = new System.Drawing.Font("Britannic Bold", 30F);
            this.buttonGuess.Location = new System.Drawing.Point(768, 678);
            this.buttonGuess.Name = "buttonGuess";
            this.buttonGuess.Size = new System.Drawing.Size(345, 155);
            this.buttonGuess.TabIndex = 0;
            this.buttonGuess.Text = "Guess";
            this.buttonGuess.UseVisualStyleBackColor = false;
            this.buttonGuess.Click += new System.EventHandler(this.buttonGuess_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Berlin Sans FB", 38F);
            this.labelStatus.Location = new System.Drawing.Point(126, 314);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelStatus.Size = new System.Drawing.Size(254, 112);
            this.labelStatus.TabIndex = 1;
            this.labelStatus.Text = "label";
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxGuess
            // 
            this.textBoxGuess.Font = new System.Drawing.Font("Berlin Sans FB Demi", 36F, System.Drawing.FontStyle.Bold);
            this.textBoxGuess.Location = new System.Drawing.Point(525, 689);
            this.textBoxGuess.Name = "textBoxGuess";
            this.textBoxGuess.Size = new System.Drawing.Size(192, 116);
            this.textBoxGuess.TabIndex = 2;
            // 
            // brainbuddies
            // 
            this.brainbuddies.AutoSize = true;
            this.brainbuddies.Font = new System.Drawing.Font("Berlin Sans FB", 40.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brainbuddies.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.brainbuddies.Location = new System.Drawing.Point(300, 92);
            this.brainbuddies.Name = "brainbuddies";
            this.brainbuddies.Size = new System.Drawing.Size(579, 118);
            this.brainbuddies.TabIndex = 33;
            this.brainbuddies.Text = "HANGMAN";
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.home.Font = new System.Drawing.Font("Berlin Sans FB", 14F, System.Drawing.FontStyle.Bold);
            this.home.Location = new System.Drawing.Point(1029, 25);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(152, 87);
            this.home.TabIndex = 34;
            this.home.Text = "EXIT";
            this.home.UseVisualStyleBackColor = false;
            this.home.Click += new System.EventHandler(this.home_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 26F);
            this.label1.Location = new System.Drawing.Point(84, 707);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 77);
            this.label1.TabIndex = 56;
            this.label1.Text = "Type a letter:";
            // 
            // guessedLetterLabel
            // 
            this.guessedLetterLabel.AutoSize = true;
            this.guessedLetterLabel.Font = new System.Drawing.Font("Berlin Sans FB", 18F);
            this.guessedLetterLabel.Location = new System.Drawing.Point(155, 511);
            this.guessedLetterLabel.Name = "guessedLetterLabel";
            this.guessedLetterLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.guessedLetterLabel.Size = new System.Drawing.Size(122, 54);
            this.guessedLetterLabel.TabIndex = 57;
            this.guessedLetterLabel.Text = "label";
            this.guessedLetterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Hangman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1217, 910);
            this.Controls.Add(this.guessedLetterLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.home);
            this.Controls.Add(this.brainbuddies);
            this.Controls.Add(this.textBoxGuess);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.buttonGuess);
            this.Name = "Hangman";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hangman";
            this.Load += new System.EventHandler(this.Hangman_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGuess;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.TextBox textBoxGuess;
        private System.Windows.Forms.Label brainbuddies;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label guessedLetterLabel;
    }
}