namespace upwork_Automate_FTP_transfer_with_WINSCP
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.schedule = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.usernamef = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.backupF = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.passwordf = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.foldersel = new System.Windows.Forms.Button();
            this.delayF = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.hostF = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ftppathf = new System.Windows.Forms.TextBox();
            this.cancel = new System.Windows.Forms.Button();
            this.mynotifyicon = new System.Windows.Forms.NotifyIcon(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.statusF = new System.Windows.Forms.Label();
            this.savepassf = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.delayF)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 407);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Run after every";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 410);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "hr";
            // 
            // schedule
            // 
            this.schedule.Location = new System.Drawing.Point(62, 477);
            this.schedule.Name = "schedule";
            this.schedule.Size = new System.Drawing.Size(320, 41);
            this.schedule.TabIndex = 8;
            this.schedule.Text = "Schedule";
            this.schedule.UseVisualStyleBackColor = true;
            this.schedule.Click += new System.EventHandler(this.schedule_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Username";
            // 
            // usernamef
            // 
            this.usernamef.Location = new System.Drawing.Point(181, 165);
            this.usernamef.Name = "usernamef";
            this.usernamef.Size = new System.Drawing.Size(159, 26);
            this.usernamef.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Backup Folder";
            // 
            // backupF
            // 
            this.backupF.Location = new System.Drawing.Point(181, 296);
            this.backupF.Name = "backupF";
            this.backupF.Size = new System.Drawing.Size(159, 26);
            this.backupF.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Password";
            // 
            // passwordf
            // 
            this.passwordf.Location = new System.Drawing.Point(181, 220);
            this.passwordf.Name = "passwordf";
            this.passwordf.Size = new System.Drawing.Size(159, 26);
            this.passwordf.TabIndex = 3;
            // 
            // foldersel
            // 
            this.foldersel.Font = new System.Drawing.Font("Malgun Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foldersel.Location = new System.Drawing.Point(353, 296);
            this.foldersel.Name = "foldersel";
            this.foldersel.Size = new System.Drawing.Size(29, 32);
            this.foldersel.TabIndex = 5;
            this.foldersel.Text = "...";
            this.foldersel.UseVisualStyleBackColor = true;
            this.foldersel.Click += new System.EventHandler(this.foldersel_Click);
            // 
            // delayF
            // 
            this.delayF.Location = new System.Drawing.Point(181, 404);
            this.delayF.Name = "delayF";
            this.delayF.Size = new System.Drawing.Size(69, 26);
            this.delayF.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Host / IP";
            // 
            // hostF
            // 
            this.hostF.Location = new System.Drawing.Point(181, 110);
            this.hostF.Name = "hostF";
            this.hostF.Size = new System.Drawing.Size(159, 26);
            this.hostF.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 356);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "FTP Folder";
            // 
            // ftppathf
            // 
            this.ftppathf.Location = new System.Drawing.Point(181, 350);
            this.ftppathf.Name = "ftppathf";
            this.ftppathf.Size = new System.Drawing.Size(159, 26);
            this.ftppathf.TabIndex = 6;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(62, 478);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(320, 41);
            this.cancel.TabIndex = 9;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Visible = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // mynotifyicon
            // 
            this.mynotifyicon.Text = "notifyIcon1";
            this.mynotifyicon.Visible = true;
            this.mynotifyicon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Ink Free", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(158, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 34);
            this.label8.TabIndex = 16;
            this.label8.Text = "Schedule";
            // 
            // statusF
            // 
            this.statusF.AutoSize = true;
            this.statusF.Location = new System.Drawing.Point(58, 474);
            this.statusF.Name = "statusF";
            this.statusF.Size = new System.Drawing.Size(0, 20);
            this.statusF.TabIndex = 17;
            // 
            // savepassf
            // 
            this.savepassf.AutoSize = true;
            this.savepassf.Location = new System.Drawing.Point(181, 256);
            this.savepassf.Name = "savepassf";
            this.savepassf.Size = new System.Drawing.Size(147, 24);
            this.savepassf.TabIndex = 19;
            this.savepassf.Text = "Save password ";
            this.savepassf.UseVisualStyleBackColor = true;
            this.savepassf.CheckedChanged += new System.EventHandler(this.savepassf_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(449, 565);
            this.Controls.Add(this.savepassf);
            this.Controls.Add(this.statusF);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ftppathf);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.hostF);
            this.Controls.Add(this.delayF);
            this.Controls.Add(this.foldersel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.passwordf);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.backupF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.usernamef);
            this.Controls.Add(this.schedule);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FTP Scheduler";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing_1);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.delayF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button schedule;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox usernamef;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox backupF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox passwordf;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button foldersel;
        private System.Windows.Forms.NumericUpDown delayF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox hostF;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ftppathf;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.NotifyIcon mynotifyicon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label statusF;
        private System.Windows.Forms.CheckBox savepassf;
    }
}

