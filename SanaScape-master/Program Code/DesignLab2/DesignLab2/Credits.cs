using MetroFramework.Forms;
using System;

namespace DesignLab2
{
    public partial class Credits : MetroForm
    {
        public Credits()
        {
            InitializeComponent();
        }

        private void metroLabel10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home fo = new Home();
            fo.Visible = true;
        }

        private void Credits_Load(object sender, EventArgs e)
        {

        }
    }
}
