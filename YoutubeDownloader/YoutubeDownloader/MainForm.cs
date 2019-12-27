using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using YoutubeDownloader.Core;

namespace YoutubeDownloader
{
    public partial class MainForm : Form, IReporter
    {
        public MainForm()
        {
            InitializeComponent();

            Logger = new Logger(this.Name, this);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Logger.WriteNoticeLine("LOAD COMPLETE");
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
