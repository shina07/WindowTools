using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace YoutubeDownloaderDll
{
    public static class YoutubeDownloaderDll
    {
        private static bool LoadConfiguration()
        {
            try
            {
                Configuration.Load();
            }
            catch (FileNotFoundException)
            {
                Configuration.CreateNew();
            }
            catch (Exception e)
            {
                MessageBox.Show("CANNOT LOAD CONFIGURATION: {0}", e.ToString());
                return false;
            }

            return true;
        }

        public static void Run()
        {
            if (LoadConfiguration() == false)
            {
                return;
            }

            try
            {
                ActiveMainForm = new MainForm();
                Application.Run(ActiveMainForm);
            }
            finally
            {
                var path = Configuration.Instance.DownloadPath;
                Configuration.Save();
            }
        }

        private static MainForm ActiveMainForm { get; set; }
    }
}
