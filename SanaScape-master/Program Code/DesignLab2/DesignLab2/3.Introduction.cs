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
    public partial class Introduction : MetroForm
    {
        Timer timer = new Timer();
        int count_down = 45;

        public Introduction()
        {
            InitializeComponent();
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"..\..\Story\Story 1\Sounds\Introductie.wav");
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
            if (count_down <= -1)
            {
                System.Threading.Thread.Sleep(2000);
                this.Close();
                finished_elevator fo = new finished_elevator();
                fo.Show();
                fo.Visible = true;
            }
        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
      

        private void lblTimer_Click(object sender, EventArgs e)
        {

        }

        private void Introduction_Load(object sender, EventArgs e)
        {

        }
    }
}
