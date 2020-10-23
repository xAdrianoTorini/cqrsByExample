using Customer.API;
using Fleet.Tests.Fixture;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Net.Http;
using Xunit;
[assembly: CollectionBehavior(CollectionBehavior.CollectionPerAssembly, DisableTestParallelization = true)]
namespace Fleet.Tests.Base
{
    [TestCaseOrderer("Fleet.Tests.Config.OrderByNumber", "Fleet.Tests")]
    public class TestBase : IClassFixture<WebApplicationFactory<Program>>, IClassFixture<ObjectBagFixture>
    {
        protected HttpClient _client;
        private readonly WebApplicationFactory<Program> _factory;
        protected ObjectBagFixture _objectBagFixture;


        public TestBase(WebApplicationFactory<Program> factory, ObjectBagFixture objectBagFixture)
        {
            this._factory = factory;
            this._client = _factory.CreateClient();
            this._objectBagFixture = objectBagFixture;
        }
    }
}
