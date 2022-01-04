using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module18Task2
{
    class GetInfoCommand : Command
    {
        YoutubeDownloader downloader;

        public GetInfoCommand(YoutubeDownloader downloader)
        {
            this.downloader = downloader;
        }

        public override async Task Run()
        {
            await downloader.GetInfo();
        }
    }
}
