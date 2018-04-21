using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;

namespace SSG
{
    public partial class Form1 : Form
    {

        //Get all available monitors
        Screen[] scrScreens = Screen.AllScreens;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnFolderBrowser_Click(object sender, EventArgs e)
        {
            //Shows up the browse dialog for the destination files
            DialogResult drResult = fbdBrowserDialog.ShowDialog();
            if (drResult == DialogResult.OK)
            {
                tbFolder.Text = fbdBrowserDialog.SelectedPath;
            }

        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            //Check if valid interval
            int intInterval = 1000;
            if (!(Int32.TryParse(tbInterval.Text, out intInterval)))
            {
                MessageBox.Show("Not a valid interval.", "SSG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (intInterval < 1)
            {
                MessageBox.Show("Not a valid interval.", "SSG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            timTimer.Interval = intInterval * 1000;
            //Check if folder exists
            if (!(Directory.Exists(tbFolder.Text)))
            {
                MessageBox.Show("The folder does not exist.", "SSG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (timTimer.Enabled)
            {
                timTimer.Enabled = false;
                btnRecord.Image = Properties.Resources.StartWithoutDebug_16x;
                return;
            }
            timTimer.Enabled = true;
            this.WindowState = FormWindowState.Minimized;
            btnRecord.Image = Properties.Resources.Stop_16x;            
        }

        private void timTimer_Tick(object sender, EventArgs e)
        {
            //Get the screenshots as JPG files
            Rectangle bounds = scrScreens[cbMonitor.SelectedIndex].Bounds;
            using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.CopyFromScreen(bounds.Left, bounds.Top, 0, 0, bounds.Size);
                }
                string strDateTime = DateTime.Now.ToString("yyyyMMddHHmmss");
                bitmap.Save(tbFolder.Text + "\\" + strDateTime + ".jpg", ImageFormat.Jpeg);
            }

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            //Minimize to tray
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                niTrayIcon.Visible = true;
                if (timTimer.Enabled)
                {
                    niTrayIcon.Text = "SSG - Recording";
                }
                else
                {
                    niTrayIcon.Text = "SSG - Idle";
                }
            }
        }

        private void niTrayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            niTrayIcon.Visible = false;
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmiOpen_Click(object sender, EventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            niTrayIcon.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Adds the number of monitors in a combox box
            int intMonitors = scrScreens.Length;
            int intCounter = 0;
            while (intCounter < intMonitors)
            {
                cbMonitor.Items.Add((intCounter + 1).ToString());
                intCounter++;
            }
            cbMonitor.SelectedIndex = 0;
        }
    }
}
