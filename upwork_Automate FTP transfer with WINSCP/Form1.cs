using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace upwork_Automate_FTP_transfer_with_WINSCP
{
    public partial class Form1 : Form
    {
        bool running = false;
        bool savepass = false;

        static string backupDir;
        static string ftphost;
        static string username;
        static string password;
        static string ftpPath;
        static float delay;

        BackgroundWorker backgroundWorker1;

        public Form1()
        {
            InitializeComponent();

            backgroundWorker1 = new BackgroundWorker();
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.WorkerReportsProgress = true;

            passwordf.PasswordChar = '\u25CF';

            JObject data;

            try
            {
                StreamReader file = File.OpenText(@"c:\ftpscheduler.json");

                using (JsonTextReader reader = new JsonTextReader(file))
                {
                    data = (JObject)JToken.ReadFrom(reader);

                    if (data.ContainsKey("savepass"))
                    {
                        savepassf.Checked = (bool)data["savepass"];
                        if (savepassf.Checked) passwordf.Text = (string)data["password"];
                    }

                    hostF.Text = (string)data["host"];
                    usernamef.Text = (string)data["username"];
                    backupDir = backupF.Text = (string)data["backup"];
                    ftppathf.Text = (string)data["ftppath"];
                    delayF.Text = (string)data["delay"];
                }
            }
            catch { }

        }

        private void schedule_Click(object sender, EventArgs e)
        {
            delay = float.Parse(delayF.Text);
            delay = delay * 60 * 1000; // delay * 60 * 1000 -> delay hr

            username = usernamef.Text;
            password = passwordf.Text;
            ftphost = hostF.Text; 
            ftpPath = ftppathf.Text; 

            if (backupDir== null || backupDir.Length <1 || delay<1 || username.Length<1||password.Length<1 || ftphost.Length<1 || ftpPath.Length<1)
            {
                MessageBox.Show("All fields are required");
                return;
            }

            if (backgroundWorker1.IsBusy) return;

            cancel.Visible = true;
            schedule.Visible = false;
            backgroundWorker1.RunWorkerAsync();
            running = true;

            toggleFields(false);

            writeData(username, password, backupDir, ftphost, ftpPath, delay/60/1000);
        }

        private void writeData(string username, string password, string backup, string host, string ftp_path, float delay)
        {
            JObject _data = new JObject(
            new JProperty("username", username),
            new JProperty("backup", backup),
            new JProperty("host", host),
            new JProperty("ftppath", ftp_path),
            new JProperty("savepass", savepass),
            new JProperty("delay", delay));

            if (savepass) _data.Add(new JProperty("password", password));

            using (StreamWriter file = File.CreateText(@"c:\ftpscheduler.json"))
            using (JsonTextWriter writer = new JsonTextWriter(file))
            {
                _data.WriteTo(writer);
            }
        }

        private void toggleFields(bool v)
        {
            hostF.Enabled = v;
            usernamef.Enabled = v;
            passwordf.Enabled = v;
            backupF.Enabled = v;
            ftppathf.Enabled = v;
            delayF.Enabled = v;
            foldersel.Enabled = v;
            savepassf.Enabled = v;
        }
        

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            while (running)
            {
                Thread.Sleep((int)delay);
                ScheduleFTPUpload();
            }

            EndSchedule();
            SetStatus("");
        }

        delegate void EndScheduleCallback();
        private void EndSchedule()
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (schedule.InvokeRequired)
            {
                EndScheduleCallback d = new EndScheduleCallback(EndSchedule);
                this.Invoke(d, new object[] { });
            }
            else
            {
                MessageBox.Show("Task cancelled!");
                schedule.Enabled = true;
                cancel.Visible = false;
                cancel.Text = "Cancel";
                schedule.Visible = true;
                toggleFields(true);
            }
        }

        private void CancelSchedule()
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (schedule.InvokeRequired)
            {
                EndScheduleCallback d = new EndScheduleCallback(CancelSchedule);
                this.Invoke(d, new object[] { });
            }
            else
            {
                running = false;
                cancel.Text = "Cancelling...";
                SetStatus("");
                cancel.Enabled = false;
            }
        }

        delegate void SetStatusCallback(string status);
        private void SetStatus(string status)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (statusF.InvokeRequired)
            {
                SetStatusCallback d = new SetStatusCallback(SetStatus);
                this.Invoke(d, new object[] { status });
            }
            else
            {
                statusF.Text = status;
            }
        }


        private void ScheduleFTPUpload()
        {

            using (var client = new WebClient())
            {
                client.Credentials = new NetworkCredential(username, password);

                try
                {
                    SetStatus("Uploading...");
                    IEnumerable<string> files = Directory.EnumerateFiles(backupDir);

                    foreach (string file in files)
                    {
                        client.UploadFile("ftp://" + ftphost + "/" + ftpPath + "/" + Path.GetFileName(file), WebRequestMethods.Ftp.UploadFile, file);
                    }


                    SetStatus("Uploaded!");
                    if (Directory.Exists(backupDir))
                    {
                        //Directory.Delete(backupDir, true);
                        SetStatus("Directory Deleted!");
                    }
                }
                catch (Exception f)
                {
                    SetStatus("Error!");
                    MessageBox.Show(f.Message);
                    CancelSchedule();
                }
            }

        }

        private void foldersel_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK)
                {
                    if (!string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    {
                        //string[] files = Directory.GetFiles(fbd.SelectedPath);

                        backupDir = backupF.Text = fbd.SelectedPath;
                    }
                    else
                    {
                        MessageBox.Show("Invalid directory");
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cancel.Visible = false;

            if (backgroundWorker1.IsBusy)
            {
                cancel.Visible = true;
                schedule.Enabled = false;
                schedule.Visible = false;
            }

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            running = false;
            cancel.Text = "Cancelling...";
            cancel.Enabled = false;
        }

        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (backgroundWorker1!=null && backgroundWorker1.IsBusy)
            {
                e.Cancel = true;
                this.WindowState = FormWindowState.Minimized;
                Hide();
            }

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                mynotifyicon.Visible = true;
                mynotifyicon.Icon = SystemIcons.Application;
                mynotifyicon.BalloonTipText = "Click to maximize scheduler";
                mynotifyicon.ShowBalloonTip(5000);
                this.Hide();
            }

            else if (FormWindowState.Normal == this.WindowState && mynotifyicon!=null)
            {
                mynotifyicon.Visible = false;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Show();
        }

        private void savepassf_CheckedChanged(object sender, EventArgs e)
        {
           savepass = savepassf.Checked;
        }
    }
}
