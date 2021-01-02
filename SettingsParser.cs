using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValorantStreamOverlay
{
    class SettingsParser
    {

        public async Task<string> ReadRegion(int regionName)
        {
            string region = "na";

            switch (regionName)
            {
                case 0:
                    region = "na";
                    break;
                case 1:
                    region = "eu";
                    break;
                case 2:
                    region = "kr";
                    break;
                case 3:
                    region = "ap";
                    break;
            }

            return region;
        }

        public async Task ReadSkin(int skinNumber)
        {
            //Depending on the skin number it will set the background image.
            //Implement var that accesses the resources to remove switch statement.
            

            switch (skinNumber)
            {
                case 0:
                    LogicHandler.ValorantOver.backgroundPic.Image = Properties.Resources.backgroundv2;
                    break;
                case 1:
                    LogicHandler.ValorantOver.backgroundPic.Image = Properties.Resources.bluebackground;
                    break;
                case 2:
                    LogicHandler.ValorantOver.backgroundPic.Image = Properties.Resources.lightbluebackground;
                    break;
                case 3:
                    LogicHandler.ValorantOver.backgroundPic.Image = Properties.Resources.greenbackground;
                    break;
                case 4:
                    LogicHandler.ValorantOver.backgroundPic.Image = Properties.Resources.purplebackground;
                    break;
                case 5:
                    LogicHandler.ValorantOver.backgroundPic.Image = Properties.Resources.graybackground;
                    break;
                case 6:
                    if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), "references", "custom.png")))
                    {
                        LogicHandler.ValorantOver.backgroundPic.Image = Image.FromFile(Path.Combine(Directory.GetCurrentDirectory(), "references", "custom.png"));
                    }
                    else
                    {
                        LogicHandler.ValorantOver.backgroundPic.Image = Properties.Resources.custom;
                    }
                    break;
            }
        }

        public async Task<int> ReadDelay(int delayNumber)
        {
            if (delayNumber != null)
            {
                switch (delayNumber)
                {
                    case 0:
                        return 30;
                    case 1:
                        return 60;
                }
            }

            return 30;



        }

        public async Task<bool> ReadTwitchBot()
        {
            //When Called start checking if settings are filling in.
            if (Properties.Settings.Default.twitchbotEnabled)
            {
                if (string.IsNullOrEmpty(Properties.Settings.Default.twitchBotUsername) ||
                    string.IsNullOrEmpty(Properties.Settings.Default.twitchChannel) ||
                    string.IsNullOrEmpty(Properties.Settings.Default.twitchBotToken))
                {
                    Properties.Settings.Default.twitchbotEnabled = false;
                    Properties.Settings.Default.Save();
                    MessageBox.Show("Twitch Bot Settings are missing, please fill in all fields to use");
                    Environment.Exit(1);
                }

                return true;
            }
            else
                return false;
        }
    }
}
