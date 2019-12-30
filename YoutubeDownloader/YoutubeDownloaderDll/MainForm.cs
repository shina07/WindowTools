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
            YoutubeHelper = new YoutubeHelper();
        }

        private void downloadPathComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Configuration.Instance.Root = downloadPathComboBox.SelectedItem.ToString();
            Configuration.Instance.DownloadPath = downloadPathComboBox.Items.Cast<string>().ToList();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Configuration.Instance.Location != this.Location)
                Configuration.Instance.FormStartPosition = FormStartPosition.Manual;

            Configuration.Instance.Location = this.Location;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            downloadPathComboBox.SelectedIndexChanged -= downloadPathComboBox_SelectedIndexChanged;
            downloadPathComboBox.Items.AddRange(Configuration.Instance.DownloadPath.ToArray());
            if (downloadPathComboBox.Items.Count != 0)
            {
                downloadPathComboBox.SelectedIndex = 0;
            }
            downloadPathComboBox.SelectedIndexChanged += downloadPathComboBox_SelectedIndexChanged;

            Logger.WriteNoticeLine("LOAD COMPLETE");
            Logger.WriteNoticeLine("CURRENT ROOT: {0}", Configuration.Instance.Root);
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

        private void urlSearchButton_Click(object sender, EventArgs e)
        {
            var url = urlSearchTextBox.Text;
            var root = Configuration.Instance.Root;

            if (YoutubeHelper.DownloadVideoFromUrl(url, root) == true)
            {
                Logger.WriteNoticeLine("DOWNLOAD SUCCESSFUL");
            }
            else
            {
                Logger.WriteErrorLine("DOWNLOAD FAILED");
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
        private YoutubeHelper YoutubeHelper { get; set; }
    }
}
