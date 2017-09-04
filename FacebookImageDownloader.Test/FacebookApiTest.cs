using Xunit;
using System.Collections.Generic;
using FacebookImageDownloader.Models;
using System.IO;
using Newtonsoft.Json;
using System;
using RichardSzalay.MockHttp;
using FacebookImageDownloader.Helpers;
using FacebookImageDownloader.Core;
using System.Linq;

namespace FacebookImageDownloader.Test
{
    public class FacebookApiTest
    {
        private List<FacebookApiResponseModel> GenerateMockData() 
        {
            var mockApiResponse = new List<FacebookApiResponseModel>();
            var localPath = AppDomain.CurrentDomain.BaseDirectory;
            var rawMockJson = File.ReadAllText(localPath + "/Example/example_api_response.json");
            var jsonResult = JsonConvert.DeserializeObject<FacebookApiResponseModel>(rawMockJson);
            mockApiResponse.Add(jsonResult);
            return mockApiResponse;
        }

        private string GenerateRawJson()
        {
			var localPath = AppDomain.CurrentDomain.BaseDirectory;
			var rawMockJson = File.ReadAllText(localPath + "/Example/example_api_response.json");
            return rawMockJson;
        }

        [Fact]
        public void Fetch_Api_Test() 
        {
            var mockHttp = new MockHttpMessageHandler();
			mockHttp.When("*")
                    .Respond("application/json", GenerateRawJson());
            var client = mockHttp.ToHttpClient();
            IHttpClientService httpClient = new HttpClientService(client);
            IFacebookCore fbApi = new FacebookCore(new ArgumentModel(), httpClient);
			var expectedResult = GenerateMockData();
            var actualResult = fbApi.GetAllPhotoList();
            Assert.Equal(expectedResult.Select(x => x.Data).Count(), actualResult.Select(x => x.Data).Count());
		}
    }
}
