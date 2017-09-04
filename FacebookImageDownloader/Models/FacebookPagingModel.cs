using System;
using Newtonsoft.Json;

namespace FacebookImageDownloader.Models
{
    public class FacebookPagingModel
    {
        [JsonProperty(PropertyName = "cursors")]
        public FacebookPagingCursorsModel Cursors { get; set; }
        [JsonProperty(PropertyName = "next")]
        public string Next { get; set; }
    }
}
