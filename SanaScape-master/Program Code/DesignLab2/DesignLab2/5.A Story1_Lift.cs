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
    public partial class Story1_Lift : MetroForm
    {
        public static int score_story1 { get; private set; }
        Timer timer = new Timer();
        int count_down = 33;

        public Story1_Lift()
        {
            InitializeComponent();
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"..\..\Story\Story 1\Sounds\Deel 1 lift.wav");
            using (var soundPlayer1 = new SoundPlayer(path))
            {
                soundPlayer1.Play();
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
                System.Threading.Thread.Sleep(3000);
                this.Close();
                RoyLobby fo = new RoyLobby();
                fo.Show();
                fo.Visible = true;

            }
        }

        private void txtHR_Click(object sender, EventArgs e)
        {

        }

        private void txtGSR_Click(object sender, EventArgs e)
        {

        }

        private void Story1_Lift_Load(object sender, EventArgs e)
        {

        }
    }
}
