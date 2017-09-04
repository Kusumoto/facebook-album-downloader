using System;
using Newtonsoft.Json;

namespace FacebookImageDownloader.Models
{
    public class FacebookApiAlbumModel
    {
        [JsonProperty(PropertyName = "created_time")]
        public DateTime CreatedTime { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "id")]
		public string Id { get; set; }
	}
}
