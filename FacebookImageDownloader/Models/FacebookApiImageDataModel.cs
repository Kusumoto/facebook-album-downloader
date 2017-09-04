using System;
using Newtonsoft.Json;

namespace FacebookImageDownloader.Models
{
    public class FacebookApiImageDataModel
    {
        [JsonProperty(PropertyName = "height")]
        public int Height { get; set; }
        [JsonProperty(PropertyName = "width")]
        public int Width { get; set; }
        [JsonProperty(PropertyName = "source")]
        public string ImageUrl { get; set; }
    }
}
