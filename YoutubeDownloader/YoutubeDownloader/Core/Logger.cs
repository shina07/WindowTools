using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeDownloader.Core
{
    internal class Logger
    {
        internal Logger(string tag, IReporter reporter)
        {
            Reporter = reporter;
            Tag = tag;
        }

        internal void WriteDebugLine(string fmt, params object[] args)
        {
            Reporter.WriteLine(LogType.Debug, "{0}> {1}", Tag, string.Format(fmt, args));
        }

        internal void WriteErrorLine(string fmt, params object[] args)
        {
            Reporter.WriteLine(LogType.Error, "{0}> {1}", Tag, string.Format(fmt, args));
        }

        internal void WriteExceptionLine(string fmt, params object[] args)
        {
            Reporter.WriteLine(LogType.Exception, "{0}> {1}", Tag, string.Format(fmt, args));
        }

        internal void WriteNoticeLine(string fmt, params object[] args)
        {
            Reporter.WriteLine(LogType.Notice, "{0}> {1}", Tag, string.Format(fmt, args));
        }

        internal void WriteWarningLine(string fmt, params object[] args)
        {
            Reporter.WriteLine(LogType.Warning, "{0}> {1}", Tag, string.Format(fmt, args));
        }

        private IReporter Reporter { get; set; }
        private string Tag { get; set; }
    }
}
