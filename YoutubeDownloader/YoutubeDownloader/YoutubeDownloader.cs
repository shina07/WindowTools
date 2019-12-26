using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YoutubeDownloader
{
    internal static class YoutubeDownloader
    {
        private static Mutex mutex = new Mutex(true, "YoutubeDownlaoderSingletonLock");

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Always Check Singleton at the beginning
            var available = false;

            try
            {
                available = mutex.WaitOne(1, false);
            }
            catch (AbandonedMutexException)
            {
                available = true;
            }

            if (available)
            {
                try
                {
                    Application.SetHighDpiMode(HighDpiMode.SystemAware);
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);

                    Application.Run(new MainForm());
                }
                finally
                {
                    mutex.ReleaseMutex();
                }
            }
            else
            {
                WindowNativeMethod.SendMessage((IntPtr)WindowNativeMethod.HWND_BROADCAST, WindowNativeMethod.WM_SHOWME, IntPtr.Zero, IntPtr.Zero);
            }
        }
    }
}
