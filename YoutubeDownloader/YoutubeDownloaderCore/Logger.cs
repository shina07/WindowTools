using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeDownloaderCore
{
    public class Logger
    {
        public Logger(string tag, IReporter reporter)
        {
            Reporter = reporter;
            Tag = tag;
        }

        public void WriteDebugLine(string fmt, params object[] args)
        {
            Reporter.WriteLine(LogType.Debug, "{0}> {1}", Tag, string.Format(fmt, args));
        }

        public void WriteErrorLine(string fmt, params object[] args)
        {
            Reporter.WriteLine(LogType.Error, "{0}> {1}", Tag, string.Format(fmt, args));
        }

        public void WriteExceptionLine(string fmt, params object[] args)
        {
            Reporter.WriteLine(LogType.Exception, "{0}> {1}", Tag, string.Format(fmt, args));
        }

        public void WriteNoticeLine(string fmt, params object[] args)
        {
            Reporter.WriteLine(LogType.Notice, "{0}> {1}", Tag, string.Format(fmt, args));
        }

        public void WriteWarningLine(string fmt, params object[] args)
        {
            Reporter.WriteLine(LogType.Warning, "{0}> {1}", Tag, string.Format(fmt, args));
        }

        private IReporter Reporter { get; set; }
        private string Tag { get; set; }
    }
}
