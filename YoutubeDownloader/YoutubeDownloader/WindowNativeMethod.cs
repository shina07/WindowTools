using System;
using System.Runtime.InteropServices;

namespace YoutubeDownloader
{
    internal class WindowNativeMethod
    {
        [DllImport("user32")]
        public static extern IntPtr SendMessage(IntPtr hWnd, int message, IntPtr wParam, IntPtr lParam);
        [DllImport("user32")]
        public static extern int RegisterWindowMessage(string message);

        public const int HWND_BROADCAST = 0xffff;
        public static readonly int WM_SHOWME = RegisterWindowMessage("WM_SHOWME");
    }
}
