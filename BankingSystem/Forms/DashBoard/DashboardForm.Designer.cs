﻿namespace BankingSystem.Forms.DashBoard
{
    partial class DashboardForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            line1 = new Panel();
            line2 = new Panel();
            appLogoIcon = new Panel();
            dashboardPanel = new Panel();
            homeScreenButton = new Utils.Components.RoundedButton();
            accountButton = new Utils.Components.RoundedButton();
            logoutButton = new Utils.Components.RoundedButton();
            SuspendLayout();
            // 
            // line1
            // 
            line1.BackColor = Color.WhiteSmoke;
            line1.Location = new Point(12, 80);
            line1.Name = "line1";
            line1.Size = new Size(215, 2);
            line1.TabIndex = 5;
            // 
            // line2
            // 
            line2.BackColor = Color.WhiteSmoke;
            line2.Location = new Point(12, 610);
            line2.Name = "line2";
            line2.Size = new Size(215, 2);
            line2.TabIndex = 6;
            // 
            // appLogoIcon
            // 
            appLogoIcon.BackColor = Color.Transparent;
            appLogoIcon.BackgroundImage = Properties.Resources.OnlyFundsLogoDashboard;
            appLogoIcon.Location = new Point(96, 12);
            appLogoIcon.Name = "appLogoIcon";
            appLogoIcon.Size = new Size(61, 50);
            appLogoIcon.TabIndex = 7;
            // 
            // dashboardPanel
            // 
            dashboardPanel.BackColor = Color.White;
            dashboardPanel.Location = new Point(242, -1);
            dashboardPanel.Name = "dashboardPanel";
            dashboardPanel.Size = new Size(1039, 723);
            dashboardPanel.TabIndex = 2;
            // 
            // homeScreenButton
            // 
            homeScreenButton.BorderColor = Color.Transparent;
            homeScreenButton.ButtonColor = Color.FromArgb(92, 184, 92);
            homeScreenButton.CornerRadius = 5;
            homeScreenButton.Cursor = Cursors.Hand;
            homeScreenButton.FlatAppearance.BorderSize = 0;
            homeScreenButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(48, 48, 51);
            homeScreenButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(48, 48, 51);
            homeScreenButton.FlatStyle = FlatStyle.Flat;
            homeScreenButton.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            homeScreenButton.ForeColor = Color.WhiteSmoke;
            homeScreenButton.Location = new Point(12, 111);
            homeScreenButton.Name = "homeScreenButton";
            homeScreenButton.OnHoverBorderColor = Color.Transparent;
            homeScreenButton.OnHoverButtonColor = Color.FromArgb(124, 205, 124);
            homeScreenButton.OnHoverTextColor = Color.WhiteSmoke;
            homeScreenButton.Size = new Size(215, 40);
            homeScreenButton.TabIndex = 1;
            homeScreenButton.Text = "Home";
            homeScreenButton.TextColor = Color.WhiteSmoke;
            homeScreenButton.UseVisualStyleBackColor = false;
            homeScreenButton.Click += homeScreenButton_Click;
            // 
            // accountButton
            // 
            accountButton.BorderColor = Color.Transparent;
            accountButton.ButtonColor = Color.FromArgb(38, 38, 41);
            accountButton.CornerRadius = 5;
            accountButton.Cursor = Cursors.Hand;
            accountButton.FlatAppearance.BorderSize = 0;
            accountButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(48, 48, 51);
            accountButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(48, 48, 51);
            accountButton.FlatStyle = FlatStyle.Flat;
            accountButton.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            accountButton.ForeColor = Color.FromArgb(48, 48, 51);
            accountButton.Location = new Point(12, 163);
            accountButton.Name = "accountButton";
            accountButton.OnHoverBorderColor = Color.Transparent;
            accountButton.OnHoverButtonColor = Color.FromArgb(48, 48, 51);
            accountButton.OnHoverTextColor = Color.WhiteSmoke;
            accountButton.Size = new Size(215, 40);
            accountButton.TabIndex = 3;
            accountButton.Text = "Account";
            accountButton.TextColor = Color.WhiteSmoke;
            accountButton.UseVisualStyleBackColor = false;
            accountButton.Click += accountButton_Click;
            // 
            // logoutButton
            // 
            logoutButton.BorderColor = Color.Transparent;
            logoutButton.ButtonColor = Color.FromArgb(92, 184, 92);
            logoutButton.CornerRadius = 5;
            logoutButton.Cursor = Cursors.Hand;
            logoutButton.FlatAppearance.BorderSize = 0;
            logoutButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(48, 48, 51);
            logoutButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(48, 48, 51);
            logoutButton.FlatStyle = FlatStyle.Flat;
            logoutButton.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            logoutButton.ForeColor = Color.WhiteSmoke;
            logoutButton.Location = new Point(12, 643);
            logoutButton.Name = "logoutButton";
            logoutButton.OnHoverBorderColor = Color.Transparent;
            logoutButton.OnHoverButtonColor = Color.FromArgb(124, 205, 124);
            logoutButton.OnHoverTextColor = Color.WhiteSmoke;
            logoutButton.Size = new Size(215, 40);
            logoutButton.TabIndex = 4;
            logoutButton.Text = "Logout";
            logoutButton.TextColor = Color.WhiteSmoke;
            logoutButton.UseVisualStyleBackColor = false;
            logoutButton.Click += logoutButton_Click;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(38, 38, 41);
            ClientSize = new Size(1280, 720);
            Controls.Add(logoutButton);
            Controls.Add(accountButton);
            Controls.Add(line2);
            Controls.Add(appLogoIcon);
            Controls.Add(line1);
            Controls.Add(homeScreenButton);
            Controls.Add(dashboardPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DashboardForm";
            Text = "DashboardForm";
            ResumeLayout(false);
        }

        private Panel line1;
        private Panel line2;
        private Panel appLogoIcon;
        private Utils.Components.RoundedButton homeScreenButton;
        private Utils.Components.RoundedButton accountButton;
        private Utils.Components.RoundedButton logoutButton;
        public static Panel dashboardPanel;
    }
}