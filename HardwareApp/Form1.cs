using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HardwareApp
{
    public partial class Form1 : Form
    {
        private AxSysJobRunner _jobRunner;

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
    }
}
