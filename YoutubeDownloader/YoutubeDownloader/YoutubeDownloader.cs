﻿using System;
using System.Threading;
using System.Windows.Forms;
using YoutubeDownloaderCore;

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
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);

                    Run();
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

        private static void Run()
        {
            YoutubeDownloaderDll.YoutubeDownloaderDll.Run();
        }
        
    }
}
