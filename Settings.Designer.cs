
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
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.applyButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.regionDrop = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ski = new System.Windows.Forms.ComboBox();
            this.skinDrop = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.refreshDrop = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.twitchChannelname = new System.Windows.Forms.TextBox();
            this.twitchbotUsername = new System.Windows.Forms.TextBox();
            this.twitchBotToken = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.twitchBotCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(23, 11);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.PlaceholderText = "Riot Games Username";
            this.usernameTextBox.Size = new System.Drawing.Size(199, 23);
            this.usernameTextBox.TabIndex = 0;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(120, 299);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // applyButton
            // 
            this.applyButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.applyButton.Location = new System.Drawing.Point(39, 299);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 23);
            this.applyButton.TabIndex = 2;
            this.applyButton.Text = "APPLY";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(23, 40);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.PlaceholderText = "Riot Games Password";
            this.passwordTextBox.Size = new System.Drawing.Size(199, 23);
            this.passwordTextBox.TabIndex = 3;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // regionDrop
            // 
            this.regionDrop.FormattingEnabled = true;
            this.regionDrop.Items.AddRange(new object[] {
            "North America | LATAM",
            "Europe",
            "Korea",
            "Asia Pacific"});
            this.regionDrop.Location = new System.Drawing.Point(88, 69);
            this.regionDrop.Name = "regionDrop";
            this.regionDrop.Size = new System.Drawing.Size(134, 23);
            this.regionDrop.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Region:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(23, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Skin:";
            // 
            // ski
            // 
            this.ski.FormattingEnabled = true;
            this.ski.Location = new System.Drawing.Point(137, 129);
            this.ski.Name = "ski";
            this.ski.Size = new System.Drawing.Size(134, 23);
            this.ski.TabIndex = 7;
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
            this.skinDrop.Location = new System.Drawing.Point(88, 100);
            this.skinDrop.Name = "skinDrop";
            this.skinDrop.Size = new System.Drawing.Size(134, 23);
            this.skinDrop.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(23, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Refresh:";
            // 
            // refreshDrop
            // 
            this.refreshDrop.FormattingEnabled = true;
            this.refreshDrop.Items.AddRange(new object[] {
            "30 Seconds",
            "60 Seconds"});
            this.refreshDrop.Location = new System.Drawing.Point(88, 131);
            this.refreshDrop.Name = "refreshDrop";
            this.refreshDrop.Size = new System.Drawing.Size(134, 23);
            this.refreshDrop.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(23, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Twitch Bot Settings:";
            // 
            // twitchChannelname
            // 
            this.twitchChannelname.Location = new System.Drawing.Point(23, 212);
            this.twitchChannelname.Name = "twitchChannelname";
            this.twitchChannelname.PlaceholderText = "Twitch Channel Name";
            this.twitchChannelname.Size = new System.Drawing.Size(199, 23);
            this.twitchChannelname.TabIndex = 11;
            // 
            // twitchbotUsername
            // 
            this.twitchbotUsername.Location = new System.Drawing.Point(23, 241);
            this.twitchbotUsername.Name = "twitchbotUsername";
            this.twitchbotUsername.PlaceholderText = "Twitch Bot Username";
            this.twitchbotUsername.Size = new System.Drawing.Size(199, 23);
            this.twitchbotUsername.TabIndex = 12;
            // 
            // twitchBotToken
            // 
            this.twitchBotToken.Location = new System.Drawing.Point(23, 270);
            this.twitchBotToken.Name = "twitchBotToken";
            this.twitchBotToken.PasswordChar = '*';
            this.twitchBotToken.PlaceholderText = "Twitch Bot Token";
            this.twitchBotToken.Size = new System.Drawing.Size(199, 23);
            this.twitchBotToken.TabIndex = 13;
            this.twitchBotToken.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Turn On Bot?:";
            // 
            // twitchBotCheck
            // 
            this.twitchBotCheck.AutoSize = true;
            this.twitchBotCheck.Location = new System.Drawing.Point(134, 190);
            this.twitchBotCheck.Name = "twitchBotCheck";
            this.twitchBotCheck.Size = new System.Drawing.Size(61, 19);
            this.twitchBotCheck.TabIndex = 18;
            this.twitchBotCheck.Text = "Enable";
            this.twitchBotCheck.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(234, 336);
            this.Controls.Add(this.twitchBotCheck);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.twitchBotToken);
            this.Controls.Add(this.twitchbotUsername);
            this.Controls.Add(this.twitchChannelname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.refreshDrop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.skinDrop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.regionDrop);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.usernameTextBox);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.ComboBox regionDrop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ski;
        private System.Windows.Forms.ComboBox skinDrop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox refreshDrop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox twitchChannelname;
        private System.Windows.Forms.TextBox twitchbotUsername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox twitchBotToken;
        private System.Windows.Forms.CheckBox twitchBotCheck;
    }
}