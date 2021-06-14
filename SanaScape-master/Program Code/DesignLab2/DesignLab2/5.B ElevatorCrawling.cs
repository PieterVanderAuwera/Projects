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
    public partial class ElevatorCrawling : MetroForm
    {

        Timer timer = new Timer();
        int count_down = 202;
        int heartrate_before;
        int heartrate_after;

        public ElevatorCrawling()
        {
            InitializeComponent();
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"..\..\Story\Story 1\Sounds\Elevator crawling finished.wav");

            using (var soundPlayer = new SoundPlayer(path))
            {
                soundPlayer.Play();
            }
            SerialPort hrPort = Settings.hrPort;
            SerialPort gsrPort = Settings.gsrPort;
            hrPort.DataReceived += new SerialDataReceivedEventHandler(HRReceivedHandler);
            gsrPort.DataReceived += new SerialDataReceivedEventHandler(GSRReceivedHandler);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            count_down--;
            lblTimer.Text = count_down.ToString();
            if (count_down == 22)
            {
                heartrate_before = Settings.heartrate_before;
            }

            if (count_down <= -1)
            {
                count_down = 0;
                //txtHR.Text = Convert.ToString(Settings.test);
                heartrate_after = Settings.heartrate_after;
                if (heartrate_before <= heartrate_after)
                {
                    System.Threading.Thread.Sleep(3000);
                    this.Close();
                    RunningAwayFinished fo = new RunningAwayFinished();
                    fo.Show();
                    fo.Visible = true;
                }
                else
                {
                    System.Threading.Thread.Sleep(3000);
                    this.Close();
                    Story3_Basement fo = new Story3_Basement();
                    fo.Show();
                    fo.Visible = true;

                }

            }
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

        private void ElevatorCrawling_Load(object sender, EventArgs e)
        {

        }
    }
}
