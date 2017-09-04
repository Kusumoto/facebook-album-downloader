using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookImageDownloader.Models
{
    public class FacebookApiDataModel
    {
        [JsonProperty(PropertyName = "images")]
        public List<FacebookApiImageDataModel> Images { get; set; }
		[JsonProperty(PropertyName = "album")]
		public FacebookApiAlbumModel Album { get; set; }
		[JsonProperty(PropertyName = "id")]
		public string Id { get; set; }

        public FacebookApiDataModel() 
        {
            Images = new List<FacebookApiImageDataModel>();
        }
    }
}
