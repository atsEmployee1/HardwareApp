using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HardwareApp
{
    public partial class Form1 : Form
    {
        private AxSysJobRunner _jobRunner;
        private SerialPort axsysPort;

        public Form1()
        {
            InitializeComponent();
            string axEnginePath = @"C:\Program Files\BioDot\AxSys\AxEngine.exe";
            string jobDirectory = @"C:\AxSysScripts"; 

        _jobRunner = new AxSysJobRunner(axEnginePath, jobDirectory);

            // Generate test job on load (you can skip this in production)
            var jobLines = new[]
            {
                "; Simple Z-axis test",
                "GOTO Z=1000",
                "WAIT 200",
                "GOTO Z=0",
                "WAIT 200"
            };

            string jobPath = _jobRunner.GenerateJobScript("TestZMove.ad", jobLines);
            txtJobPreview.Text = File.ReadAllText(jobPath);

        }

        private void btnRunJob_Click(object sender, EventArgs e)
        {
            string jobPath = Path.Combine(@"C:\AxSysScripts", "TestZMove.ad");

            if (_jobRunner.RunJob(jobPath, out string error))
            {
                lblJobStatus.Text = "Job completed successfully.";
                lblJobStatus.ForeColor = Color.Green;
            }
            else
            {
                lblJobStatus.Text = "Job failed: " + error;
                lblJobStatus.ForeColor = Color.Red;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InitializeAxsysPort();
        }
        private void InitializeAxsysPort()
        {
            try
            {
                axsysPort = new SerialPort();
                axsysPort.PortName = "COM8";      // From your settings
                axsysPort.BaudRate = 9600;        // From your settings
                axsysPort.Parity = Parity.None;    // From your settings
                axsysPort.DataBits = 8;           // From your settings
                axsysPort.StopBits = StopBits.One; // From your settings

                axsysPort.Open();

                if (axsysPort.IsOpen)
                {
                    Console.WriteLine("COM Port 8 is open and ready.");
                    // Or update a UI label to indicate success
                }
                else
                {
                    Console.WriteLine("COM Port 8 failed to open.");
                    // Or update a UI label to indicate failure
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error initializing COM port: " + ex.Message);
                // Handle the error (e.g., display a message box)
            }
        }

        private void CloseAxsysPort()
        {
            if (axsysPort != null && axsysPort.IsOpen)
            {
                axsysPort.Close();
                Console.WriteLine("COM Port 8 closed.");
                // Or update a UI label
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CloseAxsysPort();
        }
    }
}
