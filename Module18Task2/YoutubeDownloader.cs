using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Converter;

namespace Module18Task2
{
    class YoutubeDownloader
    {
        YoutubeClient youtubeClient;
        string videoUrl;

        public YoutubeDownloader(string videoUrl)
        {
            youtubeClient = new YoutubeClient();
            this.videoUrl = videoUrl;
        }

        public async Task GetInfo()
        {
            var videoInfo = await youtubeClient.Videos.GetAsync(videoUrl);

            Console.WriteLine();
        }

        public async Task Download()
        {
            Console.WriteLine();

            await youtubeClient.Videos.DownloadAsync(videoUrl, "video.mp4", builder => builder.SetPreset(ConversionPreset.UltraFast));
        }
    }
}
