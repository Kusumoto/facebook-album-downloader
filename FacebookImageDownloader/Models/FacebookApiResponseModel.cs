using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookImageDownloader.Models
{
    public class FacebookApiResponseModel
    {
        [JsonProperty(PropertyName = "data")]
        public List<FacebookApiDataModel> Data { get; set; }
        [JsonProperty(PropertyName = "paging")]
        public FacebookPagingModel Paging { get; set; }
    }
}
