using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace DMTIPACS_Uploader
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            string settingsPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"settings.json");

            string json;
            using (StreamReader trmRead = new StreamReader(settingsPath)) { json = trmRead.ReadToEnd(); }

            JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
            Entities.Settings settings = javaScriptSerializer.Deserialize<Entities.Settings>(json);

            txtSource.Text = settings.txtDefaultSource;
            txtDestination.Text = settings.txtDefaultDestination;

            fswSourceWatcher.Path = txtSource.Text;

            btnStart.Enabled = true;
            btnStop.Enabled = false;

            lblStatus.Text = "Stopped!";
            lblStatus.ForeColor = Color.IndianRed;
        }

        private void FswSourceWatcher_Created(object sender, System.IO.FileSystemEventArgs e)
        {
            if (!btnStart.Enabled)
            {

            }
        }

        private void BtnOpenSource_Click(object sender, EventArgs e)
        {
            fbdOpenSource.ShowDialog();
            txtSource.Text = fbdOpenSource.SelectedPath;
        }

        private void BtnOpenDestination_Click(object sender, EventArgs e)
        {
            fbdOpenDestination.ShowDialog();
            txtDestination.Text = fbdOpenDestination.SelectedPath;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSource.Text))
            {
                MessageBox.Show("Souce is null or empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtDestination.Text))
            {
                MessageBox.Show("Destination is null or empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                btnStart.Enabled = false;
                btnStop.Enabled = true;

                btnOpenSource.Enabled = false;
                btnOpenDestination.Enabled = false;

                lblStatus.Text = "Started!";
                lblStatus.ForeColor = Color.LightGreen;
            }
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            btnStop.Enabled = false;

            btnOpenSource.Enabled = true;
            btnOpenDestination.Enabled = true;

            lblStatus.Text = "Stopped!";
            lblStatus.ForeColor = Color.IndianRed;
        }
    }
}
