using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeDownloaderCore;

namespace YoutubeDownloaderDll
{
    public partial class MainForm : Form, IReporter
    {
        public MainForm()
        {
            InitializeComponent();

            Logger = new Logger(this.Name, this);
        }

        private void downloadPathComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Configuration.Save();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            Logger.WriteNoticeLine("LOAD COMPLETE");
        }

        private void searchDownloadPathButton_Click(object sender, EventArgs e)
        {
            var folderBrowserDialog = new FolderBrowserDialog();

            var result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                downloadPathComboBox.Items.Insert(0, folderBrowserDialog.SelectedPath);
                downloadPathComboBox.SelectedIndex = 0;
            }
        }

        public void WriteLine(LogType t, string fmt, params object[] args)
        {
            WriteLog(string.Format("!@{0, -10} @@{1, -15} {3}{4}", t.ToString().ToUpper(), DateTime.Now.ToString(" HH:mm:ss.fff "), Tag, string.Format(fmt, args), Environment.NewLine));
        }

        private void WriteLog(string log)
        {
            this.Invoke(new Action(() => logTextBox.AppendText(log)));
        }

        private Logger Logger { get; set; }
    }
}
