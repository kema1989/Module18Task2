using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;

namespace Module18Task2
{
    class DownloadCommand : Command
    {
        YoutubeDownloader downloader;
        public DownloadCommand(YoutubeDownloader downloader)
        {
            this.downloader = downloader;
        }

        public override async Task Run()
        {
            await downloader.Download();
        }
    }
}
