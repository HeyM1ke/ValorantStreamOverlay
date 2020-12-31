using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValorantStreamOverlay
{
    public partial class ValorantOverStream : Form
    {
        //https://stackoverflow.com/a/24561946/908
        private bool mouseDown;
        private Point lastLocation;

        public ValorantOverStream()
        {
            InitializeComponent();
        }

        

        private void ValorantOverStream_Load(object sender, EventArgs e)
        {
            //Check For updates
            new Updator();

            //Application.SetHighDpiMode(HighDpiMode.SystemAware);
            backgroundPic.ContextMenuStrip = contextMenu;
            rankingLabel.Parent = backgroundPic;
            rankingLabel.BackColor = Color.Transparent;
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(Path.Combine(Directory.GetCurrentDirectory(), "references", "Anton.ttf"));
            rankingLabel.Font = new Font(pfc.Families[0], 28, FontStyle.Regular);
            
            //On Load, Set backing and Fonts to labels displaying Rank changes.
            Label[] rankChanges = {recentGame1, recentGame2, recentGame3};
            foreach (var recentC in rankChanges)
            {
                recentC.Parent = backgroundPic;
                recentC.BackColor = Color.Transparent;
                recentC.Font = new Font(pfc.Families[0], 14, FontStyle.Regular);
            }

            rankIconBox.Parent = backgroundPic;
            rankIconBox.BackColor = Color.Transparent;

            //Add Rank elo point label, set font and parent.. brb
            rankPointsElo.BackColor = Color.Transparent;
            rankPointsElo.Parent = backgroundPic;
            rankPointsElo.Font = new Font(pfc.Families[0], 18);


            if (Properties.Settings.Default.hideTitleBar)
            {
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            }
            var opacity = Properties.Settings.Default.opacity;
            this.Opacity = (double)opacity / 100;

            ValorantOverStream local = this;
            LogicHandler logic = new LogicHandler(local);



        }
        private void ValorantOverStream_Shown(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.alwaysOnTop) 
            {
                this.TopMost = true; 
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void settingsMenuItem_Click(object sender, EventArgs e)
        {
            Settings settingsPage = new Settings();
            settingsPage.ShowDialog();

        }
        private void closeMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ValorantOverStream_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void ValorantOverStream_MouseMove(object sender, MouseEventArgs e)
        {
            if(mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void ValorantOverStream_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
