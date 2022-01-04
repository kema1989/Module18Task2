using System;
using System.Threading.Tasks;

namespace Module18Task2
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var user = new User();

            var downloader = new YoutubeDownloader("https://youtu.be/arAd1AEvlPQ");

            var getInfoCommand = new GetInfoCommand(downloader);

            user.SetCommand(getInfoCommand);

            await user.Run();

            var downloadCommand = new DownloadCommand(downloader);

            user.SetCommand(downloadCommand);

            await user.Run();

        }
    }
}
