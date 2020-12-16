using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLController
{
    public partial class Services : Form
    {
        public Services()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceController service = new ServiceController(Util.GetServ(servicesSelection.Text));

                TimeSpan timeout = TimeSpan.FromMilliseconds(20000);

                service.Start();
                service.WaitForStatus(ServiceControllerStatus.Running, timeout);

                txtResult.Text = "Success! Service started";

                VerifyStatus();
            }
            catch (Exception ex)
            {
                txtResult.Text = ex.Message;
            }

        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceController service = new ServiceController(Util.GetServ(servicesSelection.Text));

                TimeSpan timeout = TimeSpan.FromMilliseconds(20000);

                service.Stop();
                service.WaitForStatus(ServiceControllerStatus.Stopped, timeout);

                txtResult.Text = "Success! Service stopped";

                VerifyStatus();
            }
            catch (Exception ex)
            {
                txtResult.Text = ex.Message;
            }

        }

        private void ServicesSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerifyStatus();
        }

        public void VerifyStatus()
        {
            if (servicesSelection.Text.Length > 0)
            {
                string result = Util.DoesServiceExist(Util.GetServ(servicesSelection.Text));

                if (result.ToLower() == "running")
                {
                    lblStatusResult.Text = "Activated";
                    lblStatusResult.ForeColor = Color.ForestGreen;
                }
                else if (result.ToLower() == "stopped")
                {
                    lblStatusResult.Text = "Disabled";
                    lblStatusResult.ForeColor = Color.DarkRed;
                }
                else
                {
                    lblStatusResult.Text = "unknown";
                    lblStatusResult.ForeColor = Color.DarkOrange;
                }
            }
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            textServiceList.Text = string.Empty;

            List<string> servicesList = Util.ListServices(textSearch.Text);

            foreach (string service in servicesList)
            {
                textServiceList.Text += service + Environment.NewLine;
            }

        }
    }
}
