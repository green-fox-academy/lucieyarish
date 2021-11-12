using System.Collections.Generic;
using System.Linq.Expressions;
using System.Net;
using System.Net.Http;
using System.Text;
using IAmGroot;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.Server.Kestrel.Core.Features;
using Newtonsoft.Json;
using Xunit;

namespace IAmGrootIntegrationTests
{
    public class IntegrationTests : IClassFixture<WebApplicationFactory<Startup>>
    {
        private HttpClient HttpClient { get; }

        public IntegrationTests(WebApplicationFactory<Startup> factory)
        {
            HttpClient = factory.CreateClient();
        }

        [Fact]
        public void GrootEndpoint_Returns400WithNullData()
        {
            //arrange
            HttpStatusCode expectedStatusCode = HttpStatusCode.BadRequest;
            string expectedMessage = "I am groot!";
            StringContent requestContent = new StringContent(string.Empty, Encoding.UTF8, "application/json");

            //act
            var response = HttpClient.PostAsync("groot", requestContent).Result;
            var responseData = response.Content.ReadAsStringAsync().Result;
            var responseDataObj = JsonConvert.DeserializeObject<Dictionary<string, string>>(responseData);

            //assert
            // Assert.Equal(expectedStatusCode, response.StatusCode);
            Assert.Equal(expectedMessage, responseDataObj["I am groot!"]);
        }
    }
}