using System.Net.Http;
using FacebookImageDownloader.Exceptions;
using FacebookImageDownloader.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net;
using System.Linq;
using FacebookImageDownloader.Helpers;

namespace FacebookImageDownloader.Core
{
    public class FacebookCore : IFacebookCore
    {
        readonly ArgumentModel Args;
        readonly IHttpClientService httpClientService;
        
        public FacebookCore()
        : this(new ArgumentModel(), new HttpClientService()) {}

        public FacebookCore(ArgumentModel _args, IHttpClientService _httpClientService)
        {
            Args = _args;
            httpClientService = _httpClientService;
        }

        public List<FacebookApiResponseModel> GetAllPhotoList()
        {
            
            using (var httpClient = httpClientService.CreateHttpClient())
            {
                var allPhotoList = new List<FacebookApiResponseModel>();
                Args.ApiUrl = string.Concat(FacebookConstant.URL_GET_ALBUM.Replace("{{ALBUMID}}", Args.AlbumId), "&access_token=", Args.AccessToken);
                while (Args.ApiUrl != null)
                {
                   var responseData = httpClient.GetAsync(Args.ApiUrl).Result;
                   if (responseData.IsSuccessStatusCode)
                   {
                      var rawResult = responseData.Content.ReadAsStringAsync().Result;
                      var jsonResult = JsonConvert.DeserializeObject<FacebookApiResponseModel>(rawResult);
                      allPhotoList.Add(jsonResult);
                      SetNextApiPageToArgument(jsonResult);
                  }
                  else
                  {
                      throw new BusinessException(responseData.ReasonPhrase);
                  }
              }
              return allPhotoList;
          }
      }

      private void SetNextApiPageToArgument(FacebookApiResponseModel model) 
      {
        if (model != null && !string.IsNullOrEmpty(model.Paging.Next)) 
        {
            Args.ApiUrl = model.Paging.Next;    
        }
        else
        {
            Args.ApiUrl = null;
        }
    }
}
}
