namespace Program3
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
            this.formTitleLbl = new System.Windows.Forms.Label();
            this.providerLbl = new System.Windows.Forms.Label();
            this.businessLbl = new System.Windows.Forms.Label();
            this.contractLengthLbl = new System.Windows.Forms.Label();
            this.calcBtn = new System.Windows.Forms.Button();
            this.providerCombo = new System.Windows.Forms.ComboBox();
            this.businessCombo = new System.Windows.Forms.ComboBox();
            this.contractCombo = new System.Windows.Forms.ComboBox();
            this.shippingProviderLbl = new System.Windows.Forms.Label();
            this.contractPriceLbl = new System.Windows.Forms.Label();
            this.companyDiscountLbl = new System.Windows.Forms.Label();
            this.lengthDiscountLbl = new System.Windows.Forms.Label();
            this.providerOutput = new System.Windows.Forms.Label();
            this.contractOutput = new System.Windows.Forms.Label();
            this.compDiscOutput = new System.Windows.Forms.Label();
            this.lengthDiscOutput = new System.Windows.Forms.Label();
            this.finalPriceLbl = new System.Windows.Forms.Label();
            this.finalPriceOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // formTitleLbl
            // 
            this.formTitleLbl.AutoSize = true;
            this.formTitleLbl.Location = new System.Drawing.Point(195, 76);
            this.formTitleLbl.Name = "formTitleLbl";
            this.formTitleLbl.Size = new System.Drawing.Size(286, 25);
            this.formTitleLbl.TabIndex = 0;
            this.formTitleLbl.Text = "Shipping Contract Calculator";
            // 
            // providerLbl
            // 
            this.providerLbl.AutoSize = true;
            this.providerLbl.Location = new System.Drawing.Point(212, 145);
            this.providerLbl.Name = "providerLbl";
            this.providerLbl.Size = new System.Drawing.Size(98, 25);
            this.providerLbl.TabIndex = 1;
            this.providerLbl.Text = "Provider:";
            // 
            // businessLbl
            // 
            this.businessLbl.AutoSize = true;
            this.businessLbl.Location = new System.Drawing.Point(204, 217);
            this.businessLbl.Name = "businessLbl";
            this.businessLbl.Size = new System.Drawing.Size(106, 25);
            this.businessLbl.TabIndex = 2;
            this.businessLbl.Text = "Business:";
            // 
            // contractLengthLbl
            // 
            this.contractLengthLbl.AutoSize = true;
            this.contractLengthLbl.Location = new System.Drawing.Point(139, 293);
            this.contractLengthLbl.Name = "contractLengthLbl";
            this.contractLengthLbl.Size = new System.Drawing.Size(171, 25);
            this.contractLengthLbl.TabIndex = 3;
            this.contractLengthLbl.Text = "Contract Length:";
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(276, 379);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(131, 41);
            this.calcBtn.TabIndex = 4;
            this.calcBtn.Text = "Calculate";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // providerCombo
            // 
            this.providerCombo.FormattingEnabled = true;
            this.providerCombo.Items.AddRange(new object[] {
            "USPS",
            "DHL",
            "FedEx",
            "UPS"});
            this.providerCombo.Location = new System.Drawing.Point(330, 145);
            this.providerCombo.Name = "providerCombo";
            this.providerCombo.Size = new System.Drawing.Size(121, 33);
            this.providerCombo.TabIndex = 5;
            // 
            // businessCombo
            // 
            this.businessCombo.FormattingEnabled = true;
            this.businessCombo.Items.AddRange(new object[] {
            "John\'s Books",
            "Office Supplies",
            "J.B. Car Parts",
            "Gevalia Coffee",
            "Ceylon Tea",
            "My Footwear"});
            this.businessCombo.Location = new System.Drawing.Point(330, 217);
            this.businessCombo.Name = "businessCombo";
            this.businessCombo.Size = new System.Drawing.Size(121, 33);
            this.businessCombo.TabIndex = 6;
            // 
            // contractCombo
            // 
            this.contractCombo.FormattingEnabled = true;
            this.contractCombo.Items.AddRange(new object[] {
            "0",
            "2",
            "5",
            "8"});
            this.contractCombo.Location = new System.Drawing.Point(330, 293);
            this.contractCombo.Name = "contractCombo";
            this.contractCombo.Size = new System.Drawing.Size(121, 33);
            this.contractCombo.TabIndex = 7;
            // 
            // shippingProviderLbl
            // 
            this.shippingProviderLbl.AutoSize = true;
            this.shippingProviderLbl.Location = new System.Drawing.Point(146, 530);
            this.shippingProviderLbl.Name = "shippingProviderLbl";
            this.shippingProviderLbl.Size = new System.Drawing.Size(194, 25);
            this.shippingProviderLbl.TabIndex = 8;
            this.shippingProviderLbl.Text = "Shipping Provider: ";
            // 
            // contractPriceLbl
            // 
            this.contractPriceLbl.AutoSize = true;
            this.contractPriceLbl.Location = new System.Drawing.Point(121, 594);
            this.contractPriceLbl.Name = "contractPriceLbl";
            this.contractPriceLbl.Size = new System.Drawing.Size(210, 25);
            this.contractPriceLbl.TabIndex = 9;
            this.contractPriceLbl.Text = "Initial Contract Price:";
            // 
            // companyDiscountLbl
            // 
            this.companyDiscountLbl.AutoSize = true;
            this.companyDiscountLbl.Location = new System.Drawing.Point(132, 661);
            this.companyDiscountLbl.Name = "companyDiscountLbl";
            this.companyDiscountLbl.Size = new System.Drawing.Size(199, 25);
            this.companyDiscountLbl.TabIndex = 10;
            this.companyDiscountLbl.Text = "Company Discount:";
            // 
            // lengthDiscountLbl
            // 
            this.lengthDiscountLbl.AutoSize = true;
            this.lengthDiscountLbl.Location = new System.Drawing.Point(157, 723);
            this.lengthDiscountLbl.Name = "lengthDiscountLbl";
            this.lengthDiscountLbl.Size = new System.Drawing.Size(174, 25);
            this.lengthDiscountLbl.TabIndex = 11;
            this.lengthDiscountLbl.Text = "Length Discount:";
            // 
            // providerOutput
            // 
            this.providerOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.providerOutput.Location = new System.Drawing.Point(337, 529);
            this.providerOutput.Name = "providerOutput";
            this.providerOutput.Size = new System.Drawing.Size(175, 39);
            this.providerOutput.TabIndex = 12;
            // 
            // contractOutput
            // 
            this.contractOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contractOutput.Location = new System.Drawing.Point(337, 593);
            this.contractOutput.Name = "contractOutput";
            this.contractOutput.Size = new System.Drawing.Size(175, 38);
            this.contractOutput.TabIndex = 13;
            // 
            // compDiscOutput
            // 
            this.compDiscOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.compDiscOutput.Location = new System.Drawing.Point(337, 661);
            this.compDiscOutput.Name = "compDiscOutput";
            this.compDiscOutput.Size = new System.Drawing.Size(175, 38);
            this.compDiscOutput.TabIndex = 14;
            // 
            // lengthDiscOutput
            // 
            this.lengthDiscOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lengthDiscOutput.Location = new System.Drawing.Point(337, 722);
            this.lengthDiscOutput.Name = "lengthDiscOutput";
            this.lengthDiscOutput.Size = new System.Drawing.Size(175, 40);
            this.lengthDiscOutput.TabIndex = 15;
            // 
            // finalPriceLbl
            // 
            this.finalPriceLbl.AutoSize = true;
            this.finalPriceLbl.Location = new System.Drawing.Point(204, 779);
            this.finalPriceLbl.Name = "finalPriceLbl";
            this.finalPriceLbl.Size = new System.Drawing.Size(120, 25);
            this.finalPriceLbl.TabIndex = 16;
            this.finalPriceLbl.Text = "Final Price:";
            // 
            // finalPriceOutput
            // 
            this.finalPriceOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.finalPriceOutput.Location = new System.Drawing.Point(337, 778);
            this.finalPriceOutput.Name = "finalPriceOutput";
            this.finalPriceOutput.Size = new System.Drawing.Size(175, 40);
            this.finalPriceOutput.TabIndex = 17;
            // 
            // Form1
            // 
            this.AcceptButton = this.calcBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 907);
            this.Controls.Add(this.finalPriceOutput);
            this.Controls.Add(this.finalPriceLbl);
            this.Controls.Add(this.lengthDiscOutput);
            this.Controls.Add(this.compDiscOutput);
            this.Controls.Add(this.contractOutput);
            this.Controls.Add(this.providerOutput);
            this.Controls.Add(this.lengthDiscountLbl);
            this.Controls.Add(this.companyDiscountLbl);
            this.Controls.Add(this.contractPriceLbl);
            this.Controls.Add(this.shippingProviderLbl);
            this.Controls.Add(this.contractCombo);
            this.Controls.Add(this.businessCombo);
            this.Controls.Add(this.providerCombo);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.contractLengthLbl);
            this.Controls.Add(this.businessLbl);
            this.Controls.Add(this.providerLbl);
            this.Controls.Add(this.formTitleLbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label formTitleLbl;
        private System.Windows.Forms.Label providerLbl;
        private System.Windows.Forms.Label businessLbl;
        private System.Windows.Forms.Label contractLengthLbl;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.ComboBox providerCombo;
        private System.Windows.Forms.ComboBox businessCombo;
        private System.Windows.Forms.ComboBox contractCombo;
        private System.Windows.Forms.Label shippingProviderLbl;
        private System.Windows.Forms.Label contractPriceLbl;
        private System.Windows.Forms.Label companyDiscountLbl;
        private System.Windows.Forms.Label lengthDiscountLbl;
        private System.Windows.Forms.Label providerOutput;
        private System.Windows.Forms.Label contractOutput;
        private System.Windows.Forms.Label compDiscOutput;
        private System.Windows.Forms.Label lengthDiscOutput;
        private System.Windows.Forms.Label finalPriceLbl;
        private System.Windows.Forms.Label finalPriceOutput;
    }
}

