using System;
namespace FacebookImageDownloader.Core
{
    public class FacebookConstant
    {
        public const string URL_GET_ALBUM = "https://graph.facebook.com/{{ALBUMID}}/photos?fields=images,album";
        public const string USER_AGENT = "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.8.1.13) Gecko/20080311 Firefox/2.0.0.13";
    }
}
