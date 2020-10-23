using System.Dynamic;

namespace Fleet.Tests.Fixture
{
    public class ObjectBagFixture 
    {
        public dynamic TestBag { get; set; }

        public ObjectBagFixture()
        {
            TestBag = new ExpandoObject();
        }
    }
}
