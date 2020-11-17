using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace File_Downloader
{
    public partial class DownloaderUI : Form
    {
        public DownloaderUI()
        {
            InitializeComponent();
            bgprocess.Start();
            Directory.CreateDirectory("B:/dl/FileDownloader");
        }

      

        private void SaveLocation_Click(object sender, EventArgs e)
        {
            
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {

                this.textBox2.Text = folderDlg.SelectedPath;
                Environment.SpecialFolder root = folderDlg.RootFolder;
            }
        }
    }
}
