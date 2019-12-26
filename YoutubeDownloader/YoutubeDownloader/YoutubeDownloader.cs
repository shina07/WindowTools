using System;
using System.Threading;
using System.Windows.Forms;

namespace YoutubeDownloader
{
    static class YoutubeDownloader
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
                WindowNativeMethods.SendMessage((IntPtr)WindowNativeMethods.HWND_BROADCAST, WindowNativeMethods.WM_SHOWME, IntPtr.Zero, IntPtr.Zero);
            }
        }
    }
}
