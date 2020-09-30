using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MediaToolkit;
using MediaToolkit.Model;
using VideoLibrary;

namespace YoutubeDownloaderDll
{
    internal class YoutubeHelper
    {
        internal bool DownloadVideoFromUrl(string url, string root)
        {
            try
            {
                var youtube = YouTube.Default;
                var video = youtube.GetVideo(url);

                var filename = Path.Combine(root, video.FullName);

                File.WriteAllBytes(filename, video.GetBytes());
            }
            catch (Exception e)
            {
                MessageBox.Show("CANNOT DOWNLOAD YOUTUBE VIDEO: {0}", e.ToString());
                return false;
            }

            return true;
        }

        internal bool DownloadMp3FromUrl(string url, string root)
        {
            try
            {
                var youtube = YouTube.Default;
                var video = youtube.GetVideo(url);

                var path = Path.Combine(root, video.FullName);
                var filename = Path.ChangeExtension(path, ".mp3");

                File.WriteAllBytes(path, video.GetBytes());

                var inputFile = new MediaFile { Filename = path };
                var outputFile = new MediaFile { Filename = filename };

                using (var engine = new Engine())
                {
                    engine.GetMetadata(inputFile);
                    engine.Convert(inputFile, outputFile);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("CANNOT DOWNLOAD YOUTUBE VIDEO: {0}", e.ToString());
                return false;
            }

            return true;
        }

        internal bool GetThumbnail(string url, string root)
        {
            try
            {
                var youtube = YouTube.Default;
                var video = youtube.GetVideo(url);

                var path = Path.Combine(root, video.FullName);
                var filename = Path.ChangeExtension(path, ".mp3");

                File.WriteAllBytes(path, video.GetBytes());

                var inputFile = new MediaFile { Filename = path };
                var outputFile = new MediaFile { Filename = filename };

                using (var engine = new Engine())
                {
                    engine.GetMetadata(inputFile);
                    engine.Convert(inputFile, outputFile);
                    //engine.GetThumbnail()
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("CANNOT DOWNLOAD YOUTUBE VIDEO: {0}", e.ToString());
                return false;
            }

            return true;
        }
    }
}
