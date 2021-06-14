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
    public partial class Generator : MetroForm
    {
        Timer timer = new Timer();
        int count_down = 29;

        public Generator()
        {
            InitializeComponent();
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"..\..\Story\Story 1\Sounds\generator.wav");
            using (var soundPlayer = new SoundPlayer(path))
            {
                soundPlayer.Play();
            }
            SerialPort hrPort = Settings.hrPort;
            SerialPort gsrPort = Settings.gsrPort;
            hrPort.DataReceived += new SerialDataReceivedEventHandler(HRReceivedHandler);
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
            }
            catch (Exception ex)
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
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            count_down--;
            lblTimer.Text = count_down.ToString();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home fo = new Home();
            fo.Visible = true;
        }

        private void Generator_Load(object sender, EventArgs e)
        {

        }
    }
}
