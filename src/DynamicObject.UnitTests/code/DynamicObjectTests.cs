using Newtonsoft.Json;
using Xunit;

namespace DynamicObjects.Tests
{
    public class DynamicObjectTests
    {
        [Fact]
        public void XUnitTestDynamicObject()
        {
            var car = new DynamicObject();
            // Create properties
            car.Instance.Make = "G35";
            car.Instance.Year = 2014;
            car.Instance.CurrentSpeed = 45;

            // Add property in a more dynamic manor.
            car.AddProperty("TopSpeed", 180);

            var output = JsonConvert.SerializeObject(car);

            // {"Instance":{"Make":"G35","Year":2014,"CurrentSpeed":45,"TopSpeed":180}}
            Assert.Equal("{\"Instance\":{\"Make\":\"G35\",\"Year\":2014,\"CurrentSpeed\":45,\"TopSpeed\":180}}", output);
        }
    }
}
