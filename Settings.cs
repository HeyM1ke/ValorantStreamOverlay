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
            HideTwitchSettings();
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

        private void skinDrop_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (skinDrop.SelectedIndex)
            {
                case 0:
                    panelColorPreview.BackColor = System.Drawing.ColorTranslator.FromHtml(Utils.COLOR_RED);
                    break;
                case 1:
                    panelColorPreview.BackColor = System.Drawing.ColorTranslator.FromHtml(Utils.COLOR_BLUE);
                    break;
                case 2:
                    panelColorPreview.BackColor = System.Drawing.ColorTranslator.FromHtml(Utils.COLOR_LIGHTBLUE);
                    break;
                case 3:
                    panelColorPreview.BackColor = System.Drawing.ColorTranslator.FromHtml(Utils.COLOR_GREEN);
                    break;
                case 4:
                    panelColorPreview.BackColor = System.Drawing.ColorTranslator.FromHtml(Utils.COLOR_PURPLE);
                    break;
                case 5:
                    panelColorPreview.BackColor = System.Drawing.ColorTranslator.FromHtml(Utils.COLOR_GRAY);
                    break;
                default:
                    panelColorPreview.BackColor = System.Drawing.ColorTranslator.FromHtml(Utils.COLOR_GRAY);
                    break;
            }
        }

        private void lblTwitchSettings_Click(object sender, EventArgs e)
        {
            if (panelTwitchSettings.Visible)
            {
                HideTwitchSettings();
            }
            else
            {
                ShowTwitchSettings();
            }
        }

        private void HideTwitchSettings()
        {
            panelTwitchSettings.Visible = false;
            panelButtons.Location = new Point(panelTwitchSettings.Location.X, lblTwitchSettings.Location.Y + 30);
            panelBackground.Size = new Size(panelBackground.Width, panelButtons.Location.Y + panelButtons.Size.Height + 10);
            this.Size = new Size(this.Size.Width, panelButtons.Location.Y + panelButtons.Size.Height + 75);
        }

        private void ShowTwitchSettings()
        {
            panelTwitchSettings.Visible = true;
            panelButtons.Location = new Point(panelTwitchSettings.Location.X, panelTwitchSettings.Location.Y + panelTwitchSettings.Size.Height + 5);
            panelBackground.Size = new Size(panelBackground.Width, panelButtons.Location.Y + panelButtons.Size.Height + 10);
            this.Size = new Size(this.Size.Width, panelBackground.Size.Height + 75);
        }
    }
}
