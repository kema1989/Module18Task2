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
        Receiver receiver;
        YoutubeClient client = new YoutubeClient();

        string videoUrl;
        string outputFilePath;

        public DownloadCommand(string videoUrl, string outputFilePath)
        {
            this.videoUrl = videoUrl;
            this.outputFilePath = outputFilePath;
        }
        public override void Cancel()
        {
            throw new NotImplementedException();
        }

        public override async void Run()
        {
            await client.Videos.ClosedCaptions.DownloadAsync()
        }
    }
}
