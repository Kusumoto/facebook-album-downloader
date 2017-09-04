using System;
using Newtonsoft.Json;

namespace FacebookImageDownloader.Models
{
    public class FacebookPagingCursorsModel
    {
        [JsonProperty(PropertyName = "before")]
        public string Before { get; set; }
        [JsonProperty(PropertyName = "after")]
        public string After { get; set; }
    }
}
