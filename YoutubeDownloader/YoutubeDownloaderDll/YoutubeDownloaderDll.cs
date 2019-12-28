using System;
using System.Threading;
using System.Windows.Forms;

namespace YoutubeDownloaderDll
{
    public static class YoutubeDownloaderDll
    {
        private static bool LoadConfiguration()
        {
            return true;
        }

        public static void Run()
        {
            if (LoadConfiguration() == false)
            {
                Configuration.CreateNew();
            }

            try
            {
                ActiveMainForm = new MainForm();
                Application.Run(ActiveMainForm);
            }
            finally
            {
                Configuration.Save();
            }
        }

        private static MainForm ActiveMainForm { get; set; }
    }
}
