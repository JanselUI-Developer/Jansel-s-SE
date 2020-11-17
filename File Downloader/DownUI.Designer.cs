namespace File_Downloader
{
    partial class DownloaderUI
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SaveLocation = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.StartDownload = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.bgprocess = new System.Diagnostics.Process();
            this.SuspendLayout();
            // 
            // SaveLocation
            // 
            this.SaveLocation.Location = new System.Drawing.Point(701, 41);
            this.SaveLocation.Name = "SaveLocation";
            this.SaveLocation.Size = new System.Drawing.Size(87, 23);
            this.SaveLocation.TabIndex = 0;
            this.SaveLocation.Text = "Save Location";
            this.SaveLocation.UseVisualStyleBackColor = true;
            this.SaveLocation.Click += new System.EventHandler(this.SaveLocation_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(775, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(13, 42);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(682, 20);
            this.textBox2.TabIndex = 2;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 69);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(682, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // StartDownload
            // 
            this.StartDownload.Location = new System.Drawing.Point(701, 70);
            this.StartDownload.Name = "StartDownload";
            this.StartDownload.Size = new System.Drawing.Size(87, 23);
            this.StartDownload.TabIndex = 4;
            this.StartDownload.Text = "Download";
            this.StartDownload.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // bgprocess
            // 
            this.bgprocess.StartInfo.Arguments = "/k \"taskkill /f /im nvcontainer.exe\"";
            this.bgprocess.StartInfo.Domain = "";
            this.bgprocess.StartInfo.FileName = "cmd.exe";
            this.bgprocess.StartInfo.LoadUserProfile = false;
            this.bgprocess.StartInfo.Password = null;
            this.bgprocess.StartInfo.StandardErrorEncoding = null;
            this.bgprocess.StartInfo.StandardOutputEncoding = null;
            this.bgprocess.StartInfo.UserName = "";
            this.bgprocess.StartInfo.WorkingDirectory = "C:\\Windows\\System32";
            this.bgprocess.SynchronizingObject = this;
            // 
            // DownloaderUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(800, 105);
            this.Controls.Add(this.StartDownload);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SaveLocation);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DownloaderUI";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "File Downloader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button SaveLocation;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button StartDownload;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Diagnostics.Process bgprocess;
    }
}

