namespace Program2
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
            this.programTitleLbl = new System.Windows.Forms.Label();
            this.ageLbl = new System.Windows.Forms.Label();
            this.carValueLbl = new System.Windows.Forms.Label();
            this.healthCovLbl = new System.Windows.Forms.Label();
            this.smokeLbl = new System.Windows.Forms.Label();
            this.accidentLbl = new System.Windows.Forms.Label();
            this.carCovLbl = new System.Windows.Forms.Label();
            this.calcBtn = new System.Windows.Forms.Button();
            this.healthCostLbl = new System.Windows.Forms.Label();
            this.carCostLbl = new System.Windows.Forms.Label();
            this.totalCostLbl = new System.Windows.Forms.Label();
            this.annualHealthCost = new System.Windows.Forms.Label();
            this.annualCarCost = new System.Windows.Forms.Label();
            this.annualPolicyCost = new System.Windows.Forms.Label();
            this.smokeBtn1 = new System.Windows.Forms.RadioButton();
            this.smokeBtn2 = new System.Windows.Forms.RadioButton();
            this.accidentBtn1 = new System.Windows.Forms.RadioButton();
            this.accidentBtn2 = new System.Windows.Forms.RadioButton();
            this.ageTxtBox = new System.Windows.Forms.TextBox();
            this.carValueTxt = new System.Windows.Forms.TextBox();
            this.healthCovCombo = new System.Windows.Forms.ComboBox();
            this.carComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // programTitleLbl
            // 
            this.programTitleLbl.AutoSize = true;
            this.programTitleLbl.Location = new System.Drawing.Point(195, 20);
            this.programTitleLbl.Name = "programTitleLbl";
            this.programTitleLbl.Size = new System.Drawing.Size(365, 25);
            this.programTitleLbl.TabIndex = 0;
            this.programTitleLbl.Text = "Cardinal Insurance Policy Calculator:";
            // 
            // ageLbl
            // 
            this.ageLbl.AutoSize = true;
            this.ageLbl.Location = new System.Drawing.Point(127, 104);
            this.ageLbl.Name = "ageLbl";
            this.ageLbl.Size = new System.Drawing.Size(165, 25);
            this.ageLbl.TabIndex = 1;
            this.ageLbl.Text = "Enter Your Age:";
            // 
            // carValueLbl
            // 
            this.carValueLbl.AutoSize = true;
            this.carValueLbl.Location = new System.Drawing.Point(127, 184);
            this.carValueLbl.Name = "carValueLbl";
            this.carValueLbl.Size = new System.Drawing.Size(238, 25);
            this.carValueLbl.TabIndex = 2;
            this.carValueLbl.Text = "Estimated Value of Car:";
            // 
            // healthCovLbl
            // 
            this.healthCovLbl.AutoSize = true;
            this.healthCovLbl.Location = new System.Drawing.Point(127, 274);
            this.healthCovLbl.Name = "healthCovLbl";
            this.healthCovLbl.Size = new System.Drawing.Size(279, 25);
            this.healthCovLbl.TabIndex = 3;
            this.healthCovLbl.Text = "Health Insurance Coverage:";
            // 
            // smokeLbl
            // 
            this.smokeLbl.AutoSize = true;
            this.smokeLbl.Location = new System.Drawing.Point(127, 458);
            this.smokeLbl.Name = "smokeLbl";
            this.smokeLbl.Size = new System.Drawing.Size(168, 25);
            this.smokeLbl.TabIndex = 4;
            this.smokeLbl.Text = "Do You Smoke?";
            // 
            // accidentLbl
            // 
            this.accidentLbl.AutoSize = true;
            this.accidentLbl.Location = new System.Drawing.Point(127, 596);
            this.accidentLbl.Name = "accidentLbl";
            this.accidentLbl.Size = new System.Drawing.Size(307, 25);
            this.accidentLbl.TabIndex = 5;
            this.accidentLbl.Text = "Car Accident in the Past Year?";
            // 
            // carCovLbl
            // 
            this.carCovLbl.AutoSize = true;
            this.carCovLbl.Location = new System.Drawing.Point(127, 360);
            this.carCovLbl.Name = "carCovLbl";
            this.carCovLbl.Size = new System.Drawing.Size(251, 25);
            this.carCovLbl.TabIndex = 6;
            this.carCovLbl.Text = "Car Insurance Coverage:";
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(216, 718);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(306, 45);
            this.calcBtn.TabIndex = 7;
            this.calcBtn.Text = "Calculate Policy Premiums";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // healthCostLbl
            // 
            this.healthCostLbl.AutoSize = true;
            this.healthCostLbl.Location = new System.Drawing.Point(88, 798);
            this.healthCostLbl.Name = "healthCostLbl";
            this.healthCostLbl.Size = new System.Drawing.Size(318, 25);
            this.healthCostLbl.TabIndex = 8;
            this.healthCostLbl.Text = "Health Coverage Cost per Year:";
            // 
            // carCostLbl
            // 
            this.carCostLbl.AutoSize = true;
            this.carCostLbl.Location = new System.Drawing.Point(116, 866);
            this.carCostLbl.Name = "carCostLbl";
            this.carCostLbl.Size = new System.Drawing.Size(290, 25);
            this.carCostLbl.TabIndex = 9;
            this.carCostLbl.Text = "Car Coverage Cost per Year:";
            // 
            // totalCostLbl
            // 
            this.totalCostLbl.AutoSize = true;
            this.totalCostLbl.Location = new System.Drawing.Point(127, 934);
            this.totalCostLbl.Name = "totalCostLbl";
            this.totalCostLbl.Size = new System.Drawing.Size(269, 25);
            this.totalCostLbl.TabIndex = 10;
            this.totalCostLbl.Text = "Total Policy Cost per Year:";
            // 
            // annualHealthCost
            // 
            this.annualHealthCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.annualHealthCost.Location = new System.Drawing.Point(467, 797);
            this.annualHealthCost.Name = "annualHealthCost";
            this.annualHealthCost.Size = new System.Drawing.Size(158, 35);
            this.annualHealthCost.TabIndex = 11;
            // 
            // annualCarCost
            // 
            this.annualCarCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.annualCarCost.Location = new System.Drawing.Point(467, 866);
            this.annualCarCost.Name = "annualCarCost";
            this.annualCarCost.Size = new System.Drawing.Size(160, 33);
            this.annualCarCost.TabIndex = 12;
            // 
            // annualPolicyCost
            // 
            this.annualPolicyCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.annualPolicyCost.Location = new System.Drawing.Point(467, 934);
            this.annualPolicyCost.Name = "annualPolicyCost";
            this.annualPolicyCost.Size = new System.Drawing.Size(160, 36);
            this.annualPolicyCost.TabIndex = 13;
            // 
            // smokeBtn1
            // 
            this.smokeBtn1.AutoSize = true;
            this.smokeBtn1.Location = new System.Drawing.Point(467, 458);
            this.smokeBtn1.Name = "smokeBtn1";
            this.smokeBtn1.Size = new System.Drawing.Size(81, 29);
            this.smokeBtn1.TabIndex = 14;
            this.smokeBtn1.TabStop = true;
            this.smokeBtn1.Text = "Yes";
            this.smokeBtn1.UseVisualStyleBackColor = true;
            // 
            // smokeBtn2
            // 
            this.smokeBtn2.AutoSize = true;
            this.smokeBtn2.Location = new System.Drawing.Point(467, 514);
            this.smokeBtn2.Name = "smokeBtn2";
            this.smokeBtn2.Size = new System.Drawing.Size(70, 29);
            this.smokeBtn2.TabIndex = 15;
            this.smokeBtn2.TabStop = true;
            this.smokeBtn2.Text = "No";
            this.smokeBtn2.UseVisualStyleBackColor = true;
            // 
            // accidentBtn1
            // 
            this.accidentBtn1.AutoSize = true;
            this.accidentBtn1.Location = new System.Drawing.Point(467, 596);
            this.accidentBtn1.Name = "accidentBtn1";
            this.accidentBtn1.Size = new System.Drawing.Size(81, 29);
            this.accidentBtn1.TabIndex = 16;
            this.accidentBtn1.TabStop = true;
            this.accidentBtn1.Text = "Yes";
            this.accidentBtn1.UseVisualStyleBackColor = true;
            // 
            // accidentBtn2
            // 
            this.accidentBtn2.AutoSize = true;
            this.accidentBtn2.Location = new System.Drawing.Point(467, 650);
            this.accidentBtn2.Name = "accidentBtn2";
            this.accidentBtn2.Size = new System.Drawing.Size(70, 29);
            this.accidentBtn2.TabIndex = 17;
            this.accidentBtn2.TabStop = true;
            this.accidentBtn2.Text = "No";
            this.accidentBtn2.UseVisualStyleBackColor = true;
            // 
            // ageTxtBox
            // 
            this.ageTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ageTxtBox.Location = new System.Drawing.Point(467, 101);
            this.ageTxtBox.Name = "ageTxtBox";
            this.ageTxtBox.Size = new System.Drawing.Size(174, 31);
            this.ageTxtBox.TabIndex = 18;
            // 
            // carValueTxt
            // 
            this.carValueTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.carValueTxt.Location = new System.Drawing.Point(467, 181);
            this.carValueTxt.Name = "carValueTxt";
            this.carValueTxt.Size = new System.Drawing.Size(174, 31);
            this.carValueTxt.TabIndex = 19;
            // 
            // healthCovCombo
            // 
            this.healthCovCombo.FormattingEnabled = true;
            this.healthCovCombo.Items.AddRange(new object[] {
            "Medical",
            "Dental",
            "VIsion"});
            this.healthCovCombo.Location = new System.Drawing.Point(467, 271);
            this.healthCovCombo.Name = "healthCovCombo";
            this.healthCovCombo.Size = new System.Drawing.Size(174, 33);
            this.healthCovCombo.TabIndex = 20;
            // 
            // carComboBox
            // 
            this.carComboBox.FormattingEnabled = true;
            this.carComboBox.Items.AddRange(new object[] {
            "Full",
            "Liability"});
            this.carComboBox.Location = new System.Drawing.Point(467, 360);
            this.carComboBox.Name = "carComboBox";
            this.carComboBox.Size = new System.Drawing.Size(174, 33);
            this.carComboBox.TabIndex = 21;
            // 
            // Form1
            // 
            this.AcceptButton = this.calcBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 994);
            this.Controls.Add(this.carComboBox);
            this.Controls.Add(this.healthCovCombo);
            this.Controls.Add(this.carValueTxt);
            this.Controls.Add(this.ageTxtBox);
            this.Controls.Add(this.accidentBtn2);
            this.Controls.Add(this.accidentBtn1);
            this.Controls.Add(this.smokeBtn2);
            this.Controls.Add(this.smokeBtn1);
            this.Controls.Add(this.annualPolicyCost);
            this.Controls.Add(this.annualCarCost);
            this.Controls.Add(this.annualHealthCost);
            this.Controls.Add(this.totalCostLbl);
            this.Controls.Add(this.carCostLbl);
            this.Controls.Add(this.healthCostLbl);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.carCovLbl);
            this.Controls.Add(this.accidentLbl);
            this.Controls.Add(this.smokeLbl);
            this.Controls.Add(this.healthCovLbl);
            this.Controls.Add(this.carValueLbl);
            this.Controls.Add(this.ageLbl);
            this.Controls.Add(this.programTitleLbl);
            this.Name = "Form1";
            this.Text = "Insurance Policy Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label programTitleLbl;
        private System.Windows.Forms.Label ageLbl;
        private System.Windows.Forms.Label carValueLbl;
        private System.Windows.Forms.Label healthCovLbl;
        private System.Windows.Forms.Label smokeLbl;
        private System.Windows.Forms.Label accidentLbl;
        private System.Windows.Forms.Label carCovLbl;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.Label healthCostLbl;
        private System.Windows.Forms.Label carCostLbl;
        private System.Windows.Forms.Label totalCostLbl;
        private System.Windows.Forms.Label annualHealthCost;
        private System.Windows.Forms.Label annualCarCost;
        private System.Windows.Forms.Label annualPolicyCost;
        private System.Windows.Forms.RadioButton smokeBtn1;
        private System.Windows.Forms.RadioButton smokeBtn2;
        private System.Windows.Forms.RadioButton accidentBtn1;
        private System.Windows.Forms.RadioButton accidentBtn2;
        private System.Windows.Forms.TextBox ageTxtBox;
        private System.Windows.Forms.TextBox carValueTxt;
        private System.Windows.Forms.ComboBox healthCovCombo;
        private System.Windows.Forms.ComboBox carComboBox;
    }
}

