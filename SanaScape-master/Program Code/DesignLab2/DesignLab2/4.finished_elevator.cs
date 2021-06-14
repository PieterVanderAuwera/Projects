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
    public partial class finished_elevator : MetroForm
    {
        public static int score_story1 { get; private set; }
        Timer timer = new Timer();
        int count_down = 65;
        int heartrate_before;
        int heartrate_after;


        public finished_elevator()
        {
            InitializeComponent();
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"..\..\Story\Story 1\Sounds\finished elevator.wav");

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
            // De speler krijgt de kans om zijn hartslag te laten stijgen (Doordat hij uit de lift kruipt), als zijn hartslag stijgt gaat hij naar de Scene "Elevator Crawling"
            // Als zijn harstlag daalt komt hij in de slechte scene ("Deel 1 Lift")
            if (count_down == 7)
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
                    ElevatorCrawling fo = new ElevatorCrawling();
                    fo.Show();
                    fo.Visible = true;
                }
                else
                {
                    System.Threading.Thread.Sleep(3000);
                    this.Close();
                    Story1_Lift fo = new Story1_Lift();
                    fo.Show();
                    fo.Visible = true;

                }

            }
        }

        private void finished_elevator_Load(object sender, EventArgs e)
        {

        }
    }
}
