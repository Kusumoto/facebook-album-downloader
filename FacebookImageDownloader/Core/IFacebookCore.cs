using System.Collections.Generic;
using FacebookImageDownloader.Models;

namespace FacebookImageDownloader.Core
{
    public interface IFacebookCore
    {
        List<FacebookApiResponseModel> GetAllPhotoList();
    }
}
