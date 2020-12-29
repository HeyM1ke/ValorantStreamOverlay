
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rankIconBox = new System.Windows.Forms.PictureBox();
            this.rankPointsElo = new System.Windows.Forms.Label();
            this.rankingLabel = new System.Windows.Forms.Label();
            this.backgroundTop = new System.Windows.Forms.Panel();
            this.backgroundBot = new System.Windows.Forms.Panel();
            this.recentGame1 = new System.Windows.Forms.Label();
            this.recentGame2 = new System.Windows.Forms.Label();
            this.recentGame3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rankIconBox)).BeginInit();
            this.backgroundBot.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rankIconBox);
            this.panel1.Controls.Add(this.rankPointsElo);
            this.panel1.Controls.Add(this.rankingLabel);
            this.panel1.Controls.Add(this.backgroundTop);
            this.panel1.Controls.Add(this.backgroundBot);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(398, 143);
            this.panel1.TabIndex = 0;
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
            this.rankPointsElo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rankPointsElo.ForeColor = System.Drawing.Color.White;
            this.rankPointsElo.Location = new System.Drawing.Point(229, 10);
            this.rankPointsElo.Name = "rankPointsElo";
            this.rankPointsElo.Size = new System.Drawing.Size(202, 29);
            this.rankPointsElo.TabIndex = 2;
            this.rankPointsElo.Text = "99 RP | 2899 ELO";
            this.rankPointsElo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rankingLabel
            // 
            this.rankingLabel.AutoSize = true;
            this.rankingLabel.BackColor = System.Drawing.Color.Transparent;
            this.rankingLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rankingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rankingLabel.ForeColor = System.Drawing.Color.White;
            this.rankingLabel.Location = new System.Drawing.Point(0, 0);
            this.rankingLabel.Name = "rankingLabel";
            this.rankingLabel.Size = new System.Drawing.Size(245, 42);
            this.rankingLabel.TabIndex = 1;
            this.rankingLabel.Text = "IMMORTAL 3";
            this.rankingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // backgroundTop
            // 
            this.backgroundTop.Location = new System.Drawing.Point(0, 0);
            this.backgroundTop.Name = "backgroundTop";
            this.backgroundTop.Size = new System.Drawing.Size(399, 56);
            this.backgroundTop.TabIndex = 7;
            // 
            // backgroundBot
            // 
            this.backgroundBot.Controls.Add(this.recentGame1);
            this.backgroundBot.Controls.Add(this.recentGame2);
            this.backgroundBot.Controls.Add(this.recentGame3);
            this.backgroundBot.Location = new System.Drawing.Point(0, 0);
            this.backgroundBot.Name = "backgroundBot";
            this.backgroundBot.Size = new System.Drawing.Size(399, 143);
            this.backgroundBot.TabIndex = 8;
            // 
            // recentGame1
            // 
            this.recentGame1.AutoSize = true;
            this.recentGame1.BackColor = System.Drawing.Color.Black;
            this.recentGame1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.recentGame1.ForeColor = System.Drawing.Color.White;
            this.recentGame1.Location = new System.Drawing.Point(182, 76);
            this.recentGame1.Name = "recentGame1";
            this.recentGame1.Padding = new System.Windows.Forms.Padding(5);
            this.recentGame1.Size = new System.Drawing.Size(63, 39);
            this.recentGame1.TabIndex = 4;
            this.recentGame1.Text = "+00";
            // 
            // recentGame2
            // 
            this.recentGame2.AutoSize = true;
            this.recentGame2.BackColor = System.Drawing.Color.Black;
            this.recentGame2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.recentGame2.ForeColor = System.Drawing.Color.White;
            this.recentGame2.Location = new System.Drawing.Point(251, 76);
            this.recentGame2.Name = "recentGame2";
            this.recentGame2.Padding = new System.Windows.Forms.Padding(5);
            this.recentGame2.Size = new System.Drawing.Size(63, 39);
            this.recentGame2.TabIndex = 5;
            this.recentGame2.Text = "+00";
            // 
            // recentGame3
            // 
            this.recentGame3.AutoSize = true;
            this.recentGame3.BackColor = System.Drawing.Color.Black;
            this.recentGame3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.recentGame3.ForeColor = System.Drawing.Color.White;
            this.recentGame3.Location = new System.Drawing.Point(320, 76);
            this.recentGame3.Name = "recentGame3";
            this.recentGame3.Padding = new System.Windows.Forms.Padding(5);
            this.recentGame3.Size = new System.Drawing.Size(63, 39);
            this.recentGame3.TabIndex = 6;
            this.recentGame3.Text = "+00";
            // 
            // ValorantOverStream
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(398, 143);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ValorantOverStream";
            this.Text = "Valorant Overlay";
            this.Load += new System.EventHandler(this.ValorantOverStream_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rankIconBox)).EndInit();
            this.backgroundBot.ResumeLayout(false);
            this.backgroundBot.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label rankLabel;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label rankingLabel;
        public System.Windows.Forms.PictureBox rankIconBox;
        public System.Windows.Forms.Label rankPointsElo;
        public System.Windows.Forms.Label recentGame3;
        public System.Windows.Forms.Label recentGame2;
        public System.Windows.Forms.Panel backgroundBot;
        public System.Windows.Forms.Panel backgroundTop;
        public System.Windows.Forms.Label recentGame1;
    }
}

