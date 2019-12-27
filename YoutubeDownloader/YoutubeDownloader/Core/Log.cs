using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeDownloader.Core
{
    // Static Log
    internal class Log : IReporter
    {
        static Log()
        {
            Instance = new Log();
        }

        public static void WriteLine(object obj)
        {

        }

        public static void WriteLine(string fmt, params object[] args)
        {
            WriteLine((object)string.Format(fmt, args));
        }

        public void WriteLine(LogType t, string fmt, params object[] args)
        {

        }

        public static Log Instance { get; set; }
    }
}
