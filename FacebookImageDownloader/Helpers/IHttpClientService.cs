using System;
using System.Net.Http;

namespace FacebookImageDownloader.Helpers
{
    public interface IHttpClientService
    {
        HttpClient CreateHttpClient();
    }
}
