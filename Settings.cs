using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ValorantStreamOverlay
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            ApplySettings();
        }


        void ApplySettings()
        {
            // Save Overlay Settings
            Properties.Settings.Default.username = usernameTextBox.Text;
            Properties.Settings.Default.password = passwordTextBox.Text;
            Properties.Settings.Default.region = regionDrop.SelectedIndex;
            Properties.Settings.Default.skin = skinDrop.SelectedIndex;
            Properties.Settings.Default.refresh = refreshDrop.SelectedIndex;
            Properties.Settings.Default.language = languageDrop.SelectedIndex;

            // Save Twitch bot settings
            Properties.Settings.Default.twitchbotEnabled = twitchBotCheck.Checked;
            Properties.Settings.Default.twitchBotToken = twitchBotToken.Text;
            Properties.Settings.Default.twitchBotUsername = twitchbotUsername.Text;
            Properties.Settings.Default.twitchChannel = twitchChannelname.Text;

            Properties.Settings.Default.Save();
            //After Setting user inputs to settings, ask user to reboot program :)
            DialogResult dialogResult =
                MessageBox.Show("Please reboot overlay, for new settings to apply.", "Reboot to apply", MessageBoxButtons.OK);

            if (dialogResult == DialogResult.OK)
                Environment.Exit(1);
            else
                Environment.Exit(1);




        }

        private void Settings_Load(object sender, EventArgs e)
        {
            //Overlay Loading
            usernameTextBox.Text = Properties.Settings.Default.username;
            passwordTextBox.Text = Properties.Settings.Default.password;
            regionDrop.SelectedIndex = Properties.Settings.Default.region;
            skinDrop.SelectedIndex = Properties.Settings.Default.skin;
            refreshDrop.SelectedIndex = Properties.Settings.Default.refresh;
            languageDrop.SelectedIndex = Properties.Settings.Default.language;
            
            //Twitch Bot Loading
            twitchChannelname.Text = Properties.Settings.Default.twitchChannel;
            twitchBotToken.Text = Properties.Settings.Default.twitchBotToken;
            twitchbotUsername.Text = Properties.Settings.Default.twitchBotUsername;
            twitchBotCheck.Checked = Properties.Settings.Default.twitchbotEnabled;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabControl1.SelectedTab.Controls.Add(applyButton);
            tabControl1.SelectedTab.Controls.Add(cancelButton);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void applyButton_Click_1(object sender, EventArgs e)
        {

        }
    }
}
