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
            Properties.Settings.Default.username = usernameTextBox.Text;
            Properties.Settings.Default.password = passwordTextBox.Text;
            Properties.Settings.Default.region = regionDrop.SelectedIndex;
            Properties.Settings.Default.skin = skinDrop.SelectedIndex;
            Properties.Settings.Default.refresh = refreshDrop.SelectedIndex;
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
            usernameTextBox.Text = Properties.Settings.Default.username;
            passwordTextBox.Text = Properties.Settings.Default.password;
            regionDrop.SelectedIndex = Properties.Settings.Default.region;
            skinDrop.SelectedIndex = Properties.Settings.Default.skin;
            refreshDrop.SelectedIndex = Properties.Settings.Default.refresh;
        }
    }
}
