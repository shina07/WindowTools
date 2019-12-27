using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace YoutubeDownloader
{
    internal class Configuration
    {
        private static readonly string ConfigPath = "Configuration.xml";

        internal void CreateNew()
        {
            Instance = new Configuration()
            {
                DownloadPath = new List<string>(),
                Position = Point.Empty,
                Root = @".."
            };
        }

        internal void Load()
        {
            var path = ConfigPath;

            using (var fs = new FileStream(path, FileMode.Open))
            {
                var xml = new XmlSerializer(typeof(Configuration));
                Instance = (Configuration)xml.Deserialize(fs);
            }
        }

        internal void Save()
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
