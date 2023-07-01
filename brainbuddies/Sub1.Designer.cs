namespace brainbuddies
{
    partial class Sub1
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
            this.exit = new System.Windows.Forms.Button();
            this.brainbuddies = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.newEquationButton = new System.Windows.Forms.Button();
            this.checkButton = new System.Windows.Forms.Button();
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numberLabel2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numberLabel1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.exit.Font = new System.Drawing.Font("Berlin Sans FB", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(31, 38);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(116, 60);
            this.exit.TabIndex = 33;
            this.exit.Text = "EXIT";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // brainbuddies
            // 
            this.brainbuddies.AutoSize = true;
            this.brainbuddies.Font = new System.Drawing.Font("Berlin Sans FB", 40.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brainbuddies.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.brainbuddies.Location = new System.Drawing.Point(416, 108);
            this.brainbuddies.Name = "brainbuddies";
            this.brainbuddies.Size = new System.Drawing.Size(399, 118);
            this.brainbuddies.TabIndex = 32;
            this.brainbuddies.Text = "LEVEL 1";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Berlin Sans FB Demi", 40F, System.Drawing.FontStyle.Bold);
            this.resultLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.resultLabel.Location = new System.Drawing.Point(97, 649);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(342, 122);
            this.resultLabel.TabIndex = 31;
            this.resultLabel.Text = "label3";
            // 
            // newEquationButton
            // 
            this.newEquationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.newEquationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.newEquationButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.newEquationButton.Location = new System.Drawing.Point(955, 614);
            this.newEquationButton.Margin = new System.Windows.Forms.Padding(0);
            this.newEquationButton.Name = "newEquationButton";
            this.newEquationButton.Size = new System.Drawing.Size(219, 176);
            this.newEquationButton.TabIndex = 30;
            this.newEquationButton.Text = "➡️";
            this.newEquationButton.UseVisualStyleBackColor = false;
            this.newEquationButton.Click += new System.EventHandler(this.newEquationButton_Click);
            // 
            // checkButton
            // 
            this.checkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.checkButton.Font = new System.Drawing.Font("Berlin Sans FB Demi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.checkButton.Location = new System.Drawing.Point(664, 614);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(236, 176);
            this.checkButton.TabIndex = 29;
            this.checkButton.Text = "CHECK";
            this.checkButton.UseVisualStyleBackColor = false;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // answerTextBox
            // 
            this.answerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.answerTextBox.Location = new System.Drawing.Point(772, 336);
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(198, 128);
            this.answerTextBox.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.label2.Location = new System.Drawing.Point(635, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 120);
            this.label2.TabIndex = 27;
            this.label2.Text = "=";
            // 
            // numberLabel2
            // 
            this.numberLabel2.AutoSize = true;
            this.numberLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.numberLabel2.Location = new System.Drawing.Point(478, 339);
            this.numberLabel2.Name = "numberLabel2";
            this.numberLabel2.Size = new System.Drawing.Size(110, 120);
            this.numberLabel2.TabIndex = 26;
            this.numberLabel2.Text = "?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 30F);
            this.label1.Location = new System.Drawing.Point(304, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 88);
            this.label1.TabIndex = 25;
            this.label1.Text = "__";
            // 
            // numberLabel1
            // 
            this.numberLabel1.AutoSize = true;
            this.numberLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.numberLabel1.Location = new System.Drawing.Point(118, 344);
            this.numberLabel1.Name = "numberLabel1";
            this.numberLabel1.Size = new System.Drawing.Size(110, 120);
            this.numberLabel1.TabIndex = 24;
            this.numberLabel1.Text = "?";
            // 
            // Sub1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1259, 864);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.brainbuddies);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.newEquationButton);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.answerTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numberLabel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberLabel1);
            this.Name = "Sub1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LEVEL 1 - Subtraction";
            this.Load += new System.EventHandler(this.Sub1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label brainbuddies;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button newEquationButton;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.TextBox answerTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label numberLabel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label numberLabel1;
    }
}