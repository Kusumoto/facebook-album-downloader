using System;
using System.Net;
using FacebookImageDownloader.Core;
using FacebookImageDownloader.Models;
using System.Linq;
using FacebookImageDownloader.Helpers;

namespace FacebookImageDownloader
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleHelper.WriteLineColorGreen("Access Token : " + args[1]);
			ConsoleHelper.WriteLineColorGreen("Album Id : " + args[0]);
            Console.WriteLine();

			var argsData = new ArgumentModel 
			{ 
			    AccessToken = args[1],
			    AlbumId = args[0]
			};

			HandleException.Run(() => {
                IHttpClientService connectionClient = new HttpClientService();
                IFacebookCore worker = new FacebookCore(argsData, connectionClient);

			    ConsoleHelper.WriteLineColorBlue("Fetching all photo in album ...");
			    var allPhotoList = worker.GetAllPhotoList();
                using(var webClient = new WebClient()) 
                {
					ConsoleHelper.WriteLineColorBlue("Downloading photo ...");
					IDownloader downloader = new Downloader(webClient);
                    downloader.StartDownloadFile(allPhotoList);
                }
			    Console.WriteLine("Done!");
            });
		}
    }
}
