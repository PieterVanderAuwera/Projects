using MetroFramework.Forms;
using System;
using System.Diagnostics;
using System.IO.Ports;
using System.Windows.Forms;

namespace DesignLab2
{
    public partial class Settings : MetroForm
    {
        public static int heartrate_before { get; private set; }
        public static int heartrate_after { get; private set; }
        public static SerialPort hrPort { get; private set; }
        public static SerialPort gsrPort { get; private set; }
        private Home hm { get; set; }
        public Settings(Home home)
        {
            InitializeComponent();
            hm = home;
            string[] ports = SerialPort.GetPortNames();
            heartrate_before = 80;
            heartrate_after = 100;
            

            foreach (string port in ports)
            {
                cmbGSRComPort.Items.Add(port);
                cmbHRCom.Items.Add(port);
            }
        }
        private void gsrComPort_SelectedValueChanged(object sender, EventArgs e)
        {
            SerialPort port = new SerialPort();
            port.BaudRate = 9600;
            port.PortName = cmbGSRComPort.Text;
            gsrPort = port;
            gsrPort.Open();
            gsrPort.DataReceived += new SerialDataReceivedEventHandler(GSRReceivedHandler);
        }

        private void cmbHRCom_SelectedValueChanged(object sender, EventArgs e)
        {
            SerialPort p = new SerialPort();
            p.BaudRate = 115200;
            p.PortName = cmbHRCom.Text;
            hrPort = p;
            hrPort.Open();
            hrPort.DataReceived += new SerialDataReceivedEventHandler(HRReceivedHandler);

        }
        private void HRReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort p = (SerialPort)sender;
            string data = p.ReadLine();
            if(p.IsOpen)
            {
                try
                {
                    if (data.Contains("Heartrate"))
                    {
                        string[] d = data.Split(' ');
                        int hr = Int32.Parse(d[1]);
                        txtHrOut.BeginInvoke(new Action(() => { txtHrOut.Text = hr.ToString(); }));
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                }
            }
        }
        private void GSRReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort p = (SerialPort)sender;
            string data = p.ReadLine();
            if(p.IsOpen)
            {
                try
                {
                    gsrOut.BeginInvoke(new Action(() => { gsrOut.Text = data.ToString(); }));
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                }
            }
        }
        private void Settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            hm.Show();
            if(gsrPort != null && gsrPort.IsOpen)
            {
                gsrPort.Close();
            }
            if(hrPort != null && hrPort.IsOpen)
            {
                hrPort.Close();
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }
    }
}
