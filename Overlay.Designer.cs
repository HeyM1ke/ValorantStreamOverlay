
namespace ValorantStreamOverlay
{
    partial class ValorantOverStream
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ValorantOverStream));
            this.panel1 = new System.Windows.Forms.Panel();
            this.recentGame3 = new System.Windows.Forms.Label();
            this.recentGame2 = new System.Windows.Forms.Label();
            this.recentGame1 = new System.Windows.Forms.Label();
            this.rankIconBox = new System.Windows.Forms.PictureBox();
            this.rankPointsElo = new System.Windows.Forms.Label();
            this.rankingLabel = new System.Windows.Forms.Label();
            this.backgroundPic = new System.Windows.Forms.PictureBox();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.settingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rankIconBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundPic)).BeginInit();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.recentGame3);
            this.panel1.Controls.Add(this.recentGame2);
            this.panel1.Controls.Add(this.recentGame1);
            this.panel1.Controls.Add(this.rankIconBox);
            this.panel1.Controls.Add(this.rankPointsElo);
            this.panel1.Controls.Add(this.rankingLabel);
            this.panel1.Controls.Add(this.backgroundPic);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(398, 143);
            this.panel1.TabIndex = 0;
            // 
            // recentGame3
            // 
            this.recentGame3.AutoSize = true;
            this.recentGame3.BackColor = System.Drawing.Color.Black;
            this.recentGame3.Font = new System.Drawing.Font("Anton", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.recentGame3.ForeColor = System.Drawing.Color.White;
            this.recentGame3.Location = new System.Drawing.Point(346, 86);
            this.recentGame3.Name = "recentGame3";
            this.recentGame3.Size = new System.Drawing.Size(48, 36);
            this.recentGame3.TabIndex = 6;
            this.recentGame3.Text = "+00";
            // 
            // recentGame2
            // 
            this.recentGame2.AutoSize = true;
            this.recentGame2.BackColor = System.Drawing.Color.Black;
            this.recentGame2.Font = new System.Drawing.Font("Anton", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.recentGame2.ForeColor = System.Drawing.Color.White;
            this.recentGame2.Location = new System.Drawing.Point(285, 86);
            this.recentGame2.Name = "recentGame2";
            this.recentGame2.Size = new System.Drawing.Size(48, 36);
            this.recentGame2.TabIndex = 5;
            this.recentGame2.Text = "+00";
            // 
            // recentGame1
            // 
            this.recentGame1.AutoSize = true;
            this.recentGame1.BackColor = System.Drawing.Color.Black;
            this.recentGame1.Font = new System.Drawing.Font("Anton", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.recentGame1.ForeColor = System.Drawing.Color.White;
            this.recentGame1.Location = new System.Drawing.Point(225, 86);
            this.recentGame1.Name = "recentGame1";
            this.recentGame1.Size = new System.Drawing.Size(48, 36);
            this.recentGame1.TabIndex = 4;
            this.recentGame1.Text = "+00";
            // 
            // rankIconBox
            // 
            this.rankIconBox.BackColor = System.Drawing.Color.Transparent;
            this.rankIconBox.Image = ((System.Drawing.Image)(resources.GetObject("rankIconBox.Image")));
            this.rankIconBox.Location = new System.Drawing.Point(12, 67);
            this.rankIconBox.Name = "rankIconBox";
            this.rankIconBox.Size = new System.Drawing.Size(65, 65);
            this.rankIconBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rankIconBox.TabIndex = 3;
            this.rankIconBox.TabStop = false;
            // 
            // rankPointsElo
            // 
            this.rankPointsElo.AutoSize = true;
            this.rankPointsElo.Font = new System.Drawing.Font("Anton", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rankPointsElo.ForeColor = System.Drawing.Color.White;
            this.rankPointsElo.Location = new System.Drawing.Point(216, 9);
            this.rankPointsElo.Name = "rankPointsElo";
            this.rankPointsElo.Size = new System.Drawing.Size(182, 36);
            this.rankPointsElo.TabIndex = 2;
            this.rankPointsElo.Text = "000 RP | 0000 ELO";
            this.rankPointsElo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rankingLabel
            // 
            this.rankingLabel.AutoSize = true;
            this.rankingLabel.BackColor = System.Drawing.Color.Transparent;
            this.rankingLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rankingLabel.Font = new System.Drawing.Font("Anton", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rankingLabel.ForeColor = System.Drawing.Color.White;
            this.rankingLabel.Location = new System.Drawing.Point(0, 0);
            this.rankingLabel.Name = "rankingLabel";
            this.rankingLabel.Size = new System.Drawing.Size(125, 56);
            this.rankingLabel.TabIndex = 1;
            this.rankingLabel.Text = "INVALID";
            this.rankingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // backgroundPic
            // 
            this.backgroundPic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.backgroundPic.BackColor = System.Drawing.Color.White;
            this.backgroundPic.Image = ((System.Drawing.Image)(resources.GetObject("backgroundPic.Image")));
            this.backgroundPic.Location = new System.Drawing.Point(0, 0);
            this.backgroundPic.Name = "backgroundPic";
            this.backgroundPic.Size = new System.Drawing.Size(398, 143);
            this.backgroundPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backgroundPic.TabIndex = 0;
            this.backgroundPic.TabStop = false;
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsMenuItem});
            this.contextMenu.Name = "contextMenuStrip1";
            this.contextMenu.Size = new System.Drawing.Size(117, 26);
            // 
            // settingsMenuItem
            // 
            this.settingsMenuItem.CheckOnClick = true;
            this.settingsMenuItem.Name = "settingsMenuItem";
            this.settingsMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsMenuItem.Text = "Settings";
            this.settingsMenuItem.Click += new System.EventHandler(this.settingsMenuItem_Click);
            // 
            // ValorantOverStream
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(398, 143);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ValorantOverStream";
            this.Text = "Valorant Overlay";
            this.Load += new System.EventHandler(this.ValorantOverStream_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rankIconBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundPic)).EndInit();
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label rankLabel;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label rankingLabel;
        public System.Windows.Forms.PictureBox rankIconBox;
        public System.Windows.Forms.Label rankPointsElo;
        public System.Windows.Forms.Label recentGame1;
        public System.Windows.Forms.Label recentGame3;
        public System.Windows.Forms.Label recentGame2;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        public System.Windows.Forms.ToolStripMenuItem settingsMenuItem;
        public System.Windows.Forms.PictureBox backgroundPic;
    }
}

