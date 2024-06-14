namespace TypingTutor
{
    partial class ChooseTheDifficultyForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonHard = new System.Windows.Forms.Button();
            this.buttonMiddle = new System.Windows.Forms.Button();
            this.buttonEasy = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.buttonHard);
            this.panel1.Controls.Add(this.buttonMiddle);
            this.panel1.Controls.Add(this.buttonEasy);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 180);
            this.panel1.TabIndex = 0;
            // 
            // buttonHard
            // 
            this.buttonHard.BackColor = System.Drawing.Color.Red;
            this.buttonHard.Location = new System.Drawing.Point(388, 58);
            this.buttonHard.Name = "buttonHard";
            this.buttonHard.Size = new System.Drawing.Size(138, 64);
            this.buttonHard.TabIndex = 2;
            this.buttonHard.Text = "Hard";
            this.buttonHard.UseVisualStyleBackColor = false;
            this.buttonHard.Click += new System.EventHandler(this.buttonHard_Click);
            // 
            // buttonMiddle
            // 
            this.buttonMiddle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonMiddle.Location = new System.Drawing.Point(210, 58);
            this.buttonMiddle.Name = "buttonMiddle";
            this.buttonMiddle.Size = new System.Drawing.Size(138, 64);
            this.buttonMiddle.TabIndex = 1;
            this.buttonMiddle.Text = "Middle";
            this.buttonMiddle.UseVisualStyleBackColor = false;
            this.buttonMiddle.Click += new System.EventHandler(this.buttonMiddle_Click);
            // 
            // buttonEasy
            // 
            this.buttonEasy.BackColor = System.Drawing.Color.Cyan;
            this.buttonEasy.Location = new System.Drawing.Point(30, 58);
            this.buttonEasy.Name = "buttonEasy";
            this.buttonEasy.Size = new System.Drawing.Size(138, 64);
            this.buttonEasy.TabIndex = 0;
            this.buttonEasy.Text = "Easy";
            this.buttonEasy.UseVisualStyleBackColor = false;
            this.buttonEasy.Click += new System.EventHandler(this.buttonEasy_Click);
            // 
            // ChooseTheDifficultyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(613, 215);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ChooseTheDifficultyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose The Difficulty ";
            this.Load += new System.EventHandler(this.ChooseTheDifficultyForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonHard;
        private System.Windows.Forms.Button buttonMiddle;
        private System.Windows.Forms.Button buttonEasy;
    }
}