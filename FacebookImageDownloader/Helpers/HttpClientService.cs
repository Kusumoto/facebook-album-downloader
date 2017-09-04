using System;
using System.Net.Http;

namespace FacebookImageDownloader.Helpers
{
    public class HttpClientService : IHttpClientService
    {
        HttpClient httpClient;

        public HttpClientService()
            : this(new HttpClient()) {}

        public HttpClientService(HttpClient _httpClient) 
        {
            httpClient = _httpClient;
        }

        public HttpClient CreateHttpClient()
        {
            return httpClient;
        }
    }
}
