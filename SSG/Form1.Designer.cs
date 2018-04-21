namespace SSG
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timTimer = new System.Windows.Forms.Timer(this.components);
            this.tbInterval = new System.Windows.Forms.TextBox();
            this.fbdBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.tbFolder = new System.Windows.Forms.TextBox();
            this.btnRecord = new System.Windows.Forms.Button();
            this.btnFolderBrowser = new System.Windows.Forms.Button();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.lblInterval = new System.Windows.Forms.Label();
            this.lblFolder = new System.Windows.Forms.Label();
            this.lblrecord = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.niTrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsTrayIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblMonitor = new System.Windows.Forms.Label();
            this.cbMonitor = new System.Windows.Forms.ComboBox();
            this.cmsTrayIcon.SuspendLayout();
            this.SuspendLayout();
            // 
            // timTimer
            // 
            this.timTimer.Interval = 1000;
            this.timTimer.Tick += new System.EventHandler(this.timTimer_Tick);
            // 
            // tbInterval
            // 
            this.tbInterval.Location = new System.Drawing.Point(12, 25);
            this.tbInterval.Name = "tbInterval";
            this.tbInterval.Size = new System.Drawing.Size(81, 20);
            this.tbInterval.TabIndex = 0;
            // 
            // tbFolder
            // 
            this.tbFolder.Location = new System.Drawing.Point(12, 65);
            this.tbFolder.Name = "tbFolder";
            this.tbFolder.Size = new System.Drawing.Size(251, 20);
            this.tbFolder.TabIndex = 1;
            // 
            // btnRecord
            // 
            this.btnRecord.Image = global::SSG.Properties.Resources.StartWithoutDebug_16x;
            this.btnRecord.Location = new System.Drawing.Point(13, 145);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(80, 41);
            this.btnRecord.TabIndex = 4;
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // btnFolderBrowser
            // 
            this.btnFolderBrowser.Image = global::SSG.Properties.Resources.Folder_16x;
            this.btnFolderBrowser.Location = new System.Drawing.Point(263, 63);
            this.btnFolderBrowser.Name = "btnFolderBrowser";
            this.btnFolderBrowser.Size = new System.Drawing.Size(29, 23);
            this.btnFolderBrowser.TabIndex = 2;
            this.btnFolderBrowser.UseVisualStyleBackColor = true;
            this.btnFolderBrowser.Click += new System.EventHandler(this.btnFolderBrowser_Click);
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Location = new System.Drawing.Point(134, 190);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(158, 13);
            this.lblCopyright.TabIndex = 4;
            this.lblCopyright.Text = "K.Andreev - 2018, BSD License";
            // 
            // lblInterval
            // 
            this.lblInterval.AutoSize = true;
            this.lblInterval.Location = new System.Drawing.Point(10, 10);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(153, 13);
            this.lblInterval.TabIndex = 5;
            this.lblInterval.Text = "1. Enter the interval in seconds";
            // 
            // lblFolder
            // 
            this.lblFolder.AutoSize = true;
            this.lblFolder.Location = new System.Drawing.Point(10, 50);
            this.lblFolder.Name = "lblFolder";
            this.lblFolder.Size = new System.Drawing.Size(195, 13);
            this.lblFolder.TabIndex = 6;
            this.lblFolder.Text = "2. Enter or Browse the destination folder";
            // 
            // lblrecord
            // 
            this.lblrecord.AutoSize = true;
            this.lblrecord.Location = new System.Drawing.Point(10, 130);
            this.lblrecord.Name = "lblrecord";
            this.lblrecord.Size = new System.Drawing.Size(103, 13);
            this.lblrecord.TabIndex = 7;
            this.lblrecord.Text = "4. Click Start to grab";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(10, 190);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(37, 13);
            this.lblVersion.TabIndex = 8;
            this.lblVersion.Text = "v0.0.1";
            // 
            // niTrayIcon
            // 
            this.niTrayIcon.ContextMenuStrip = this.cmsTrayIcon;
            this.niTrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("niTrayIcon.Icon")));
            this.niTrayIcon.Text = "SSG - Idle";
            this.niTrayIcon.Visible = true;
            this.niTrayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.niTrayIcon_MouseDoubleClick);
            // 
            // cmsTrayIcon
            // 
            this.cmsTrayIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOpen,
            this.toolStripSeparator1,
            this.tsmiExit});
            this.cmsTrayIcon.Name = "cmsTrayIcon";
            this.cmsTrayIcon.Size = new System.Drawing.Size(104, 54);
            // 
            // tsmiOpen
            // 
            this.tsmiOpen.Name = "tsmiOpen";
            this.tsmiOpen.Size = new System.Drawing.Size(103, 22);
            this.tsmiOpen.Text = "Open";
            this.tsmiOpen.Click += new System.EventHandler(this.tsmiOpen_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(100, 6);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(103, 22);
            this.tsmiExit.Text = "Exit";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // lblMonitor
            // 
            this.lblMonitor.AutoSize = true;
            this.lblMonitor.Location = new System.Drawing.Point(10, 90);
            this.lblMonitor.Name = "lblMonitor";
            this.lblMonitor.Size = new System.Drawing.Size(110, 13);
            this.lblMonitor.TabIndex = 11;
            this.lblMonitor.Text = "3. Choose the monitor";
            // 
            // cbMonitor
            // 
            this.cbMonitor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMonitor.FormattingEnabled = true;
            this.cbMonitor.Location = new System.Drawing.Point(12, 105);
            this.cbMonitor.Name = "cbMonitor";
            this.cbMonitor.Size = new System.Drawing.Size(101, 21);
            this.cbMonitor.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 210);
            this.Controls.Add(this.cbMonitor);
            this.Controls.Add(this.lblMonitor);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblrecord);
            this.Controls.Add(this.lblFolder);
            this.Controls.Add(this.lblInterval);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.btnFolderBrowser);
            this.Controls.Add(this.tbFolder);
            this.Controls.Add(this.tbInterval);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "SSG - Screenshot Grabber";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.cmsTrayIcon.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timTimer;
        private System.Windows.Forms.TextBox tbInterval;
        private System.Windows.Forms.FolderBrowserDialog fbdBrowserDialog;
        private System.Windows.Forms.TextBox tbFolder;
        private System.Windows.Forms.Button btnFolderBrowser;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Label lblInterval;
        private System.Windows.Forms.Label lblFolder;
        private System.Windows.Forms.Label lblrecord;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.NotifyIcon niTrayIcon;
        private System.Windows.Forms.ContextMenuStrip cmsTrayIcon;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.Label lblMonitor;
        private System.Windows.Forms.ComboBox cbMonitor;
    }
}

