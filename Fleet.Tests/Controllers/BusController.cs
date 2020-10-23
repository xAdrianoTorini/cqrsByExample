using Customer.API;
using Customer.Domain.Commands;
using Customer.Domain.Models;
using Fleet.Tests.Base;
using Fleet.Tests.Config;
using Fleet.Tests.Fixture;
using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using Xunit;

namespace Fleet.Tests
{
    public class BusControllerTest : TestBase
    {

        public BusControllerTest(WebApplicationFactory<Program> factory, ObjectBagFixture objectBagFixture) : base(factory, objectBagFixture)
        {
        }

        [Theory, TestPriority(1)]
        [InlineData("api/bus/")]
        public async Task CreateBus(string url)
        {
            var jsonContent = JsonConvert.SerializeObject(new CreateBusCommand() { License = "MDA-0924", Assembler = "BMW", Model = "Van" });

            var contentString = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync(url, contentString);

            var busString = response.Content.ReadAsStringAsync().Result;
            var bus = JsonConvert.DeserializeObject<Bus>(busString.Replace("\\", ""));

            this._objectBagFixture.TestBag.BusId = bus.Id;

            response.EnsureSuccessStatusCode();
            Assert.Equal("application/json; charset=utf-8",
                response.Content.Headers.ContentType.ToString());

        }
        [Theory, TestPriority(2)]
        [InlineData("api/Bus/")]
        public async Task GetBus(string url)
        {
            var response = await _client.GetAsync(string.Format("{0}{1}", url, this._objectBagFixture.TestBag.BusId));

            response.EnsureSuccessStatusCode();

            Assert.Equal("application/json; charset=utf-8",
                response.Content.Headers.ContentType.ToString());

        }

        [Theory, TestPriority(3)]
        [InlineData("api/bus/")]
        public async Task UpdateBus(string url)
        {

            var json = JsonConvert.SerializeObject(new UpdateBusCommand() { License = "MDA-0924", Assembler = "BMW", Model = "Batmovel", Id = this._objectBagFixture.TestBag.BusId.ToString() });
            var contentString = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _client.PutAsync(url, contentString);

            response.EnsureSuccessStatusCode();

            Assert.Equal("application/json; charset=utf-8",
                response.Content.Headers.ContentType.ToString());
        }

    }
}
