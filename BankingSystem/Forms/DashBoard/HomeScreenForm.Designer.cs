﻿namespace BankingSystem.Forms.DashBoard
{
    partial class HomeScreenForm
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
            line3 = new Panel();
            line4 = new Panel();
            line5 = new Panel();
            line6 = new Panel();
            homeScreenPanel = new Panel();
            greetUserLabel = new Label();
            transactionHistoryLabel = new Label();
            balanceCardPanel = new Utils.Components.RoundedPanel();
            balanceLabel = new Label();
            availableBalanceLabel = new Label();
            transferCardPanel = new Utils.Components.RoundedPanel();
            arrowDownIcon = new Panel();
            transferLabel = new Label();
            receiverIDPanel = new Utils.Components.RoundedPanel();
            receiverIDTextBox = new TextBox();
            receiverIDLabel = new Label();
            amountTransferLabel = new Label();
            yourIDLabel = new Label();
            yourIDPanel = new Utils.Components.RoundedPanel();
            yourIDTextBox = new TextBox();
            confirmButton = new Utils.Components.RoundedButton();
            amountTransferPanel = new Utils.Components.RoundedPanel();
            amountTransferNumeric = new NumericUpDown();
            transactionCardPanel = new Utils.Components.RoundedPanel();
            transactionLabel = new Label();
            amountTransactionLabel = new Label();
            amountTransactionPanel = new Utils.Components.RoundedPanel();
            amountTransactionNumeric = new NumericUpDown();
            withdrawButton = new Utils.Components.RoundedButton();
            depositButton = new Utils.Components.RoundedButton();
            transactionHistoryView = new ListView();
            transactionIDHeader = new ColumnHeader();
            amountHeader = new ColumnHeader();
            dateHeader = new ColumnHeader();
            transactionTypeHeader = new ColumnHeader();
            homeScreenPanel.SuspendLayout();
            balanceCardPanel.SuspendLayout();
            transferCardPanel.SuspendLayout();
            receiverIDPanel.SuspendLayout();
            yourIDPanel.SuspendLayout();
            amountTransferPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)amountTransferNumeric).BeginInit();
            transactionCardPanel.SuspendLayout();
            amountTransactionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)amountTransactionNumeric).BeginInit();
            SuspendLayout();
            // 
            // line1
            // 
            line1.BackColor = Color.DimGray;
            line1.Location = new Point(13, 37);
            line1.Name = "line1";
            line1.Size = new Size(226, 2);
            line1.TabIndex = 1;
            // 
            // line2
            // 
            line2.BackColor = Color.Gainsboro;
            line2.Location = new Point(35, 162);
            line2.Name = "line2";
            line2.Size = new Size(380, 2);
            line2.TabIndex = 38;
            // 
            // line3
            // 
            line3.BackColor = Color.Gainsboro;
            line3.Location = new Point(39, 430);
            line3.Name = "line3";
            line3.Size = new Size(353, 2);
            line3.TabIndex = 37;
            // 
            // line4
            // 
            line4.BackColor = Color.DimGray;
            line4.Location = new Point(11, 38);
            line4.Name = "line4";
            line4.Size = new Size(226, 2);
            line4.TabIndex = 1;
            // 
            // line5
            // 
            line5.BackColor = Color.DimGray;
            line5.Location = new Point(13, 37);
            line5.Name = "line5";
            line5.Size = new Size(226, 2);
            line5.TabIndex = 1;
            // 
            // line6
            // 
            line6.BackColor = Color.DimGray;
            line6.Location = new Point(11, 38);
            line6.Name = "line6";
            line6.Size = new Size(226, 2);
            line6.TabIndex = 1;
            // 
            // homeScreenPanel
            // 
            homeScreenPanel.AutoScroll = true;
            homeScreenPanel.AutoScrollMinSize = new Size(0, 1000);
            homeScreenPanel.BackColor = Color.FromArgb(48, 48, 51);
            homeScreenPanel.Controls.Add(transactionHistoryView);
            homeScreenPanel.Controls.Add(greetUserLabel);
            homeScreenPanel.Controls.Add(transactionHistoryLabel);
            homeScreenPanel.Controls.Add(balanceCardPanel);
            homeScreenPanel.Controls.Add(transferCardPanel);
            homeScreenPanel.Controls.Add(transactionCardPanel);
            homeScreenPanel.Location = new Point(0, -1);
            homeScreenPanel.Name = "homeScreenPanel";
            homeScreenPanel.Size = new Size(1040, 723);
            homeScreenPanel.TabIndex = 30;
            // 
            // greetUserLabel
            // 
            greetUserLabel.AutoSize = true;
            greetUserLabel.Font = new Font("Arial Black", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            greetUserLabel.ForeColor = Color.WhiteSmoke;
            greetUserLabel.Location = new Point(61, 33);
            greetUserLabel.Name = "greetUserLabel";
            greetUserLabel.Size = new Size(184, 52);
            greetUserLabel.TabIndex = 26;
            greetUserLabel.Text = "Hi, User";
            // 
            // transactionHistoryLabel
            // 
            transactionHistoryLabel.AutoSize = true;
            transactionHistoryLabel.Font = new Font("Arial Black", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            transactionHistoryLabel.ForeColor = Color.WhiteSmoke;
            transactionHistoryLabel.Location = new Point(61, 665);
            transactionHistoryLabel.Name = "transactionHistoryLabel";
            transactionHistoryLabel.Size = new Size(425, 52);
            transactionHistoryLabel.TabIndex = 29;
            transactionHistoryLabel.Text = "Transaction History";
            // 
            // balanceCardPanel
            // 
            balanceCardPanel.BackColor = Color.Transparent;
            balanceCardPanel.BorderColor = Color.FromArgb(92, 184, 92);
            balanceCardPanel.Controls.Add(balanceLabel);
            balanceCardPanel.Controls.Add(availableBalanceLabel);
            balanceCardPanel.CornerRadius = 10;
            balanceCardPanel.ForeColor = Color.Transparent;
            balanceCardPanel.Location = new Point(61, 96);
            balanceCardPanel.Name = "balanceCardPanel";
            balanceCardPanel.Size = new Size(451, 206);
            balanceCardPanel.TabIndex = 25;
            // 
            // balanceLabel
            // 
            balanceLabel.AutoSize = true;
            balanceLabel.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point);
            balanceLabel.ForeColor = Color.WhiteSmoke;
            balanceLabel.Location = new Point(139, 90);
            balanceLabel.Name = "balanceLabel";
            balanceLabel.Size = new Size(163, 55);
            balanceLabel.TabIndex = 0;
            balanceLabel.Text = "₱ 0.00";
            // 
            // availableBalanceLabel
            // 
            availableBalanceLabel.AutoSize = true;
            availableBalanceLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            availableBalanceLabel.ForeColor = Color.WhiteSmoke;
            availableBalanceLabel.Location = new Point(150, 70);
            availableBalanceLabel.Name = "availableBalanceLabel";
            availableBalanceLabel.Size = new Size(151, 20);
            availableBalanceLabel.TabIndex = 28;
            availableBalanceLabel.Text = "Available Balance";
            // 
            // transferCardPanel
            // 
            transferCardPanel.BackColor = Color.Transparent;
            transferCardPanel.BorderColor = Color.WhiteSmoke;
            transferCardPanel.Controls.Add(line3);
            transferCardPanel.Controls.Add(arrowDownIcon);
            transferCardPanel.Controls.Add(transferLabel);
            transferCardPanel.Controls.Add(receiverIDPanel);
            transferCardPanel.Controls.Add(receiverIDLabel);
            transferCardPanel.Controls.Add(amountTransferLabel);
            transferCardPanel.Controls.Add(yourIDLabel);
            transferCardPanel.Controls.Add(yourIDPanel);
            transferCardPanel.Controls.Add(confirmButton);
            transferCardPanel.Controls.Add(amountTransferPanel);
            transferCardPanel.CornerRadius = 10;
            transferCardPanel.ForeColor = Color.Transparent;
            transferCardPanel.Location = new Point(540, 96);
            transferCardPanel.Name = "transferCardPanel";
            transferCardPanel.Size = new Size(422, 548);
            transferCardPanel.TabIndex = 27;
            // 
            // arrowDownIcon
            // 
            arrowDownIcon.BackgroundImage = Properties.Resources.down_arrow;
            arrowDownIcon.BackgroundImageLayout = ImageLayout.Stretch;
            arrowDownIcon.Location = new Point(191, 259);
            arrowDownIcon.Name = "arrowDownIcon";
            arrowDownIcon.Size = new Size(50, 50);
            arrowDownIcon.TabIndex = 36;
            // 
            // transferLabel
            // 
            transferLabel.AutoSize = true;
            transferLabel.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            transferLabel.ForeColor = Color.FromArgb(48, 48, 51);
            transferLabel.Location = new Point(86, 19);
            transferLabel.Name = "transferLabel";
            transferLabel.Size = new Size(218, 31);
            transferLabel.TabIndex = 30;
            transferLabel.Text = "Transfer Money";
            // 
            // receiverIDPanel
            // 
            receiverIDPanel.BackColor = Color.Transparent;
            receiverIDPanel.BorderColor = Color.FromArgb(48, 48, 51);
            receiverIDPanel.Controls.Add(receiverIDTextBox);
            receiverIDPanel.Controls.Add(line6);
            receiverIDPanel.CornerRadius = 10;
            receiverIDPanel.ForeColor = Color.Transparent;
            receiverIDPanel.Location = new Point(91, 355);
            receiverIDPanel.Name = "receiverIDPanel";
            receiverIDPanel.Size = new Size(248, 45);
            receiverIDPanel.TabIndex = 33;
            // 
            // receiverIDTextBox
            // 
            receiverIDTextBox.BackColor = Color.FromArgb(48, 48, 51);
            receiverIDTextBox.BorderStyle = BorderStyle.None;
            receiverIDTextBox.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            receiverIDTextBox.ForeColor = Color.WhiteSmoke;
            receiverIDTextBox.Location = new Point(11, 13);
            receiverIDTextBox.Name = "receiverIDTextBox";
            receiverIDTextBox.Size = new Size(226, 19);
            receiverIDTextBox.TabIndex = 32;
            // 
            // receiverIDLabel
            // 
            receiverIDLabel.AutoSize = true;
            receiverIDLabel.BackColor = Color.Transparent;
            receiverIDLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            receiverIDLabel.ForeColor = Color.FromArgb(48, 48, 51);
            receiverIDLabel.Location = new Point(91, 332);
            receiverIDLabel.Name = "receiverIDLabel";
            receiverIDLabel.Size = new Size(103, 20);
            receiverIDLabel.TabIndex = 35;
            receiverIDLabel.Text = "Receiver's ID";
            // 
            // amountTransferLabel
            // 
            amountTransferLabel.AutoSize = true;
            amountTransferLabel.BackColor = Color.Transparent;
            amountTransferLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            amountTransferLabel.ForeColor = Color.FromArgb(48, 48, 51);
            amountTransferLabel.Location = new Point(91, 165);
            amountTransferLabel.Name = "amountTransferLabel";
            amountTransferLabel.Size = new Size(65, 20);
            amountTransferLabel.TabIndex = 34;
            amountTransferLabel.Text = "Amount";
            // 
            // yourIDLabel
            // 
            yourIDLabel.AutoSize = true;
            yourIDLabel.BackColor = Color.Transparent;
            yourIDLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            yourIDLabel.ForeColor = Color.FromArgb(48, 48, 51);
            yourIDLabel.Location = new Point(91, 80);
            yourIDLabel.Name = "yourIDLabel";
            yourIDLabel.Size = new Size(127, 20);
            yourIDLabel.TabIndex = 29;
            yourIDLabel.Text = "Your Account ID";
            // 
            // yourIDPanel
            // 
            yourIDPanel.BackColor = Color.Transparent;
            yourIDPanel.BorderColor = Color.FromArgb(48, 48, 51);
            yourIDPanel.Controls.Add(yourIDTextBox);
            yourIDPanel.Controls.Add(line4);
            yourIDPanel.CornerRadius = 10;
            yourIDPanel.ForeColor = Color.Transparent;
            yourIDPanel.Location = new Point(91, 103);
            yourIDPanel.Name = "yourIDPanel";
            yourIDPanel.Size = new Size(248, 45);
            yourIDPanel.TabIndex = 31;
            // 
            // yourIDTextBox
            // 
            yourIDTextBox.BackColor = Color.FromArgb(48, 48, 51);
            yourIDTextBox.BorderStyle = BorderStyle.None;
            yourIDTextBox.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            yourIDTextBox.ForeColor = Color.WhiteSmoke;
            yourIDTextBox.Location = new Point(11, 13);
            yourIDTextBox.Name = "yourIDTextBox";
            yourIDTextBox.Size = new Size(226, 19);
            yourIDTextBox.TabIndex = 32;
            // 
            // confirmButton
            // 
            confirmButton.BorderColor = Color.Transparent;
            confirmButton.ButtonColor = Color.FromArgb(92, 184, 92);
            confirmButton.CornerRadius = 10;
            confirmButton.Cursor = Cursors.Hand;
            confirmButton.FlatAppearance.BorderSize = 0;
            confirmButton.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke;
            confirmButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            confirmButton.FlatStyle = FlatStyle.Flat;
            confirmButton.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            confirmButton.ForeColor = Color.WhiteSmoke;
            confirmButton.Location = new Point(91, 446);
            confirmButton.Name = "confirmButton";
            confirmButton.OnHoverBorderColor = Color.Transparent;
            confirmButton.OnHoverButtonColor = Color.FromArgb(124, 205, 124);
            confirmButton.OnHoverTextColor = Color.WhiteSmoke;
            confirmButton.Size = new Size(248, 56);
            confirmButton.TabIndex = 7;
            confirmButton.Text = "Confirm";
            confirmButton.TextColor = Color.WhiteSmoke;
            confirmButton.UseVisualStyleBackColor = false;
            // 
            // amountTransferPanel
            // 
            amountTransferPanel.BackColor = Color.Transparent;
            amountTransferPanel.BorderColor = Color.FromArgb(48, 48, 51);
            amountTransferPanel.Controls.Add(amountTransferNumeric);
            amountTransferPanel.Controls.Add(line5);
            amountTransferPanel.CornerRadius = 10;
            amountTransferPanel.ForeColor = Color.Transparent;
            amountTransferPanel.Location = new Point(91, 188);
            amountTransferPanel.Name = "amountTransferPanel";
            amountTransferPanel.Size = new Size(250, 45);
            amountTransferPanel.TabIndex = 33;
            // 
            // amountTransferNumeric
            // 
            amountTransferNumeric.BackColor = Color.FromArgb(48, 48, 51);
            amountTransferNumeric.BorderStyle = BorderStyle.None;
            amountTransferNumeric.DecimalPlaces = 2;
            amountTransferNumeric.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            amountTransferNumeric.ForeColor = Color.WhiteSmoke;
            amountTransferNumeric.Location = new Point(13, 9);
            amountTransferNumeric.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            amountTransferNumeric.Name = "amountTransferNumeric";
            amountTransferNumeric.RightToLeft = RightToLeft.No;
            amountTransferNumeric.Size = new Size(226, 22);
            amountTransferNumeric.TabIndex = 1;
            amountTransferNumeric.TextAlign = HorizontalAlignment.Center;
            // 
            // transactionCardPanel
            // 
            transactionCardPanel.BackColor = Color.Transparent;
            transactionCardPanel.BorderColor = Color.WhiteSmoke;
            transactionCardPanel.Controls.Add(line2);
            transactionCardPanel.Controls.Add(transactionLabel);
            transactionCardPanel.Controls.Add(amountTransactionLabel);
            transactionCardPanel.Controls.Add(amountTransactionPanel);
            transactionCardPanel.Controls.Add(withdrawButton);
            transactionCardPanel.Controls.Add(depositButton);
            transactionCardPanel.CornerRadius = 10;
            transactionCardPanel.ForeColor = Color.Transparent;
            transactionCardPanel.Location = new Point(61, 332);
            transactionCardPanel.Name = "transactionCardPanel";
            transactionCardPanel.Size = new Size(451, 312);
            transactionCardPanel.TabIndex = 26;
            // 
            // transactionLabel
            // 
            transactionLabel.AutoSize = true;
            transactionLabel.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            transactionLabel.ForeColor = Color.FromArgb(48, 48, 51);
            transactionLabel.Location = new Point(94, 33);
            transactionLabel.Name = "transactionLabel";
            transactionLabel.Size = new Size(168, 31);
            transactionLabel.TabIndex = 36;
            transactionLabel.Text = "Transaction";
            // 
            // amountTransactionLabel
            // 
            amountTransactionLabel.AutoSize = true;
            amountTransactionLabel.BackColor = Color.Transparent;
            amountTransactionLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            amountTransactionLabel.ForeColor = Color.FromArgb(48, 48, 51);
            amountTransactionLabel.Location = new Point(100, 73);
            amountTransactionLabel.Name = "amountTransactionLabel";
            amountTransactionLabel.Size = new Size(65, 20);
            amountTransactionLabel.TabIndex = 36;
            amountTransactionLabel.Text = "Amount";
            // 
            // amountTransactionPanel
            // 
            amountTransactionPanel.BackColor = Color.Transparent;
            amountTransactionPanel.BorderColor = Color.FromArgb(48, 48, 51);
            amountTransactionPanel.Controls.Add(amountTransactionNumeric);
            amountTransactionPanel.Controls.Add(line1);
            amountTransactionPanel.CornerRadius = 5;
            amountTransactionPanel.ForeColor = Color.Transparent;
            amountTransactionPanel.Location = new Point(100, 96);
            amountTransactionPanel.Name = "amountTransactionPanel";
            amountTransactionPanel.Size = new Size(250, 45);
            amountTransactionPanel.TabIndex = 29;
            // 
            // amountTransactionNumeric
            // 
            amountTransactionNumeric.BackColor = Color.FromArgb(48, 48, 51);
            amountTransactionNumeric.BorderStyle = BorderStyle.None;
            amountTransactionNumeric.DecimalPlaces = 2;
            amountTransactionNumeric.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            amountTransactionNumeric.ForeColor = Color.WhiteSmoke;
            amountTransactionNumeric.Location = new Point(13, 9);
            amountTransactionNumeric.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            amountTransactionNumeric.Name = "amountTransactionNumeric";
            amountTransactionNumeric.RightToLeft = RightToLeft.No;
            amountTransactionNumeric.Size = new Size(226, 22);
            amountTransactionNumeric.TabIndex = 1;
            amountTransactionNumeric.TextAlign = HorizontalAlignment.Center;
            // 
            // withdrawButton
            // 
            withdrawButton.BorderColor = Color.Transparent;
            withdrawButton.ButtonColor = Color.FromArgb(92, 184, 92);
            withdrawButton.CornerRadius = 5;
            withdrawButton.Cursor = Cursors.Hand;
            withdrawButton.FlatAppearance.BorderSize = 0;
            withdrawButton.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke;
            withdrawButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            withdrawButton.FlatStyle = FlatStyle.Flat;
            withdrawButton.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            withdrawButton.ForeColor = Color.WhiteSmoke;
            withdrawButton.Location = new Point(100, 238);
            withdrawButton.Name = "withdrawButton";
            withdrawButton.OnHoverBorderColor = Color.Transparent;
            withdrawButton.OnHoverButtonColor = Color.FromArgb(124, 205, 124);
            withdrawButton.OnHoverTextColor = Color.WhiteSmoke;
            withdrawButton.Size = new Size(250, 45);
            withdrawButton.TabIndex = 6;
            withdrawButton.Text = "Withdraw";
            withdrawButton.TextColor = Color.WhiteSmoke;
            withdrawButton.UseVisualStyleBackColor = false;
            // 
            // depositButton
            // 
            depositButton.BorderColor = Color.Transparent;
            depositButton.ButtonColor = Color.FromArgb(92, 184, 92);
            depositButton.CornerRadius = 5;
            depositButton.Cursor = Cursors.Hand;
            depositButton.FlatAppearance.BorderSize = 0;
            depositButton.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke;
            depositButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            depositButton.FlatStyle = FlatStyle.Flat;
            depositButton.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            depositButton.ForeColor = Color.WhiteSmoke;
            depositButton.Location = new Point(100, 180);
            depositButton.Name = "depositButton";
            depositButton.OnHoverBorderColor = Color.Transparent;
            depositButton.OnHoverButtonColor = Color.FromArgb(124, 205, 124);
            depositButton.OnHoverTextColor = Color.WhiteSmoke;
            depositButton.Size = new Size(250, 45);
            depositButton.TabIndex = 5;
            depositButton.Text = "Deposit";
            depositButton.TextColor = Color.WhiteSmoke;
            depositButton.UseVisualStyleBackColor = false;
            // 
            // transactionHistoryView
            // 
            transactionHistoryView.BackColor = Color.FromArgb(48, 48, 51);
            transactionHistoryView.BorderStyle = BorderStyle.None;
            transactionHistoryView.Columns.AddRange(new ColumnHeader[] { transactionIDHeader, amountHeader, dateHeader, transactionTypeHeader });
            transactionHistoryView.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            transactionHistoryView.ForeColor = Color.WhiteSmoke;
            transactionHistoryView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            transactionHistoryView.Location = new Point(61, 725);
            transactionHistoryView.Name = "transactionHistoryView";
            transactionHistoryView.Size = new Size(901, 248);
            transactionHistoryView.TabIndex = 31;
            transactionHistoryView.UseCompatibleStateImageBehavior = false;
            transactionHistoryView.View = View.Details;
            // 
            // transactionIDHeader
            // 
            transactionIDHeader.Tag = "";
            transactionIDHeader.Text = "Transaction ID";
            transactionIDHeader.Width = 200;
            // 
            // amountHeader
            // 
            amountHeader.Text = "Amount";
            amountHeader.Width = 200;
            // 
            // dateHeader
            // 
            dateHeader.Text = "Date of Transaction";
            dateHeader.Width = 250;
            // 
            // transactionTypeHeader
            // 
            transactionTypeHeader.Text = "Transaction Type";
            transactionTypeHeader.Width = 251;
            // 
            // HomeScreenForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1039, 1000);
            Controls.Add(homeScreenPanel);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(1039, 723);
            Name = "HomeScreenForm";
            Text = "HomeScreenForm";
            homeScreenPanel.ResumeLayout(false);
            homeScreenPanel.PerformLayout();
            balanceCardPanel.ResumeLayout(false);
            balanceCardPanel.PerformLayout();
            transferCardPanel.ResumeLayout(false);
            transferCardPanel.PerformLayout();
            receiverIDPanel.ResumeLayout(false);
            receiverIDPanel.PerformLayout();
            yourIDPanel.ResumeLayout(false);
            yourIDPanel.PerformLayout();
            amountTransferPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)amountTransferNumeric).EndInit();
            transactionCardPanel.ResumeLayout(false);
            transactionCardPanel.PerformLayout();
            amountTransactionPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)amountTransactionNumeric).EndInit();
            ResumeLayout(false);
        }

        private Panel line1;
        private Panel line2;
        private Panel line3;
        private Panel line4;
        private Panel line5;
        private Panel line6;
        private Panel homeScreenPanel;
        private Panel arrowDownIcon;
        private Utils.Components.RoundedPanel balanceCardPanel;
        private Utils.Components.RoundedPanel transactionCardPanel;
        private Utils.Components.RoundedPanel transferCardPanel;
        private Utils.Components.RoundedPanel amountTransactionPanel;
        private Utils.Components.RoundedPanel amountTransferPanel;
        private Utils.Components.RoundedPanel yourIDPanel;
        private Utils.Components.RoundedPanel receiverIDPanel;
        private Label greetUserLabel;
        private Label availableBalanceLabel;
        private Label balanceLabel;
        private Label yourIDLabel;
        private Label receiverIDLabel;
        private Label amountTransactionLabel;
        private Label amountTransferLabel;
        private Label transactionLabel;
        private Label transferLabel;
        private Label transactionHistoryLabel;
        private TextBox yourIDTextBox;
        private TextBox receiverIDTextBox;
        private NumericUpDown amountTransactionNumeric;
        private NumericUpDown amountTransferNumeric;
        private Utils.Components.RoundedButton depositButton;
        private Utils.Components.RoundedButton withdrawButton;
        private Utils.Components.RoundedButton confirmButton;
        private ListView transactionHistoryView;
        private ColumnHeader transactionIDHeader;
        private ColumnHeader amountHeader;
        private ColumnHeader dateHeader;
        private ColumnHeader transactionTypeHeader;
    }
}