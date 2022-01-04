using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Converter;
using System.Threading;
using System.IO;

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

            Console.WriteLine($"Название видео: {videoInfo.Title}");
            Console.WriteLine($"Дата загрузки: {videoInfo.UploadDate}");
            Console.WriteLine($"Продолжительность: {videoInfo.Duration}");
            Console.WriteLine($"Канал: {videoInfo.Author}");
            Console.WriteLine($"Описание: {videoInfo.Description}");
        }

        public async Task Download()
        {
            Console.WriteLine("Скачивание начнется после просмотра рекламы:");
            Thread.Sleep(1000);
            Console.WriteLine("1");
            Thread.Sleep(1000);
            Console.WriteLine("x");
            Thread.Sleep(1000);
            Console.WriteLine("Bet");

            Console.WriteLine("Введите название для скачиваемого видео");
            string title = Console.ReadLine() + ".mp4";
            await youtubeClient.Videos.DownloadAsync(videoUrl, title, builder => builder.SetPreset(ConversionPreset.UltraFast));
            File.Move($@"C:\Users\YOGA\source\repos\Module18Task2\Module18Task2\bin\Debug\net5.0\{title}", $@"C:\Users\YOGA\Downloads\{title}");
            Console.WriteLine("Скачивание прошло успешно");
        }
    }
}
