
namespace ValorantStreamOverlay
{
    partial class Settings
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
            this.ski = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.refreshDrop = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.skinDrop = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.regionDrop = new System.Windows.Forms.ComboBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.applyButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.twitchBotCheck = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.twitchBotToken = new System.Windows.Forms.TextBox();
            this.twitchbotUsername = new System.Windows.Forms.TextBox();
            this.twitchChannelname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.languageDrop = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ski
            // 
            this.ski.FormattingEnabled = true;
            this.ski.Location = new System.Drawing.Point(137, 129);
            this.ski.Name = "ski";
            this.ski.Size = new System.Drawing.Size(134, 33);
            this.ski.TabIndex = 7;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-3, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(583, 504);
            this.tabControl1.TabIndex = 10;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.languageDrop);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.refreshDrop);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.skinDrop);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.regionDrop);
            this.tabPage1.Controls.Add(this.passwordTextBox);
            this.tabPage1.Controls.Add(this.applyButton);
            this.tabPage1.Controls.Add(this.cancelButton);
            this.tabPage1.Controls.Add(this.usernameTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(575, 466);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Login";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(139, 48);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 31);
            this.label6.TabIndex = 20;
            this.label6.Text = "Login :";
            // 
            // refreshDrop
            // 
            this.refreshDrop.FormattingEnabled = true;
            this.refreshDrop.Items.AddRange(new object[] {
            "30 Seconds",
            "60 Seconds"});
            this.refreshDrop.Location = new System.Drawing.Point(237, 273);
            this.refreshDrop.Margin = new System.Windows.Forms.Padding(4);
            this.refreshDrop.Name = "refreshDrop";
            this.refreshDrop.Size = new System.Drawing.Size(199, 33);
            this.refreshDrop.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(113, 273);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 31);
            this.label3.TabIndex = 18;
            this.label3.Text = "Refresh:";
            // 
            // skinDrop
            // 
            this.skinDrop.FormattingEnabled = true;
            this.skinDrop.Items.AddRange(new object[] {
            "Default Red",
            "Blue",
            "Light Blue",
            "Green",
            "Purple",
            "Gray",
            "Custom"});
            this.skinDrop.Location = new System.Drawing.Point(237, 227);
            this.skinDrop.Margin = new System.Windows.Forms.Padding(4);
            this.skinDrop.Name = "skinDrop";
            this.skinDrop.Size = new System.Drawing.Size(199, 33);
            this.skinDrop.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(113, 227);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 31);
            this.label2.TabIndex = 16;
            this.label2.Text = "Skin:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(113, 181);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 31);
            this.label1.TabIndex = 15;
            this.label1.Text = "Region:";
            // 
            // regionDrop
            // 
            this.regionDrop.FormattingEnabled = true;
            this.regionDrop.Items.AddRange(new object[] {
            "North America | LATAM",
            "Europe",
            "Korea",
            "Asia Pacific"});
            this.regionDrop.Location = new System.Drawing.Point(237, 181);
            this.regionDrop.Margin = new System.Windows.Forms.Padding(4);
            this.regionDrop.Name = "regionDrop";
            this.regionDrop.Size = new System.Drawing.Size(199, 33);
            this.regionDrop.TabIndex = 14;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(139, 137);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.PlaceholderText = "Riot Games Password";
            this.passwordTextBox.Size = new System.Drawing.Size(296, 31);
            this.passwordTextBox.TabIndex = 13;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // applyButton
            // 
            this.applyButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.applyButton.Location = new System.Drawing.Point(165, 367);
            this.applyButton.Margin = new System.Windows.Forms.Padding(4);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(112, 34);
            this.applyButton.TabIndex = 12;
            this.applyButton.Text = "APPLY";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click_1);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(287, 367);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(112, 34);
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(139, 93);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.PlaceholderText = "Riot Games Username";
            this.usernameTextBox.Size = new System.Drawing.Size(296, 31);
            this.usernameTextBox.TabIndex = 10;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.twitchBotCheck);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.twitchBotToken);
            this.tabPage2.Controls.Add(this.twitchbotUsername);
            this.tabPage2.Controls.Add(this.twitchChannelname);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(575, 466);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Twitch";
            // 
            // twitchBotCheck
            // 
            this.twitchBotCheck.AutoSize = true;
            this.twitchBotCheck.Location = new System.Drawing.Point(306, 120);
            this.twitchBotCheck.Margin = new System.Windows.Forms.Padding(4);
            this.twitchBotCheck.Name = "twitchBotCheck";
            this.twitchBotCheck.Size = new System.Drawing.Size(90, 29);
            this.twitchBotCheck.TabIndex = 24;
            this.twitchBotCheck.Text = "Enable";
            this.twitchBotCheck.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(179, 121);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "Turn On Bot?:";
            // 
            // twitchBotToken
            // 
            this.twitchBotToken.Location = new System.Drawing.Point(139, 240);
            this.twitchBotToken.Margin = new System.Windows.Forms.Padding(4);
            this.twitchBotToken.Name = "twitchBotToken";
            this.twitchBotToken.PasswordChar = '*';
            this.twitchBotToken.PlaceholderText = "Twitch Bot Token";
            this.twitchBotToken.Size = new System.Drawing.Size(296, 31);
            this.twitchBotToken.TabIndex = 22;
            this.twitchBotToken.UseSystemPasswordChar = true;
            // 
            // twitchbotUsername
            // 
            this.twitchbotUsername.Location = new System.Drawing.Point(139, 197);
            this.twitchbotUsername.Margin = new System.Windows.Forms.Padding(4);
            this.twitchbotUsername.Name = "twitchbotUsername";
            this.twitchbotUsername.PlaceholderText = "Twitch Bot Username";
            this.twitchbotUsername.Size = new System.Drawing.Size(296, 31);
            this.twitchbotUsername.TabIndex = 21;
            // 
            // twitchChannelname
            // 
            this.twitchChannelname.Location = new System.Drawing.Point(139, 153);
            this.twitchChannelname.Margin = new System.Windows.Forms.Padding(4);
            this.twitchChannelname.Name = "twitchChannelname";
            this.twitchChannelname.PlaceholderText = "Twitch Channel Name";
            this.twitchChannelname.Size = new System.Drawing.Size(296, 31);
            this.twitchChannelname.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(139, 85);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 31);
            this.label4.TabIndex = 19;
            this.label4.Text = "Twitch Bot Settings:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // languageDrop
            // 
            this.languageDrop.FormattingEnabled = true;
            this.languageDrop.Items.AddRange(new object[]
            {
                "English",
                "Spanish",
                "French"});
            this.languageDrop.Location = new System.Drawing.Point(236, 318);
            this.languageDrop.Margin = new System.Windows.Forms.Padding(4);
            this.languageDrop.Name = "languageDrop";
            this.languageDrop.Size = new System.Drawing.Size(199, 33);
            this.languageDrop.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(113, 318);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 31);
            this.label7.TabIndex = 21;
            this.label7.Text = "Language:";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(579, 504);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox ski;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox twitchBotCheck;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox twitchBotToken;
        private System.Windows.Forms.TextBox twitchbotUsername;
        private System.Windows.Forms.TextBox twitchChannelname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox refreshDrop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox skinDrop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox regionDrop;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox languageDrop;
        private System.Windows.Forms.Label label7;
    }
}