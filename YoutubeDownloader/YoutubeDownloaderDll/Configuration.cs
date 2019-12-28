using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using YoutubeDownloaderCore;

namespace YoutubeDownloaderDll
{
    public class Configuration
    {
        private static readonly string ConfigPath = "Configuration.xml";

        public static void CreateNew()
        {
            Instance = new Configuration()
            {
                DownloadPath = new List<string>(),
                Position = Point.Empty,
                Root = @".."
            };
        }

        internal static void Load()
        {
            var path = ConfigPath;

            using (var fs = new FileStream(path, FileMode.Open))
            {
                var xml = new XmlSerializer(typeof(Configuration));
                Instance = (Configuration)xml.Deserialize(fs);
            }
        }

        internal static void Save()
        {
            var path = ConfigPath;

            using (var fs = new FileStream(path, FileMode.Create))
            {
                var xml = new XmlSerializer(typeof(Configuration));
                xml.Serialize(fs, Instance);
            }
        }

        private List<string> DownloadPath { get; set; }
        private static Configuration Instance { get; set; }
        private Point Position { get; set; }
        private string Root { get; set; }
    }
}
