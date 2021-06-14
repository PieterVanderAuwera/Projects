using MetroFramework.Forms;
using System;

namespace DesignLab2
{
    public partial class Home : MetroForm
    {
        public Home()
        {
            InitializeComponent();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Credits fo = new Credits();
            fo.Visible = true;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Initialisation fo = new Initialisation();
            fo.Visible = true;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Settings fo = new Settings(this);
            fo.Visible = true;
        }
    }
}
