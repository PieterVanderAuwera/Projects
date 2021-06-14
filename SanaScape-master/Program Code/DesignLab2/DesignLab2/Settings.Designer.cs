namespace DesignLab2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbGSRComPort = new MetroFramework.Controls.MetroComboBox();
            this.lblGSR = new MetroFramework.Controls.MetroLabel();
            this.gsrOut = new MetroFramework.Controls.MetroTextBox();
            this.lblGSROut = new MetroFramework.Controls.MetroLabel();
            this.lblHrOut = new MetroFramework.Controls.MetroLabel();
            this.txtHrOut = new MetroFramework.Controls.MetroTextBox();
            this.lblHRCom = new MetroFramework.Controls.MetroLabel();
            this.cmbHRCom = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(144, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // cmbGSRComPort
            // 
            this.cmbGSRComPort.FormattingEnabled = true;
            this.cmbGSRComPort.ItemHeight = 23;
            this.cmbGSRComPort.Location = new System.Drawing.Point(14, 112);
            this.cmbGSRComPort.Name = "cmbGSRComPort";
            this.cmbGSRComPort.Size = new System.Drawing.Size(121, 29);
            this.cmbGSRComPort.TabIndex = 30;
            this.cmbGSRComPort.UseSelectable = true;
            this.cmbGSRComPort.SelectedValueChanged += new System.EventHandler(this.gsrComPort_SelectedValueChanged);
            // 
            // lblGSR
            // 
            this.lblGSR.AutoSize = true;
            this.lblGSR.Location = new System.Drawing.Point(14, 90);
            this.lblGSR.Name = "lblGSR";
            this.lblGSR.Size = new System.Drawing.Size(98, 19);
            this.lblGSR.TabIndex = 31;
            this.lblGSR.Text = "GSR Com Port:";
            // 
            // gsrOut
            // 
            // 
            // 
            // 
            this.gsrOut.CustomButton.Image = null;
            this.gsrOut.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.gsrOut.CustomButton.Name = "";
            this.gsrOut.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.gsrOut.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.gsrOut.CustomButton.TabIndex = 1;
            this.gsrOut.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.gsrOut.CustomButton.UseSelectable = true;
            this.gsrOut.CustomButton.Visible = false;
            this.gsrOut.Lines = new string[0];
            this.gsrOut.Location = new System.Drawing.Point(14, 166);
            this.gsrOut.MaxLength = 32767;
            this.gsrOut.Name = "gsrOut";
            this.gsrOut.PasswordChar = '\0';
            this.gsrOut.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gsrOut.SelectedText = "";
            this.gsrOut.SelectionLength = 0;
            this.gsrOut.SelectionStart = 0;
            this.gsrOut.ShortcutsEnabled = true;
            this.gsrOut.Size = new System.Drawing.Size(75, 23);
            this.gsrOut.TabIndex = 32;
            this.gsrOut.UseSelectable = true;
            this.gsrOut.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.gsrOut.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblGSROut
            // 
            this.lblGSROut.AutoSize = true;
            this.lblGSROut.Location = new System.Drawing.Point(14, 144);
            this.lblGSROut.Name = "lblGSROut";
            this.lblGSROut.Size = new System.Drawing.Size(115, 19);
            this.lblGSROut.TabIndex = 33;
            this.lblGSROut.Text = "Com Port Output:";
            // 
            // lblHrOut
            // 
            this.lblHrOut.AutoSize = true;
            this.lblHrOut.Location = new System.Drawing.Point(144, 144);
            this.lblHrOut.Name = "lblHrOut";
            this.lblHrOut.Size = new System.Drawing.Size(115, 19);
            this.lblHrOut.TabIndex = 37;
            this.lblHrOut.Text = "Com Port Output:";
            // 
            // txtHrOut
            // 
            // 
            // 
            // 
            this.txtHrOut.CustomButton.Image = null;
            this.txtHrOut.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtHrOut.CustomButton.Name = "";
            this.txtHrOut.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtHrOut.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtHrOut.CustomButton.TabIndex = 1;
            this.txtHrOut.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtHrOut.CustomButton.UseSelectable = true;
            this.txtHrOut.CustomButton.Visible = false;
            this.txtHrOut.Lines = new string[0];
            this.txtHrOut.Location = new System.Drawing.Point(144, 166);
            this.txtHrOut.MaxLength = 32767;
            this.txtHrOut.Name = "txtHrOut";
            this.txtHrOut.PasswordChar = '\0';
            this.txtHrOut.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtHrOut.SelectedText = "";
            this.txtHrOut.SelectionLength = 0;
            this.txtHrOut.SelectionStart = 0;
            this.txtHrOut.ShortcutsEnabled = true;
            this.txtHrOut.Size = new System.Drawing.Size(75, 23);
            this.txtHrOut.TabIndex = 36;
            this.txtHrOut.UseSelectable = true;
            this.txtHrOut.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtHrOut.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblHRCom
            // 
            this.lblHRCom.AutoSize = true;
            this.lblHRCom.Location = new System.Drawing.Point(144, 90);
            this.lblHRCom.Name = "lblHRCom";
            this.lblHRCom.Size = new System.Drawing.Size(91, 19);
            this.lblHRCom.TabIndex = 35;
            this.lblHRCom.Text = "HR Com Port:";
            // 
            // cmbHRCom
            // 
            this.cmbHRCom.FormattingEnabled = true;
            this.cmbHRCom.ItemHeight = 23;
            this.cmbHRCom.Location = new System.Drawing.Point(144, 112);
            this.cmbHRCom.Name = "cmbHRCom";
            this.cmbHRCom.Size = new System.Drawing.Size(121, 29);
            this.cmbHRCom.TabIndex = 34;
            this.cmbHRCom.UseSelectable = true;
            this.cmbHRCom.SelectedValueChanged += new System.EventHandler(this.cmbHRCom_SelectedValueChanged);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblHrOut);
            this.Controls.Add(this.txtHrOut);
            this.Controls.Add(this.lblHRCom);
            this.Controls.Add(this.cmbHRCom);
            this.Controls.Add(this.lblGSROut);
            this.Controls.Add(this.gsrOut);
            this.Controls.Add(this.lblGSR);
            this.Controls.Add(this.cmbGSRComPort);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Settings";
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "SanaScape";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Settings_FormClosed);
            this.Load += new System.EventHandler(this.Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroComboBox cmbGSRComPort;
        private MetroFramework.Controls.MetroLabel lblGSR;
        private MetroFramework.Controls.MetroTextBox gsrOut;
        private MetroFramework.Controls.MetroLabel lblGSROut;
        private MetroFramework.Controls.MetroLabel lblHrOut;
        private MetroFramework.Controls.MetroTextBox txtHrOut;
        private MetroFramework.Controls.MetroLabel lblHRCom;
        private MetroFramework.Controls.MetroComboBox cmbHRCom;
    }
}

