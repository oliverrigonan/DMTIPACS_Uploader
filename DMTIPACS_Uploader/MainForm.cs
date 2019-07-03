using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.AccessControl;
using System.Security.Permissions;
using System.Security.Principal;
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

        private void Onchanged(object sender, System.IO.FileSystemEventArgs e)
        {
            if (!btnStart.Enabled)
            {
                listNotification.Items.Add(e.FullPath + " " + e.ChangeType.ToString() + " " + DateTime.Now.ToString());
                CopyFiles(e);
            }
        }

        public async void CopyFiles(System.IO.FileSystemEventArgs e)
        {
            await CopyFilesToDestination(e.FullPath, txtDestination.Text, DateTime.Now.ToString("yyyyMMddHHmmss") + "_" + e.Name);
        }

        public Task<bool> CopyFilesToDestination(string sourcePath, string destinationPath, string newFileName)
        {
            try
            {
                DirectoryInfo sourceDirectory = new DirectoryInfo(sourcePath);
                DirectorySecurity sourceDirectorySecurity = sourceDirectory.GetAccessControl();
                sourceDirectorySecurity.SetAccessRuleProtection(true, true);
                sourceDirectory.SetAccessControl(sourceDirectorySecurity);

                DirectoryInfo destinationDirectory = new DirectoryInfo(destinationPath);
                DirectorySecurity destinationDirectorySecurity = destinationDirectory.GetAccessControl();
                destinationDirectorySecurity.SetAccessRuleProtection(true, true);
                destinationDirectory.SetAccessControl(destinationDirectorySecurity);

                DirectoryInfo newDestinationDirectory = Directory.CreateDirectory(destinationPath + "\\" + sourceDirectory.Name);
                DirectorySecurity newDestinationDirectorySecurity = newDestinationDirectory.GetAccessControl();
                newDestinationDirectorySecurity.SetAccessRuleProtection(true, true);
                newDestinationDirectory.SetAccessControl(newDestinationDirectorySecurity);

                foreach (string directoryPath in Directory.GetDirectories(sourceDirectory.FullName))
                {
                    if (!Directory.Exists(directoryPath.Replace(sourcePath, destinationPath + "\\" + sourceDirectory.Name)))
                    {
                        Directory.CreateDirectory(directoryPath.Replace(sourcePath, destinationPath + "\\" + sourceDirectory.Name));

                        foreach (string sourceFile in Directory.GetFiles(directoryPath))
                        {
                            string fileName = Path.GetFileName(sourceFile);
                            string destinationFile = Path.Combine(directoryPath.Replace(sourcePath, destinationPath + "\\" + sourceDirectory.Name), fileName);

                            File.Copy(sourceFile, destinationFile, true);
                        }
                    }
                }

                foreach (string sourceFile in Directory.GetFiles(sourcePath))
                {
                    string fileName = Path.GetFileName(sourceFile);
                    string destinationFile = Path.Combine(destinationPath + "\\" + sourceDirectory.Name, fileName);

                    File.Copy(sourceFile, destinationFile, true);
                }

                return Task.FromResult(true);
            }
            catch (Exception ex)
            {
                listNotification.Items.Add(ex.Message + " " + DateTime.Now.ToString());
                return Task.FromResult(false);
            }
        }

        private void BtnOpenSource_Click(object sender, EventArgs e)
        {
            fbdOpenSource.ShowDialog();
            txtSource.Text = fbdOpenSource.SelectedPath;

            fswSourceWatcher.Path = txtSource.Text;
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
