
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
            this.SuspendLayout();
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(12, 12);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.PlaceholderText = "Riot Games Username";
            this.usernameTextBox.Size = new System.Drawing.Size(199, 23);
            this.usernameTextBox.TabIndex = 0;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(108, 161);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // applyButton
            // 
            this.applyButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.applyButton.Location = new System.Drawing.Point(27, 161);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 23);
            this.applyButton.TabIndex = 2;
            this.applyButton.Text = "APPLY";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(12, 41);
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
            "North America",
            "Europe",
            "Korea",
            "Asia Pacific"});
            this.regionDrop.Location = new System.Drawing.Point(77, 70);
            this.regionDrop.Name = "regionDrop";
            this.regionDrop.Size = new System.Drawing.Size(134, 23);
            this.regionDrop.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Region:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 101);
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
            this.skinDrop.Location = new System.Drawing.Point(77, 101);
            this.skinDrop.Name = "skinDrop";
            this.skinDrop.Size = new System.Drawing.Size(134, 23);
            this.skinDrop.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 132);
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
            this.refreshDrop.Location = new System.Drawing.Point(77, 132);
            this.refreshDrop.Name = "refreshDrop";
            this.refreshDrop.Size = new System.Drawing.Size(134, 23);
            this.refreshDrop.TabIndex = 9;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(229, 199);
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
    }
}