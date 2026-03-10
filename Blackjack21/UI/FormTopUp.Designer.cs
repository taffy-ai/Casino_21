namespace Blackjack21.UI
{
    partial class FormTopUp
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
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.TxtCardNumber = new System.Windows.Forms.TextBox();
            this.TxtExp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCVV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbAmount = new System.Windows.Forms.ComboBox();
            this.PicLogoCard = new System.Windows.Forms.PictureBox();
            this.btnTopUp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogoCard)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblCardNumber.ForeColor = System.Drawing.Color.White;
            this.lblCardNumber.Location = new System.Drawing.Point(237, 158);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(75, 13);
            this.lblCardNumber.TabIndex = 0;
            this.lblCardNumber.Text = "Card Number: ";
            // 
            // TxtCardNumber
            // 
            this.TxtCardNumber.Location = new System.Drawing.Point(318, 155);
            this.TxtCardNumber.Name = "TxtCardNumber";
            this.TxtCardNumber.Size = new System.Drawing.Size(100, 20);
            this.TxtCardNumber.TabIndex = 1;
            this.TxtCardNumber.TextChanged += new System.EventHandler(this.TxtCardNumber_TextChanged);
            // 
            // TxtExp
            // 
            this.TxtExp.Location = new System.Drawing.Point(345, 186);
            this.TxtExp.Name = "TxtExp";
            this.TxtExp.Size = new System.Drawing.Size(100, 20);
            this.TxtExp.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(237, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Expiration (MM/YY):";
            // 
            // TxtCVV
            // 
            this.TxtCVV.Location = new System.Drawing.Point(318, 215);
            this.TxtCVV.Name = "TxtCVV";
            this.TxtCVV.Size = new System.Drawing.Size(100, 20);
            this.TxtCVV.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(260, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "CVV :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(237, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Amount to add: ";
            // 
            // CmbAmount
            // 
            this.CmbAmount.FormattingEnabled = true;
            this.CmbAmount.Items.AddRange(new object[] {
            "5",
            "10",
            "20",
            "50",
            "100",
            "500",
            "1000"});
            this.CmbAmount.Location = new System.Drawing.Point(324, 248);
            this.CmbAmount.Name = "CmbAmount";
            this.CmbAmount.Size = new System.Drawing.Size(121, 21);
            this.CmbAmount.TabIndex = 8;
            // 
            // PicLogoCard
            // 
            this.PicLogoCard.BackColor = System.Drawing.Color.Transparent;
            this.PicLogoCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PicLogoCard.Location = new System.Drawing.Point(472, 168);
            this.PicLogoCard.Name = "PicLogoCard";
            this.PicLogoCard.Size = new System.Drawing.Size(100, 92);
            this.PicLogoCard.TabIndex = 9;
            this.PicLogoCard.TabStop = false;
            // 
            // btnTopUp
            // 
            this.btnTopUp.Location = new System.Drawing.Point(370, 297);
            this.btnTopUp.Name = "btnTopUp";
            this.btnTopUp.Size = new System.Drawing.Size(75, 23);
            this.btnTopUp.TabIndex = 10;
            this.btnTopUp.Text = "Confirm";
            this.btnTopUp.UseVisualStyleBackColor = true;
            this.btnTopUp.Click += new System.EventHandler(this.btnTopUp_Click);
            // 
            // FormTopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Blackjack21.Properties.Resources.casino_add_funds;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTopUp);
            this.Controls.Add(this.PicLogoCard);
            this.Controls.Add(this.CmbAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtCVV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtExp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtCardNumber);
            this.Controls.Add(this.lblCardNumber);
            this.Name = "FormTopUp";
            this.Text = "FormTopUp";
            ((System.ComponentModel.ISupportInitialize)(this.PicLogoCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.TextBox TxtCardNumber;
        private System.Windows.Forms.TextBox TxtExp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtCVV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbAmount;
        private System.Windows.Forms.PictureBox PicLogoCard;
        private System.Windows.Forms.Button btnTopUp;
    }
}