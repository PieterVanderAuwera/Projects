using MetroFramework.Forms;
using System;
using System.Diagnostics;
using System.IO;
using System.IO.Ports;
using System.Media;
using System.Reflection;
using System.Windows.Forms;

namespace DesignLab2
{
    public partial class Initialisation : MetroForm
    {
        public static int score { get; private set; }
        SerialPort hrPort = Settings.hrPort;
        SerialPort gsrPort = Settings.gsrPort;
        int count_down = 20;

        public Initialisation()
        {
            InitializeComponent();
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"..\..\Story\Initialisation\Elevator_trim.wav");
            using (var soundPlayer = new SoundPlayer(path))
            {
                soundPlayer.Play();
            }
            score = 0;
            metroScore.Text = Convert.ToString(score);
            hrPort.Open();
            hrPort.DataReceived += new SerialDataReceivedEventHandler(HRReceivedHandler);
            gsrPort.Open();
            gsrPort.DataReceived += new SerialDataReceivedEventHandler(GSRReceivedHandler);
        }
        private void HRReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort p = (SerialPort)sender;
            string data = p.ReadLine();
            try
            {
                if (data.Contains("Heartrate"))
                {
                    string[] d = data.Split(' ');
                    int hr = Int32.Parse(d[1]);
                    txtHR.BeginInvoke(new Action(() => { txtHR.Text = hr.ToString(); }));
                }
            } catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }
        private void GSRReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort p = (SerialPort)sender;
            string data = p.ReadLine();
            try
            {
                txtGSR.BeginInvoke(new Action(() => { txtGSR.Text = data.ToString(); }));
            } catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }
        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Introduction fo = new Introduction();
            fo.Visible = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            count_down--;
            lblTimer.Text = count_down.ToString();
            if (count_down <= -1)
            {

                System.Threading.Thread.Sleep(2000);
                this.Close();
                Introduction fo = new Introduction();
                fo.Show();
                fo.Visible = true;
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home fo = new Home();
            fo.Visible = true;
        }

        private void Initialisation_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (gsrPort != null && gsrPort.IsOpen)
            {
                gsrPort.Close();
            }
            if (hrPort != null && hrPort.IsOpen)
            {
                hrPort.Close();
            }
        }

        private void Initialisation_Load(object sender, EventArgs e)
        {

        }

        private void txtHR_Click(object sender, EventArgs e)
        {

        }

        private void lblTimer_Click(object sender, EventArgs e)
        {

        }
    }
}
