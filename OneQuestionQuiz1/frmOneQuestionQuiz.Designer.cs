namespace OneQuestionQuiz1
{
    partial class frmFavouriteFoodQuiz
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
            this.lblQustion = new System.Windows.Forms.Label();
            this.grpRadioButtons = new System.Windows.Forms.GroupBox();
            this.rdoSoup = new System.Windows.Forms.RadioButton();
            this.rdoSourCandy = new System.Windows.Forms.RadioButton();
            this.rdoKraftDinner = new System.Windows.Forms.RadioButton();
            this.rdoWaffles = new System.Windows.Forms.RadioButton();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblResult2 = new System.Windows.Forms.Label();
            this.grpRadioButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQustion
            // 
            this.lblQustion.AutoSize = true;
            this.lblQustion.Location = new System.Drawing.Point(26, 13);
            this.lblQustion.Name = "lblQustion";
            this.lblQustion.Size = new System.Drawing.Size(169, 13);
            this.lblQustion.TabIndex = 0;
            this.lblQustion.Text = "What is Amanda\'s Favourite food?";
            this.lblQustion.Click += new System.EventHandler(this.label1_Click);
            // 
            // grpRadioButtons
            // 
            this.grpRadioButtons.Controls.Add(this.rdoSoup);
            this.grpRadioButtons.Controls.Add(this.rdoSourCandy);
            this.grpRadioButtons.Controls.Add(this.rdoKraftDinner);
            this.grpRadioButtons.Controls.Add(this.rdoWaffles);
            this.grpRadioButtons.Location = new System.Drawing.Point(29, 29);
            this.grpRadioButtons.Name = "grpRadioButtons";
            this.grpRadioButtons.Size = new System.Drawing.Size(200, 131);
            this.grpRadioButtons.TabIndex = 1;
            this.grpRadioButtons.TabStop = false;
            this.grpRadioButtons.Enter += new System.EventHandler(this.grpRadioButtons_Enter);
            // 
            // rdoSoup
            // 
            this.rdoSoup.AutoSize = true;
            this.rdoSoup.Location = new System.Drawing.Point(7, 89);
            this.rdoSoup.Name = "rdoSoup";
            this.rdoSoup.Size = new System.Drawing.Size(50, 17);
            this.rdoSoup.TabIndex = 3;
            this.rdoSoup.TabStop = true;
            this.rdoSoup.Text = "Soup";
            this.rdoSoup.UseVisualStyleBackColor = true;
            this.rdoSoup.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // rdoSourCandy
            // 
            this.rdoSourCandy.AutoSize = true;
            this.rdoSourCandy.Location = new System.Drawing.Point(7, 66);
            this.rdoSourCandy.Name = "rdoSourCandy";
            this.rdoSourCandy.Size = new System.Drawing.Size(79, 17);
            this.rdoSourCandy.TabIndex = 2;
            this.rdoSourCandy.TabStop = true;
            this.rdoSourCandy.Text = "Sour candy";
            this.rdoSourCandy.UseVisualStyleBackColor = true;
            this.rdoSourCandy.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rdoKraftDinner
            // 
            this.rdoKraftDinner.AutoSize = true;
            this.rdoKraftDinner.Location = new System.Drawing.Point(7, 43);
            this.rdoKraftDinner.Name = "rdoKraftDinner";
            this.rdoKraftDinner.Size = new System.Drawing.Size(81, 17);
            this.rdoKraftDinner.TabIndex = 1;
            this.rdoKraftDinner.TabStop = true;
            this.rdoKraftDinner.Text = "Kraft Dinner";
            this.rdoKraftDinner.UseVisualStyleBackColor = true;
            this.rdoKraftDinner.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rdoWaffles
            // 
            this.rdoWaffles.AutoSize = true;
            this.rdoWaffles.Location = new System.Drawing.Point(6, 19);
            this.rdoWaffles.Name = "rdoWaffles";
            this.rdoWaffles.Size = new System.Drawing.Size(61, 17);
            this.rdoWaffles.TabIndex = 0;
            this.rdoWaffles.TabStop = true;
            this.rdoWaffles.Text = "Waffles";
            this.rdoWaffles.UseVisualStyleBackColor = true;
            this.rdoWaffles.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblResult.Location = new System.Drawing.Point(180, 233);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 2;
            // 
            // lblResult2
            // 
            this.lblResult2.AutoSize = true;
            this.lblResult2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblResult2.Location = new System.Drawing.Point(180, 233);
            this.lblResult2.Name = "lblResult2";
            this.lblResult2.Size = new System.Drawing.Size(0, 13);
            this.lblResult2.TabIndex = 3;
            // 
            // frmFavouriteFoodQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 408);
            this.Controls.Add(this.lblResult2);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.grpRadioButtons);
            this.Controls.Add(this.lblQustion);
            this.Name = "frmFavouriteFoodQuiz";
            this.Text = "Favourite Food Quiz";
            this.grpRadioButtons.ResumeLayout(false);
            this.grpRadioButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQustion;
        private System.Windows.Forms.GroupBox grpRadioButtons;
        private System.Windows.Forms.RadioButton rdoSourCandy;
        private System.Windows.Forms.RadioButton rdoKraftDinner;
        private System.Windows.Forms.RadioButton rdoWaffles;
        private System.Windows.Forms.RadioButton rdoSoup;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblResult2;
    }
}

