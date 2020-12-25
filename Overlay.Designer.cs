
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ValorantOverStream));
            this.backgroundPic = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rankIconBox = new System.Windows.Forms.PictureBox();
            this.recentGame3 = new System.Windows.Forms.Label();
            this.recentGame2 = new System.Windows.Forms.Label();
            this.recentGame1 = new System.Windows.Forms.Label();
            this.rankingLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundPic)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rankIconBox)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundPic
            // 
            this.backgroundPic.Image = Properties.Resources.Background;//((System.Drawing.Image)(resources.GetObject("backgroundPic.Image")));
            this.backgroundPic.Location = new System.Drawing.Point(0, 0);
            this.backgroundPic.Name = "backgroundPic";
            this.backgroundPic.Size = new System.Drawing.Size(315, 120);
            this.backgroundPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backgroundPic.TabIndex = 0;
            this.backgroundPic.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.rankIconBox);
            this.panel1.Controls.Add(this.recentGame3);
            this.panel1.Controls.Add(this.recentGame2);
            this.panel1.Controls.Add(this.recentGame1);
            this.panel1.Controls.Add(this.rankingLabel);
            this.panel1.Controls.Add(this.backgroundPic);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 120);
            this.panel1.TabIndex = 1;
            // 
            // rankIconBox
            // 
            this.rankIconBox.BackColor = System.Drawing.Color.Bisque;
            this.rankIconBox.Image = Properties.Resources.TX_CompetitiveTier_Large_14;//((System.Drawing.Image)(resources.GetObject("rankIconBox.Image")));
            this.rankIconBox.Location = new System.Drawing.Point(205, 10);
            this.rankIconBox.Name = "rankIconBox";
            this.rankIconBox.Size = new System.Drawing.Size(100, 100);
            this.rankIconBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rankIconBox.TabIndex = 4;
            this.rankIconBox.TabStop = false;
            // 
            // recentGame3
            // 
            this.recentGame3.AutoSize = true;
            this.recentGame3.Font = new System.Drawing.Font("Anton", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.recentGame3.ForeColor = System.Drawing.Color.Green;
            this.recentGame3.Location = new System.Drawing.Point(93, 76);
            this.recentGame3.Name = "recentGame3";
            this.recentGame3.Size = new System.Drawing.Size(30, 28);
            this.recentGame3.TabIndex = 3;
            this.recentGame3.Text = "00";
            this.recentGame3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // recentGame2
            // 
            this.recentGame2.AutoSize = true;
            this.recentGame2.Font = new System.Drawing.Font("Anton", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.recentGame2.ForeColor = System.Drawing.Color.Red;
            this.recentGame2.Location = new System.Drawing.Point(52, 76);
            this.recentGame2.Name = "recentGame2";
            this.recentGame2.Size = new System.Drawing.Size(30, 28);
            this.recentGame2.TabIndex = 2;
            this.recentGame2.Text = "00";
            this.recentGame2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // recentGame1
            // 
            this.recentGame1.AutoSize = true;
            this.recentGame1.Font = new System.Drawing.Font("Anton", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.recentGame1.ForeColor = System.Drawing.Color.SpringGreen;
            this.recentGame1.Location = new System.Drawing.Point(12, 76);
            this.recentGame1.Name = "recentGame1";
            this.recentGame1.Size = new System.Drawing.Size(30, 28);
            this.recentGame1.TabIndex = 1;
            this.recentGame1.Text = "00";
            this.recentGame1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rankingLabel
            // 
            this.rankingLabel.AutoSize = true;
            this.rankingLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rankingLabel.Font = new System.Drawing.Font("Anton", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rankingLabel.ForeColor = System.Drawing.Color.White;
            this.rankingLabel.Location = new System.Drawing.Point(0, -3);
            this.rankingLabel.Name = "rankingLabel";
            this.rankingLabel.Size = new System.Drawing.Size(199, 56);
            this.rankingLabel.TabIndex = 0;
            this.rankingLabel.Text = "IMMORTAL 3";
            // 
            // ValorantOverStream
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(341, 147);
            this.Controls.Add(this.panel1);
            this.Name = "ValorantOverStream";
            this.Text = "Valorant Overlay";
            this.Load += new System.EventHandler(this.ValorantOverStream_Load);
            ((System.ComponentModel.ISupportInitialize)(this.backgroundPic)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rankIconBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox backgroundPic;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label rankLabel;
        public System.Windows.Forms.Label rankingLabel;
        public System.Windows.Forms.Label recentGame1;
        public System.Windows.Forms.Label recentGame3;
        public System.Windows.Forms.Label recentGame2;
        public System.Windows.Forms.PictureBox rankIconBox;
    }
}

