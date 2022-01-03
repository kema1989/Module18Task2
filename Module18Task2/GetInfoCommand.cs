using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module18Task2
{
    class GetInfoCommand : Command
    {
        Receiver receiver;
        YoutubeExplode.YoutubeClient youtubeClient;

        public GetInfoCommand(Receiver receiver)
        {
            this.receiver = receiver;
        }

        public override void Cancel()
        {
            throw new NotImplementedException();
        }

        public override void Run(string url)
        {
            var info = youtubeClient.Videos.GetAsync(url);
        }
    }
}
