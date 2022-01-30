
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
            this.lblTwitchSettings = new System.Windows.Forms.Label();
            this.twitchChannelname = new System.Windows.Forms.TextBox();
            this.twitchbotUsername = new System.Windows.Forms.TextBox();
            this.twitchBotToken = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.twitchBotCheck = new System.Windows.Forms.CheckBox();
            this.panelBackground = new System.Windows.Forms.Panel();
            this.panelTwitchSettings = new System.Windows.Forms.Panel();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panelColorPreview = new System.Windows.Forms.Panel();
            this.panelBackground.SuspendLayout();
            this.panelTwitchSettings.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernameTextBox.Location = new System.Drawing.Point(23, 57);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.PlaceholderText = "Riot Games Username";
            this.usernameTextBox.Size = new System.Drawing.Size(269, 27);
            this.usernameTextBox.TabIndex = 0;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cancelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Location = new System.Drawing.Point(11, 61);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(269, 39);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // applyButton
            // 
            this.applyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(21)))), ((int)(((byte)(7)))));
            this.applyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(27)))), ((int)(((byte)(11)))));
            this.applyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.applyButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.applyButton.ForeColor = System.Drawing.Color.White;
            this.applyButton.Location = new System.Drawing.Point(11, 4);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(269, 42);
            this.applyButton.TabIndex = 1;
            this.applyButton.Text = "APPLY";
            this.applyButton.UseVisualStyleBackColor = false;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordTextBox.Location = new System.Drawing.Point(23, 120);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.PlaceholderText = "Riot Games Password";
            this.passwordTextBox.Size = new System.Drawing.Size(269, 27);
            this.passwordTextBox.TabIndex = 3;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // regionDrop
            // 
            this.regionDrop.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.regionDrop.FormattingEnabled = true;
            this.regionDrop.Items.AddRange(new object[] {
            "North America | LATAM",
            "Europe",
            "Korea",
            "Asia Pacific"});
            this.regionDrop.Location = new System.Drawing.Point(23, 183);
            this.regionDrop.Name = "regionDrop";
            this.regionDrop.Size = new System.Drawing.Size(269, 28);
            this.regionDrop.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(23, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "REGION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(23, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "SKIN";
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
            this.skinDrop.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.skinDrop.FormattingEnabled = true;
            this.skinDrop.Items.AddRange(new object[] {
            "Default Red",
            "Blue",
            "Light Blue",
            "Green",
            "Purple",
            "Gray",
            "Custom"});
            this.skinDrop.Location = new System.Drawing.Point(23, 247);
            this.skinDrop.Name = "skinDrop";
            this.skinDrop.Size = new System.Drawing.Size(233, 28);
            this.skinDrop.TabIndex = 7;
            this.skinDrop.SelectedIndexChanged += new System.EventHandler(this.skinDrop_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(23, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "REFRESH";
            // 
            // refreshDrop
            // 
            this.refreshDrop.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.refreshDrop.FormattingEnabled = true;
            this.refreshDrop.Items.AddRange(new object[] {
            "30 Seconds",
            "60 Seconds"});
            this.refreshDrop.Location = new System.Drawing.Point(23, 311);
            this.refreshDrop.Name = "refreshDrop";
            this.refreshDrop.Size = new System.Drawing.Size(269, 28);
            this.refreshDrop.TabIndex = 9;
            // 
            // lblTwitchSettings
            // 
            this.lblTwitchSettings.AutoSize = true;
            this.lblTwitchSettings.BackColor = System.Drawing.Color.White;
            this.lblTwitchSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTwitchSettings.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblTwitchSettings.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTwitchSettings.Location = new System.Drawing.Point(11, 340);
            this.lblTwitchSettings.Name = "lblTwitchSettings";
            this.lblTwitchSettings.Size = new System.Drawing.Size(111, 20);
            this.lblTwitchSettings.TabIndex = 10;
            this.lblTwitchSettings.Text = "Twitch Settings:";
            this.lblTwitchSettings.Click += new System.EventHandler(this.lblTwitchSettings_Click);
            // 
            // twitchChannelname
            // 
            this.twitchChannelname.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.twitchChannelname.Location = new System.Drawing.Point(11, 42);
            this.twitchChannelname.Name = "twitchChannelname";
            this.twitchChannelname.PlaceholderText = "Twitch Channel Name";
            this.twitchChannelname.Size = new System.Drawing.Size(269, 27);
            this.twitchChannelname.TabIndex = 11;
            // 
            // twitchbotUsername
            // 
            this.twitchbotUsername.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.twitchbotUsername.Location = new System.Drawing.Point(11, 84);
            this.twitchbotUsername.Name = "twitchbotUsername";
            this.twitchbotUsername.PlaceholderText = "Twitch Bot Username";
            this.twitchbotUsername.Size = new System.Drawing.Size(269, 27);
            this.twitchbotUsername.TabIndex = 12;
            // 
            // twitchBotToken
            // 
            this.twitchBotToken.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.twitchBotToken.Location = new System.Drawing.Point(11, 126);
            this.twitchBotToken.Name = "twitchBotToken";
            this.twitchBotToken.PasswordChar = '*';
            this.twitchBotToken.PlaceholderText = "Twitch Bot Token";
            this.twitchBotToken.Size = new System.Drawing.Size(269, 27);
            this.twitchBotToken.TabIndex = 13;
            this.twitchBotToken.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(68, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Turn On Bot?:";
            // 
            // twitchBotCheck
            // 
            this.twitchBotCheck.AutoSize = true;
            this.twitchBotCheck.BackColor = System.Drawing.Color.White;
            this.twitchBotCheck.Location = new System.Drawing.Point(162, 11);
            this.twitchBotCheck.Name = "twitchBotCheck";
            this.twitchBotCheck.Size = new System.Drawing.Size(61, 19);
            this.twitchBotCheck.TabIndex = 1;
            this.twitchBotCheck.Text = "Enable";
            this.twitchBotCheck.UseVisualStyleBackColor = false;
            // 
            // panelBackground
            // 
            this.panelBackground.BackColor = System.Drawing.Color.White;
            this.panelBackground.Controls.Add(this.panelTwitchSettings);
            this.panelBackground.Controls.Add(this.panelButtons);
            this.panelBackground.Controls.Add(this.lblTwitchSettings);
            this.panelBackground.Location = new System.Drawing.Point(12, 12);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(292, 657);
            this.panelBackground.TabIndex = 19;
            // 
            // panelTwitchSettings
            // 
            this.panelTwitchSettings.Controls.Add(this.label5);
            this.panelTwitchSettings.Controls.Add(this.twitchBotCheck);
            this.panelTwitchSettings.Controls.Add(this.twitchChannelname);
            this.panelTwitchSettings.Controls.Add(this.twitchbotUsername);
            this.panelTwitchSettings.Controls.Add(this.twitchBotToken);
            this.panelTwitchSettings.Location = new System.Drawing.Point(0, 363);
            this.panelTwitchSettings.Name = "panelTwitchSettings";
            this.panelTwitchSettings.Size = new System.Drawing.Size(292, 163);
            this.panelTwitchSettings.TabIndex = 2;
            this.panelTwitchSettings.Visible = false;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.cancelButton);
            this.panelButtons.Controls.Add(this.applyButton);
            this.panelButtons.Location = new System.Drawing.Point(0, 537);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(292, 109);
            this.panelButtons.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(23, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "USERNAME";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(23, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "PASSWORD";
            // 
            // panelColorPreview
            // 
            this.panelColorPreview.BackColor = System.Drawing.Color.White;
            this.panelColorPreview.Location = new System.Drawing.Point(263, 246);
            this.panelColorPreview.Name = "panelColorPreview";
            this.panelColorPreview.Size = new System.Drawing.Size(29, 28);
            this.panelColorPreview.TabIndex = 21;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(318, 685);
            this.Controls.Add(this.panelColorPreview);
            this.Controls.Add(this.refreshDrop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.skinDrop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.regionDrop);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.panelBackground);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.panelBackground.ResumeLayout(false);
            this.panelBackground.PerformLayout();
            this.panelTwitchSettings.ResumeLayout(false);
            this.panelTwitchSettings.PerformLayout();
            this.panelButtons.ResumeLayout(false);
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
        private System.Windows.Forms.Label lblTwitchSettings;
        private System.Windows.Forms.TextBox twitchChannelname;
        private System.Windows.Forms.TextBox twitchbotUsername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox twitchBotToken;
        private System.Windows.Forms.CheckBox twitchBotCheck;
        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panelColorPreview;
        private System.Windows.Forms.Panel panelTwitchSettings;
        private System.Windows.Forms.Panel panelButtons;
    }
}