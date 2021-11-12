using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using Reddit;
using Xunit;

namespace RedditIntegrationTests
{
    public class IntegrationTests : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly WebApplicationFactory<Startup> factory;
        private HttpClient HttpClient { get; set; }

        public IntegrationTests(WebApplicationFactory<Startup> factory)
        {
            HttpClient = factory.CreateClient();
        }

        [Fact]
        public void VoteUp_Returns200AndAllPosts()
        {
            //arrange
            HttpStatusCode expectedStatusCode = HttpStatusCode.OK;
            long expectedId = 1;
            

            //act

            //assert
        }
    }
        
}