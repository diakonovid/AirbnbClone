using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Web;
using AirbnbClone.API;
using AirbnbClone.Domain.Models;
using Xunit;
using Microsoft.AspNetCore.Mvc.Testing;

namespace AirbnbClone.IntegrationTests
{
    public class SearchTest: IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly HttpClient _client;
        
        public SearchTest(WebApplicationFactory<Startup> factory)
        {
            _client = factory.CreateClient();
        }
        
        [Fact]
        public async Task PagedResult_Success()
        {
            const string url = "/api/v1/places/search?direction=1&limit=10&page=0";
            var response = await _client.GetFromJsonAsync<IReadOnlyList<Place>>(url);
            Assert.True(response?.Count == 10);
        }
    }
}