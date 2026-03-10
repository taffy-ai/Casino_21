namespace Blackjack21.UI
{
    partial class FormPlay
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
            this.flpPlayerCards = new System.Windows.Forms.FlowLayoutPanel();
            this.flpDealerCards = new System.Windows.Forms.FlowLayoutPanel();
            this.LblPlayerScore = new System.Windows.Forms.Label();
            this.LblDealerScore = new System.Windows.Forms.Label();
            this.BtnHit = new System.Windows.Forms.Button();
            this.BtnStand = new System.Windows.Forms.Button();
            this.LblWelcome = new System.Windows.Forms.Label();
            this.BtnDeal = new System.Windows.Forms.Button();
            this.lblMise = new System.Windows.Forms.Label();
            this.lblMiseModif = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.LblBalance = new System.Windows.Forms.Label();
            this.lblGain = new System.Windows.Forms.Label();
            this.BtnTopUp = new System.Windows.Forms.Button();
            this.PicChip1 = new System.Windows.Forms.PictureBox();
            this.PicChip2 = new System.Windows.Forms.PictureBox();
            this.PicChip3 = new System.Windows.Forms.PictureBox();
            this.PicChip4 = new System.Windows.Forms.PictureBox();
            this.PicChip5 = new System.Windows.Forms.PictureBox();
            this.PicChip6 = new System.Windows.Forms.PictureBox();
            this.PicFireworks = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicChip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicChip2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicChip3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicChip4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicChip5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicChip6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicFireworks)).BeginInit();
            this.SuspendLayout();
            // 
            // flpPlayerCards
            // 
            this.flpPlayerCards.BackColor = System.Drawing.Color.Transparent;
            this.flpPlayerCards.Location = new System.Drawing.Point(437, 406);
            this.flpPlayerCards.Name = "flpPlayerCards";
            this.flpPlayerCards.Size = new System.Drawing.Size(389, 158);
            this.flpPlayerCards.TabIndex = 0;
            this.flpPlayerCards.WrapContents = false;
            // 
            // flpDealerCards
            // 
            this.flpDealerCards.BackColor = System.Drawing.Color.Transparent;
            this.flpDealerCards.Location = new System.Drawing.Point(437, 21);
            this.flpDealerCards.Name = "flpDealerCards";
            this.flpDealerCards.Size = new System.Drawing.Size(389, 159);
            this.flpDealerCards.TabIndex = 1;
            this.flpDealerCards.WrapContents = false;
            // 
            // LblPlayerScore
            // 
            this.LblPlayerScore.AutoSize = true;
            this.LblPlayerScore.BackColor = System.Drawing.Color.Transparent;
            this.LblPlayerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPlayerScore.ForeColor = System.Drawing.Color.White;
            this.LblPlayerScore.Location = new System.Drawing.Point(860, 358);
            this.LblPlayerScore.Name = "LblPlayerScore";
            this.LblPlayerScore.Size = new System.Drawing.Size(191, 29);
            this.LblPlayerScore.TabIndex = 2;
            this.LblPlayerScore.Text = "Player Score: 0";
            // 
            // LblDealerScore
            // 
            this.LblDealerScore.AutoSize = true;
            this.LblDealerScore.BackColor = System.Drawing.Color.Transparent;
            this.LblDealerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDealerScore.ForeColor = System.Drawing.Color.White;
            this.LblDealerScore.Location = new System.Drawing.Point(860, 12);
            this.LblDealerScore.Name = "LblDealerScore";
            this.LblDealerScore.Size = new System.Drawing.Size(195, 29);
            this.LblDealerScore.TabIndex = 3;
            this.LblDealerScore.Text = "Dealer Score: 0";
            // 
            // BtnHit
            // 
            this.BtnHit.BackColor = System.Drawing.Color.Black;
            this.BtnHit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnHit.FlatAppearance.BorderSize = 0;
            this.BtnHit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHit.ForeColor = System.Drawing.Color.Gold;
            this.BtnHit.Location = new System.Drawing.Point(406, 698);
            this.BtnHit.Name = "BtnHit";
            this.BtnHit.Size = new System.Drawing.Size(120, 50);
            this.BtnHit.TabIndex = 4;
            this.BtnHit.Text = "Hit";
            this.BtnHit.UseVisualStyleBackColor = false;
            this.BtnHit.Click += new System.EventHandler(this.BtnHit_Click);
            // 
            // BtnStand
            // 
            this.BtnStand.BackColor = System.Drawing.Color.Black;
            this.BtnStand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnStand.FlatAppearance.BorderSize = 0;
            this.BtnStand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStand.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStand.ForeColor = System.Drawing.Color.Gold;
            this.BtnStand.Location = new System.Drawing.Point(744, 698);
            this.BtnStand.Name = "BtnStand";
            this.BtnStand.Size = new System.Drawing.Size(120, 50);
            this.BtnStand.TabIndex = 5;
            this.BtnStand.Text = "Stand";
            this.BtnStand.UseVisualStyleBackColor = false;
            this.BtnStand.Click += new System.EventHandler(this.BtnStand_Click);
            // 
            // LblWelcome
            // 
            this.LblWelcome.AutoSize = true;
            this.LblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.LblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWelcome.ForeColor = System.Drawing.Color.White;
            this.LblWelcome.Location = new System.Drawing.Point(12, 9);
            this.LblWelcome.Name = "LblWelcome";
            this.LblWelcome.Size = new System.Drawing.Size(136, 29);
            this.LblWelcome.TabIndex = 8;
            this.LblWelcome.Text = "Welcome: ";
            // 
            // BtnDeal
            // 
            this.BtnDeal.BackColor = System.Drawing.Color.Black;
            this.BtnDeal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDeal.FlatAppearance.BorderSize = 0;
            this.BtnDeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeal.ForeColor = System.Drawing.Color.Gold;
            this.BtnDeal.Location = new System.Drawing.Point(569, 698);
            this.BtnDeal.Name = "BtnDeal";
            this.BtnDeal.Size = new System.Drawing.Size(141, 50);
            this.BtnDeal.TabIndex = 9;
            this.BtnDeal.Text = "Deal";
            this.BtnDeal.UseVisualStyleBackColor = false;
            this.BtnDeal.Click += new System.EventHandler(this.BtnDeal_Click);
            // 
            // lblMise
            // 
            this.lblMise.AutoSize = true;
            this.lblMise.BackColor = System.Drawing.Color.Transparent;
            this.lblMise.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMise.ForeColor = System.Drawing.Color.Black;
            this.lblMise.Location = new System.Drawing.Point(12, 672);
            this.lblMise.Name = "lblMise";
            this.lblMise.Size = new System.Drawing.Size(162, 29);
            this.lblMise.TabIndex = 10;
            this.lblMise.Text = "Mise totale : ";
            // 
            // lblMiseModif
            // 
            this.lblMiseModif.AutoSize = true;
            this.lblMiseModif.BackColor = System.Drawing.Color.Transparent;
            this.lblMiseModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiseModif.ForeColor = System.Drawing.Color.Black;
            this.lblMiseModif.Location = new System.Drawing.Point(12, 719);
            this.lblMiseModif.Name = "lblMiseModif";
            this.lblMiseModif.Size = new System.Drawing.Size(130, 29);
            this.lblMiseModif.TabIndex = 11;
            this.lblMiseModif.Text = "Modifier : ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(138, 719);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 29);
            this.button1.TabIndex = 12;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Yellow;
            this.button2.Location = new System.Drawing.Point(203, 719);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 29);
            this.button2.TabIndex = 13;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // LblBalance
            // 
            this.LblBalance.AutoSize = true;
            this.LblBalance.BackColor = System.Drawing.Color.Transparent;
            this.LblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBalance.ForeColor = System.Drawing.Color.Black;
            this.LblBalance.Location = new System.Drawing.Point(1009, 672);
            this.LblBalance.Name = "LblBalance";
            this.LblBalance.Size = new System.Drawing.Size(121, 29);
            this.LblBalance.TabIndex = 14;
            this.LblBalance.Text = "Balance :";
            // 
            // lblGain
            // 
            this.lblGain.AutoSize = true;
            this.lblGain.BackColor = System.Drawing.Color.Transparent;
            this.lblGain.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGain.ForeColor = System.Drawing.Color.Black;
            this.lblGain.Location = new System.Drawing.Point(1009, 719);
            this.lblGain.Name = "lblGain";
            this.lblGain.Size = new System.Drawing.Size(148, 29);
            this.lblGain.TabIndex = 15;
            this.lblGain.Text = "Gain Total :";
            // 
            // BtnTopUp
            // 
            this.BtnTopUp.BackColor = System.Drawing.Color.Transparent;
            this.BtnTopUp.BackgroundImage = global::Blackjack21.Properties.Resources.funds;
            this.BtnTopUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnTopUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTopUp.FlatAppearance.BorderSize = 0;
            this.BtnTopUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnTopUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnTopUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTopUp.Location = new System.Drawing.Point(31, 41);
            this.BtnTopUp.Name = "BtnTopUp";
            this.BtnTopUp.Size = new System.Drawing.Size(89, 74);
            this.BtnTopUp.TabIndex = 16;
            this.BtnTopUp.UseVisualStyleBackColor = false;
            this.BtnTopUp.Click += new System.EventHandler(this.BtnTopUp_Click);
            // 
            // PicChip1
            // 
            this.PicChip1.BackColor = System.Drawing.Color.Transparent;
            this.PicChip1.Image = global::Blackjack21.Properties.Resources._1Chip;
            this.PicChip1.Location = new System.Drawing.Point(20, 430);
            this.PicChip1.Name = "PicChip1";
            this.PicChip1.Size = new System.Drawing.Size(100, 100);
            this.PicChip1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicChip1.TabIndex = 17;
            this.PicChip1.TabStop = false;
            // 
            // PicChip2
            // 
            this.PicChip2.BackColor = System.Drawing.Color.Transparent;
            this.PicChip2.Image = global::Blackjack21.Properties.Resources._5Chip;
            this.PicChip2.Location = new System.Drawing.Point(162, 502);
            this.PicChip2.Name = "PicChip2";
            this.PicChip2.Size = new System.Drawing.Size(100, 100);
            this.PicChip2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicChip2.TabIndex = 18;
            this.PicChip2.TabStop = false;
            // 
            // PicChip3
            // 
            this.PicChip3.BackColor = System.Drawing.Color.Transparent;
            this.PicChip3.Image = global::Blackjack21.Properties.Resources._10Chip;
            this.PicChip3.Location = new System.Drawing.Point(342, 561);
            this.PicChip3.Name = "PicChip3";
            this.PicChip3.Size = new System.Drawing.Size(100, 100);
            this.PicChip3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicChip3.TabIndex = 19;
            this.PicChip3.TabStop = false;
            // 
            // PicChip4
            // 
            this.PicChip4.BackColor = System.Drawing.Color.Transparent;
            this.PicChip4.Image = global::Blackjack21.Properties.Resources._25Chip;
            this.PicChip4.Location = new System.Drawing.Point(832, 561);
            this.PicChip4.Name = "PicChip4";
            this.PicChip4.Size = new System.Drawing.Size(100, 100);
            this.PicChip4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicChip4.TabIndex = 20;
            this.PicChip4.TabStop = false;
            // 
            // PicChip5
            // 
            this.PicChip5.BackColor = System.Drawing.Color.Transparent;
            this.PicChip5.Image = global::Blackjack21.Properties.Resources._50Chip;
            this.PicChip5.Location = new System.Drawing.Point(1014, 512);
            this.PicChip5.Name = "PicChip5";
            this.PicChip5.Size = new System.Drawing.Size(100, 100);
            this.PicChip5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicChip5.TabIndex = 21;
            this.PicChip5.TabStop = false;
            // 
            // PicChip6
            // 
            this.PicChip6.BackColor = System.Drawing.Color.Transparent;
            this.PicChip6.Image = global::Blackjack21.Properties.Resources._100Chip;
            this.PicChip6.Location = new System.Drawing.Point(1158, 443);
            this.PicChip6.Name = "PicChip6";
            this.PicChip6.Size = new System.Drawing.Size(100, 100);
            this.PicChip6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicChip6.TabIndex = 22;
            this.PicChip6.TabStop = false;
            // 
            // PicFireworks
            // 
            this.PicFireworks.BackColor = System.Drawing.Color.Transparent;
            this.PicFireworks.Location = new System.Drawing.Point(406, 177);
            this.PicFireworks.Name = "PicFireworks";
            this.PicFireworks.Size = new System.Drawing.Size(458, 300);
            this.PicFireworks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicFireworks.TabIndex = 23;
            this.PicFireworks.TabStop = false;
            this.PicFireworks.Visible = false;
            // 
            // FormPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Blackjack21.Properties.Resources.BlackJackTable;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1270, 760);
            this.Controls.Add(this.PicFireworks);
            this.Controls.Add(this.PicChip6);
            this.Controls.Add(this.PicChip5);
            this.Controls.Add(this.PicChip4);
            this.Controls.Add(this.PicChip3);
            this.Controls.Add(this.PicChip2);
            this.Controls.Add(this.PicChip1);
            this.Controls.Add(this.BtnTopUp);
            this.Controls.Add(this.lblGain);
            this.Controls.Add(this.LblBalance);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblMiseModif);
            this.Controls.Add(this.lblMise);
            this.Controls.Add(this.BtnDeal);
            this.Controls.Add(this.LblWelcome);
            this.Controls.Add(this.BtnStand);
            this.Controls.Add(this.BtnHit);
            this.Controls.Add(this.LblDealerScore);
            this.Controls.Add(this.LblPlayerScore);
            this.Controls.Add(this.flpDealerCards);
            this.Controls.Add(this.flpPlayerCards);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormPlay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BlackJack 21";
            this.Load += new System.EventHandler(this.FormPlay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicChip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicChip2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicChip3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicChip4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicChip5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicChip6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicFireworks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpPlayerCards;
        private System.Windows.Forms.FlowLayoutPanel flpDealerCards;
        private System.Windows.Forms.Label LblPlayerScore;
        private System.Windows.Forms.Label LblDealerScore;
        private System.Windows.Forms.Button BtnHit;
        private System.Windows.Forms.Button BtnStand;
        private System.Windows.Forms.Label LblWelcome;
        private System.Windows.Forms.Button BtnDeal;
        private System.Windows.Forms.Label lblMise;
        private System.Windows.Forms.Label lblMiseModif;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label LblBalance;
        private System.Windows.Forms.Label lblGain;
        private System.Windows.Forms.Button BtnTopUp;
        private System.Windows.Forms.PictureBox PicChip1;
        private System.Windows.Forms.PictureBox PicChip2;
        private System.Windows.Forms.PictureBox PicChip3;
        private System.Windows.Forms.PictureBox PicChip4;
        private System.Windows.Forms.PictureBox PicChip5;
        private System.Windows.Forms.PictureBox PicChip6;
        private System.Windows.Forms.PictureBox PicFireworks;
    }
}