using System.Net;
using System.Linq;
using System;
using FacebookImageDownloader.Models;
using System.Collections.Generic;

namespace FacebookImageDownloader.Core
{
    public class Downloader : IDownloader
    {
        readonly WebClient WebClient;

        public Downloader(WebClient webClient)
        {
            WebClient = webClient;
            WebClient.Headers["User-Agent"] = FacebookConstant.USER_AGENT;
        }

        private void DownloadFile(string url)
        {
            var filename = url.Split('/').LastOrDefault().Split('?').FirstOrDefault();

            if (string.IsNullOrEmpty(filename))
                return;
            WebClient.DownloadFile(url, "files/" + filename);
        }

        public void StartDownloadFile(List<FacebookApiResponseModel> allPhoto)
        {
            allPhoto.ForEach(o => {
                o.Data.ForEach(x => {
                    DownloadFile(x.Images.FirstOrDefault().ImageUrl);
                });
            });
        }
    }
}
