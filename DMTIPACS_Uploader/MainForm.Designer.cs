namespace DMTIPACS_Uploader
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.btnOpenSource = new System.Windows.Forms.Button();
            this.btnOpenDestination = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.listNotification = new System.Windows.Forms.ListBox();
            this.fswSourceWatcher = new System.IO.FileSystemWatcher();
            this.fbdOpenSource = new System.Windows.Forms.FolderBrowserDialog();
            this.fbdOpenDestination = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fswSourceWatcher)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(537, 44);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "DMTIPACS Uploader";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.lblStatus);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 418);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(537, 27);
            this.panel2.TabIndex = 1;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.IndianRed;
            this.lblStatus.Location = new System.Drawing.Point(475, 7);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(50, 13);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Stopped!";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(434, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Status:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Version: 1.201907030953.NOR";
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(78, 59);
            this.txtSource.Name = "txtSource";
            this.txtSource.ReadOnly = true;
            this.txtSource.Size = new System.Drawing.Size(366, 20);
            this.txtSource.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Source:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Destination:";
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(78, 85);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.ReadOnly = true;
            this.txtDestination.Size = new System.Drawing.Size(366, 20);
            this.txtDestination.TabIndex = 4;
            // 
            // btnOpenSource
            // 
            this.btnOpenSource.Location = new System.Drawing.Point(450, 57);
            this.btnOpenSource.Name = "btnOpenSource";
            this.btnOpenSource.Size = new System.Drawing.Size(75, 23);
            this.btnOpenSource.TabIndex = 6;
            this.btnOpenSource.Text = "Open";
            this.btnOpenSource.UseVisualStyleBackColor = true;
            this.btnOpenSource.Click += new System.EventHandler(this.BtnOpenSource_Click);
            // 
            // btnOpenDestination
            // 
            this.btnOpenDestination.Location = new System.Drawing.Point(450, 83);
            this.btnOpenDestination.Name = "btnOpenDestination";
            this.btnOpenDestination.Size = new System.Drawing.Size(75, 23);
            this.btnOpenDestination.TabIndex = 7;
            this.btnOpenDestination.Text = "Open";
            this.btnOpenDestination.UseVisualStyleBackColor = true;
            this.btnOpenDestination.Click += new System.EventHandler(this.BtnOpenDestination_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Controls.Add(this.btnStart);
            this.panel3.Controls.Add(this.btnStop);
            this.panel3.Controls.Add(this.listNotification);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 123);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(537, 295);
            this.panel3.TabIndex = 8;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(372, 6);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(450, 6);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // listNotification
            // 
            this.listNotification.FormattingEnabled = true;
            this.listNotification.Location = new System.Drawing.Point(12, 34);
            this.listNotification.Name = "listNotification";
            this.listNotification.Size = new System.Drawing.Size(513, 251);
            this.listNotification.TabIndex = 0;
            // 
            // fswSourceWatcher
            // 
            this.fswSourceWatcher.EnableRaisingEvents = true;
            this.fswSourceWatcher.NotifyFilter = ((System.IO.NotifyFilters)((((System.IO.NotifyFilters.FileName | System.IO.NotifyFilters.DirectoryName) 
            | System.IO.NotifyFilters.LastWrite) 
            | System.IO.NotifyFilters.LastAccess)));
            this.fswSourceWatcher.SynchronizingObject = this;
            this.fswSourceWatcher.Changed += new System.IO.FileSystemEventHandler(this.Onchanged);
            this.fswSourceWatcher.Created += new System.IO.FileSystemEventHandler(this.Onchanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(537, 445);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnOpenDestination);
            this.Controls.Add(this.btnOpenSource);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "DMTIPACS Uploader";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fswSourceWatcher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.Button btnOpenSource;
        private System.Windows.Forms.Button btnOpenDestination;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox listNotification;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.IO.FileSystemWatcher fswSourceWatcher;
        private System.Windows.Forms.FolderBrowserDialog fbdOpenSource;
        private System.Windows.Forms.FolderBrowserDialog fbdOpenDestination;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label5;
    }
}

