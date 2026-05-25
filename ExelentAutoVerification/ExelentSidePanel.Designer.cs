// ExelentSidePanel.Designer.cs

namespace ExelentAutoVerification
{
    partial class ExelentSidePanel
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblSteamId = new System.Windows.Forms.Label();
            this.lblFriendCode = new System.Windows.Forms.Label();
            this.lblLicenses = new System.Windows.Forms.Label();
            this.lstLicenses = new System.Windows.Forms.ListBox();
            this.lblHourBoost = new System.Windows.Forms.Label();
            this.lstHourBoost = new System.Windows.Forms.ListBox();
            this.lblMarket = new System.Windows.Forms.Label();
            this.lstMarket = new System.Windows.Forms.ListBox();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(25)))), ((int)(((byte)(55)))));
            this.pnlTop.Controls.Add(this.lblUsername);
            this.pnlTop.Controls.Add(this.lblBalance);
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(260, 75);
            this.pnlTop.TabIndex = 0;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(15, 10);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(101, 25);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.lblBalance.Location = new System.Drawing.Point(17, 42);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(35, 19);
            this.lblBalance.TabIndex = 1;
            this.lblBalance.Text = "0 TL";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(220, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 35);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "×";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblSteamId
            // 
            this.lblSteamId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSteamId.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblSteamId.Location = new System.Drawing.Point(15, 90);
            this.lblSteamId.Name = "lblSteamId";
            this.lblSteamId.Size = new System.Drawing.Size(220, 20);
            this.lblSteamId.TabIndex = 1;
            this.lblSteamId.Click += new System.EventHandler(this.lblSteamId_Click);
            // 
            // lblFriendCode
            // 
            this.lblFriendCode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFriendCode.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblFriendCode.Location = new System.Drawing.Point(15, 115);
            this.lblFriendCode.Name = "lblFriendCode";
            this.lblFriendCode.Size = new System.Drawing.Size(220, 20);
            this.lblFriendCode.TabIndex = 2;
            this.lblFriendCode.Click += new System.EventHandler(this.lblFriendCode_Click);
            // 
            // lblLicenses
            // 
            this.lblLicenses.AutoSize = true;
            this.lblLicenses.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblLicenses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.lblLicenses.Location = new System.Drawing.Point(15, 145);
            this.lblLicenses.Name = "lblLicenses";
            this.lblLicenses.Size = new System.Drawing.Size(53, 15);
            this.lblLicenses.TabIndex = 3;
            this.lblLicenses.Text = "Licenses";
            // 
            // lstLicenses
            // 
            this.lstLicenses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(24)))), ((int)(((byte)(50)))));
            this.lstLicenses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstLicenses.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lstLicenses.ForeColor = System.Drawing.Color.White;
            this.lstLicenses.Location = new System.Drawing.Point(15, 168);
            this.lstLicenses.Name = "lstLicenses";
            this.lstLicenses.Size = new System.Drawing.Size(225, 65);
            this.lstLicenses.TabIndex = 4;
            // 
            // lblHourBoost
            // 
            this.lblHourBoost.AutoSize = true;
            this.lblHourBoost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblHourBoost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.lblHourBoost.Location = new System.Drawing.Point(15, 241);
            this.lblHourBoost.Name = "lblHourBoost";
            this.lblHourBoost.Size = new System.Drawing.Size(67, 15);
            this.lblHourBoost.TabIndex = 5;
            this.lblHourBoost.Text = "HourBoost";
            // 
            // lstHourBoost
            // 
            this.lstHourBoost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(24)))), ((int)(((byte)(50)))));
            this.lstHourBoost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstHourBoost.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lstHourBoost.ForeColor = System.Drawing.Color.White;
            this.lstHourBoost.Location = new System.Drawing.Point(15, 264);
            this.lstHourBoost.Name = "lstHourBoost";
            this.lstHourBoost.Size = new System.Drawing.Size(225, 65);
            this.lstHourBoost.TabIndex = 6;
            // 
            // lblMarket
            // 
            this.lblMarket.AutoSize = true;
            this.lblMarket.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMarket.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.lblMarket.Location = new System.Drawing.Point(15, 336);
            this.lblMarket.Name = "lblMarket";
            this.lblMarket.Size = new System.Drawing.Size(106, 15);
            this.lblMarket.TabIndex = 7;
            this.lblMarket.Text = "Market Purchases";
            // 
            // lstMarket
            // 
            this.lstMarket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(24)))), ((int)(((byte)(50)))));
            this.lstMarket.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstMarket.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lstMarket.ForeColor = System.Drawing.Color.White;
            this.lstMarket.Location = new System.Drawing.Point(15, 359);
            this.lstMarket.Name = "lstMarket";
            this.lstMarket.Size = new System.Drawing.Size(225, 65);
            this.lstMarket.TabIndex = 8;
            // 
            // ExelentSidePanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(18)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(260, 437);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.lblSteamId);
            this.Controls.Add(this.lblFriendCode);
            this.Controls.Add(this.lblLicenses);
            this.Controls.Add(this.lstLicenses);
            this.Controls.Add(this.lblHourBoost);
            this.Controls.Add(this.lstHourBoost);
            this.Controls.Add(this.lblMarket);
            this.Controls.Add(this.lstMarket);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExelentSidePanel";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ExelentSidePanel_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblBalance;

        private System.Windows.Forms.Button btnClose;

        private System.Windows.Forms.Label lblSteamId;
        private System.Windows.Forms.Label lblFriendCode;

        private System.Windows.Forms.Label lblLicenses;
        private System.Windows.Forms.ListBox lstLicenses;

        private System.Windows.Forms.Label lblHourBoost;
        private System.Windows.Forms.ListBox lstHourBoost;

        private System.Windows.Forms.Label lblMarket;
        private System.Windows.Forms.ListBox lstMarket;
    }
}