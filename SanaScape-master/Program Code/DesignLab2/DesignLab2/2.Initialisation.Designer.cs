namespace DesignLab2
{
    partial class Initialisation
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Initialisation));
            this.btnLaunchGame = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTimer = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtGSR = new MetroFramework.Controls.MetroTextBox();
            this.txtHR = new MetroFramework.Controls.MetroTextBox();
            this.lblHR = new MetroFramework.Controls.MetroLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroScore = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLaunchGame
            // 
            this.btnLaunchGame.DisplayFocus = true;
            this.btnLaunchGame.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnLaunchGame.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLaunchGame.Highlight = true;
            this.btnLaunchGame.Location = new System.Drawing.Point(356, 431);
            this.btnLaunchGame.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLaunchGame.Name = "btnLaunchGame";
            this.btnLaunchGame.Size = new System.Drawing.Size(291, 70);
            this.btnLaunchGame.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnLaunchGame.TabIndex = 24;
            this.btnLaunchGame.Text = "Launch Introduction";
            this.btnLaunchGame.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnLaunchGame.UseSelectable = true;
            this.btnLaunchGame.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(935, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(31, 89);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(203, 20);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroLabel1.TabIndex = 30;
            this.metroLabel1.Text = "Welcome to \"insert game here\"";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.UseMnemonic = false;
            this.metroLabel1.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(111, 127);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(708, 20);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroLabel2.TabIndex = 31;
            this.metroLabel2.Text = "Before we can start the game we will need to calculate some basic values using th" +
    "e GSR sensor and Pulse Sensor";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel2.UseMnemonic = false;
            this.metroLabel2.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(111, 162);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(694, 20);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroLabel3.TabIndex = 32;
            this.metroLabel3.Text = "Please be advised to stay calm during this initialisation phase as these results " +
    "will determine your difficulty level.";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel3.UseMnemonic = false;
            this.metroLabel3.UseStyleColors = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(111, 198);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(280, 20);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroLabel4.TabIndex = 33;
            this.metroLabel4.Text = "Timer remaining for retreiving basic values: ";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel4.UseMnemonic = false;
            this.metroLabel4.UseStyleColors = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblTimer.Location = new System.Drawing.Point(472, 198);
            this.lblTimer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(27, 20);
            this.lblTimer.TabIndex = 34;
            this.lblTimer.Text = "20";
            this.lblTimer.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblTimer.Click += new System.EventHandler(this.lblTimer_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(513, 198);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(61, 20);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroLabel6.TabIndex = 35;
            this.metroLabel6.Text = "Seconds";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel6.UseMnemonic = false;
            this.metroLabel6.UseStyleColors = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(72, 273);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(116, 25);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroLabel5.TabIndex = 36;
            this.metroLabel5.Text = "GSR Values:";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel5.UseStyleColors = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.Location = new System.Drawing.Point(803, 273);
            this.metroLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(126, 25);
            this.metroLabel7.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroLabel7.TabIndex = 37;
            this.metroLabel7.Text = "Pulse Values:";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel7.UseStyleColors = true;
            // 
            // txtGSR
            // 
            // 
            // 
            // 
            this.txtGSR.CustomButton.Image = null;
            this.txtGSR.CustomButton.Location = new System.Drawing.Point(140, 2);
            this.txtGSR.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGSR.CustomButton.Name = "";
            this.txtGSR.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.txtGSR.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGSR.CustomButton.TabIndex = 1;
            this.txtGSR.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGSR.CustomButton.UseSelectable = true;
            this.txtGSR.CustomButton.Visible = false;
            this.txtGSR.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtGSR.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtGSR.Lines = new string[] {
        "0"};
            this.txtGSR.Location = new System.Drawing.Point(91, 321);
            this.txtGSR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGSR.MaxLength = 32767;
            this.txtGSR.Name = "txtGSR";
            this.txtGSR.PasswordChar = '\0';
            this.txtGSR.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGSR.SelectedText = "";
            this.txtGSR.SelectionLength = 0;
            this.txtGSR.SelectionStart = 0;
            this.txtGSR.ShortcutsEnabled = true;
            this.txtGSR.Size = new System.Drawing.Size(131, 28);
            this.txtGSR.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtGSR.TabIndex = 38;
            this.txtGSR.Text = "0";
            this.txtGSR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGSR.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtGSR.UseSelectable = true;
            this.txtGSR.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGSR.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtHR
            // 
            // 
            // 
            // 
            this.txtHR.CustomButton.Image = null;
            this.txtHR.CustomButton.Location = new System.Drawing.Point(140, 2);
            this.txtHR.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHR.CustomButton.Name = "";
            this.txtHR.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.txtHR.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtHR.CustomButton.TabIndex = 1;
            this.txtHR.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtHR.CustomButton.UseSelectable = true;
            this.txtHR.CustomButton.Visible = false;
            this.txtHR.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtHR.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtHR.Lines = new string[] {
        "0"};
            this.txtHR.Location = new System.Drawing.Point(860, 326);
            this.txtHR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHR.MaxLength = 32767;
            this.txtHR.Name = "txtHR";
            this.txtHR.PasswordChar = '\0';
            this.txtHR.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtHR.SelectedText = "";
            this.txtHR.SelectionLength = 0;
            this.txtHR.SelectionStart = 0;
            this.txtHR.ShortcutsEnabled = true;
            this.txtHR.Size = new System.Drawing.Size(131, 28);
            this.txtHR.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtHR.TabIndex = 40;
            this.txtHR.Text = "0";
            this.txtHR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHR.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtHR.UseSelectable = true;
            this.txtHR.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtHR.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtHR.Click += new System.EventHandler(this.txtHR_Click);
            // 
            // lblHR
            // 
            this.lblHR.AutoSize = true;
            this.lblHR.Location = new System.Drawing.Point(752, 326);
            this.lblHR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHR.Name = "lblHR";
            this.lblHR.Size = new System.Drawing.Size(79, 20);
            this.lblHR.Style = MetroFramework.MetroColorStyle.Lime;
            this.lblHR.TabIndex = 45;
            this.lblHR.Text = "Hearthrate:";
            this.lblHR.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblHR.UseMnemonic = false;
            this.lblHR.UseStyleColors = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(31, 127);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 47;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel11.Location = new System.Drawing.Point(437, 273);
            this.metroLabel11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(67, 25);
            this.metroLabel11.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroLabel11.TabIndex = 48;
            this.metroLabel11.Text = "Score:";
            this.metroLabel11.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel11.UseStyleColors = true;
            // 
            // metroScore
            // 
            // 
            // 
            // 
            this.metroScore.CustomButton.Image = null;
            this.metroScore.CustomButton.Location = new System.Drawing.Point(140, 2);
            this.metroScore.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroScore.CustomButton.Name = "";
            this.metroScore.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.metroScore.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroScore.CustomButton.TabIndex = 1;
            this.metroScore.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroScore.CustomButton.UseSelectable = true;
            this.metroScore.CustomButton.Visible = false;
            this.metroScore.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroScore.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.metroScore.Lines = new string[] {
        "0"};
            this.metroScore.Location = new System.Drawing.Point(420, 321);
            this.metroScore.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroScore.MaxLength = 32767;
            this.metroScore.Name = "metroScore";
            this.metroScore.PasswordChar = '\0';
            this.metroScore.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroScore.SelectedText = "";
            this.metroScore.SelectionLength = 0;
            this.metroScore.SelectionStart = 0;
            this.metroScore.ShortcutsEnabled = true;
            this.metroScore.Size = new System.Drawing.Size(131, 28);
            this.metroScore.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroScore.TabIndex = 49;
            this.metroScore.Text = "0";
            this.metroScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroScore.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroScore.UseSelectable = true;
            this.metroScore.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroScore.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Initialisation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.metroScore);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblHR);
            this.Controls.Add(this.txtHR);
            this.Controls.Add(this.txtGSR);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLaunchGame);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Initialisation";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "SanaScape";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Initialisation_FormClosed);
            this.Load += new System.EventHandler(this.Initialisation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnLaunchGame;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroLabel lblTimer;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txtGSR;
        private MetroFramework.Controls.MetroTextBox txtHR;
        private MetroFramework.Controls.MetroLabel lblHR;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox metroScore;
    }
}

