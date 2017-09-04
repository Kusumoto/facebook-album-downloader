using System.Collections.Generic;
using FacebookImageDownloader.Models;

namespace FacebookImageDownloader.Core
{
    public interface IDownloader
    {
        void StartDownloadFile(List<FacebookApiResponseModel> allPhoto);
    }
}
