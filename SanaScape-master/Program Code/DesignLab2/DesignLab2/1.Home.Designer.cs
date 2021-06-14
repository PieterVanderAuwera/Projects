namespace DesignLab2
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.btnPlay = new MetroFramework.Controls.MetroButton();
            this.btnSettings = new MetroFramework.Controls.MetroButton();
            this.btnCredits = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.DisplayFocus = true;
            this.btnPlay.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnPlay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPlay.Highlight = true;
            this.btnPlay.Location = new System.Drawing.Point(272, 164);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(218, 57);
            this.btnPlay.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnPlay.TabIndex = 24;
            this.btnPlay.Text = "Play Game";
            this.btnPlay.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnPlay.UseSelectable = true;
            this.btnPlay.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.DisplayFocus = true;
            this.btnSettings.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnSettings.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSettings.Highlight = true;
            this.btnSettings.Location = new System.Drawing.Point(272, 238);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(218, 57);
            this.btnSettings.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnSettings.TabIndex = 25;
            this.btnSettings.Text = "Settings";
            this.btnSettings.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnSettings.UseSelectable = true;
            this.btnSettings.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // btnCredits
            // 
            this.btnCredits.DisplayFocus = true;
            this.btnCredits.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnCredits.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCredits.Highlight = true;
            this.btnCredits.Location = new System.Drawing.Point(272, 311);
            this.btnCredits.Name = "btnCredits";
            this.btnCredits.Size = new System.Drawing.Size(218, 57);
            this.btnCredits.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnCredits.TabIndex = 26;
            this.btnCredits.Text = "Credits";
            this.btnCredits.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnCredits.UseSelectable = true;
            this.btnCredits.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(317, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCredits);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnPlay);
            this.Name = "Home";
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "SanaScape";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnPlay;
        private MetroFramework.Controls.MetroButton btnSettings;
        private MetroFramework.Controls.MetroButton btnCredits;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

